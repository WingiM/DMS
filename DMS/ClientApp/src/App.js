import React from 'react';
import './custom.css'
import Sidebar from "./components/Sidebar";
import RoomsBlock from "./components/RoomsBlock"
import InRoomResidents from "./components/InRoomResidents";
import {Navigate, Route, Routes} from "react-router-dom";
import Login from "./components/Login";
import Residents from "./components/Residents";
import Settings from "./components/Settings";

class App extends React.Component {
    static displayName = App.name;

    constructor(props) {
        super(props);

        this.fetchStats();

        this.state = {
            showRooms: false,
            showInRoomResidents: false,
            showResidents: false,
            activeRoom: [],
            settled: 0,
            total: 0,
        }

        this.showRoomsButtonClickHandler = this.showRoomsButtonClickHandler.bind(this);
        this.openRoomButtonClickHandler = this.openRoomButtonClickHandler.bind(this);
        this.closeRoomButtonClickHandler = this.closeRoomButtonClickHandler.bind(this);
        this.showResidentsBlockButtonClickHandler = this.showResidentsBlockButtonClickHandler.bind(this);
    }

    //handlers

    showResidentsBlockButtonClickHandler() {
        this.setState({showRooms: false})
        this.setState({showInRoomResidents: false})
        this.setState({showResidents: true})
    }

    showRoomsButtonClickHandler() {
        this.setState({showResidents: false})
        this.setState({showRooms: true})
    }

    async openRoomButtonClickHandler(room) {
        this.setState({showInRoomResidents: false})
        const data = await this.fetchRoom(room)
        this.setState({activeRoom: data})
        this.setState({showInRoomResidents: true})
    }

    closeRoomButtonClickHandler() {
        this.setState({showInRoomResidents: false})
    }

    // fetch functions

    async fetchRoom(room) {
        const requestUrl = "api/rooms/" + room
        const response = await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization": localStorage.getItem("token")
            }
        })

        const data = await response.json()
        return data.Value
    }
    

    getTokenExpDate() {
        let token = localStorage.getItem("token").split(" ")[1];
        console.log(token)
        var base64Url = token.split('.')[1];
        var base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
        var jsonPayload = decodeURIComponent(atob(base64).split('').map(function (c) {
            return '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2);
        }).join(''));
        let parsed = JSON.parse(jsonPayload)
        return parsed["exp"] * 1000;
    }
    
    checkTokenLifetime() {
        try {
            let expDate = this.getTokenExpDate();
            console.log()
            if (new Date().getTime() > expDate) {
                localStorage.removeItem("token");
                return <Navigate to="/login"/>
            } 
        } catch (e) {
            console.log(e)
        }
        
    }

    

    async fetchStats() {
        const requestUrl = "api/stats"
        const response = await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization": localStorage.getItem("token")
            }
        })
        try {
            const data = await response.json()
            this.setState({settled: data.Value["Settled"]})
            this.setState({total: data.Value["Total"]})
        } catch (e) {

        }

    }

    render() {
        this.checkTokenLifetime()
        return (
            <Routes>
                <Route path="/login" element={<Login/>}/>
                <Route path="*" element={
                    <Routes>
                        <Route path="/login" element={<Login/>}/>
                        <Route path="/" element={
                            <React.StrictMode>
                                <Sidebar
                                    showRooms={this.showRoomsButtonClickHandler}
                                    showResidents={this.showResidentsBlockButtonClickHandler}
                                    settled={this.state.settled}
                                    total={this.state.total}
                                />
                                <Residents show={this.state.showResidents}/>
                                <RoomsBlock
                                    show={this.state.showRooms}
                                    openRoom={this.openRoomButtonClickHandler}
                                />
                                <InRoomResidents
                                    show={this.state.showInRoomResidents}
                                    closeButtonClickHandler={this.closeRoomButtonClickHandler}
                                    room={this.state.activeRoom}
                                />
                            </React.StrictMode>
                        }/>

                    </Routes>
                }/>
                <Route path="/settings" element={<Settings/>} />
            </Routes>
        )
    }
}

export default App;
