import React from 'react';
import './custom.css'
import Sidebar from "./components/Sidebar";
import RoomsBlock from "./components/RoomsBlock"
import InRoomResidents from "./components/InRoomResidents";
import {Navigate, Route, Routes} from "react-router-dom";
import Login from "./components/Login";
import Residents from "./components/Residents";
import {Modal} from "reactstrap";
import ModalWindow from "./components/ModalWindow";

class App extends React.Component {
    static displayName = App.name;

    constructor(props) {
        super(props);

        this.state = {
            showRooms: false,
            showInRoomResidents: false,
            showResidents: false,
            activeRoom: [],
        }

        this.showRoomsButtonClickHandler = this.showRoomsButtonClickHandler.bind(this);
        this.openRoomButtonClickHandler = this.openRoomButtonClickHandler.bind(this);
        this.closeRoomButtonClickHandler = this.closeRoomButtonClickHandler.bind(this);
        this.showResidentsBlockButtonClickHandler = this.showResidentsBlockButtonClickHandler.bind(this);
    }
    
    //handlers

    showResidentsBlockButtonClickHandler() {
        this.setState({
            showRooms: false,
            showInRoomResidents: false,
            showResidents: true
        })
    }

    showRoomsButtonClickHandler() {
        this.setState({
            showResidents: false,
            showRooms: true})
    }

    async openRoomButtonClickHandler(room) {
        this.setState({showInRoomResidents: false})
        const data = await this.fetchRoom(room)
        this.setState({activeRoom: data})
        this.setState({showInRoomResidents: true})
    }

    closeRoomButtonClickHandler() {
        this.setState({showInRoomResidents : false})
    }
    
    // fetch functions
    
    async fetchRoom(room) {
        const requestUrl = "api/rooms/" + room
        const response = await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization" : localStorage.getItem("token")
            }
        })
        
        const data = await response.json()
        return data.Value
    }

    async checkTokenLifeTime() {
        const data = await fetch("/api/rooms/floors", {
            method: "GET",
            headers: {
                "Authorization": localStorage.getItem("token")
            }
        });

        if (data.status !== 200) {
            return <Navigate to="/login"/>
        }
    }

    async fetchStats() {
        const requestUrl = "api/stats"
        const response = await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization" : localStorage.getItem("token")
            }
        })

        const data = await response.json()
        const value = await data.Value
        this.setState({
            settled: value["Settled"],
            total: value["Total"],
            free: value["Total"] - value["Settled"],
            percentage: value["Settled"] / value["Total"] * 100 | 0
        })
        console.log(this.state.percentage)
    }

    render() {
        this.checkTokenLifeTime()
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
                                />
                                <Residents show={this.state.showResidents}/>
                                <RoomsBlock
                                    show={this.state.showRooms}
                                    openRoom = {this.openRoomButtonClickHandler}
                                />
                                <InRoomResidents
                                    show={this.state.showInRoomResidents}
                                    closeButtonClickHandler = {this.closeRoomButtonClickHandler}
                                    room={this.state.activeRoom}
                                />
                            </React.StrictMode>
                        }/>
                        
                    </Routes>
                }/>
            </Routes>
        )
    }
}

export default App;
