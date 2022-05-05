import React from 'react';
import './custom.css'
import Sidebar from "./components/Sidebar";
import RoomsBlock from "./components/RoomsBlock"
import InRoomResidents from "./components/InRoomResidents";
import {Route, Routes, Navigate} from "react-router-dom";
import Login from "./components/Login";
import Settings from "./components/Settings";
import Residents from "./components/Residents";

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
        this.setState({showResidents: true})
        this.setState({showRooms: false})
    }
    
    showRoomsButtonClickHandler() {
        this.setState({showResidents: false})
        this.setState({showRooms: true})
    }

    openRoomButtonClickHandler(room) {
        this.setState({showInRoomResidents: true})
        this.fetchRoom(room)
            .then((data) => this.setState({activeRoom: data}))
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

        if (response.status !== 200) {
            return <Navigate to="/login"/>
        }
        
        const data = await response.json()
        return data.value
    }
    
    checkTokenLifeTime() {
        const data = fetch("/api/rooms/floors", {
            method: "GET",
            headers: {
                "Authorization": localStorage.getItem("token")
            }
        });
        
        if (data.status !== 200) {
            return <Navigate to="/login"/>
        }
    }



    render() {
        this.checkTokenLifeTime()
        console.log(localStorage.getItem("token"))
        return (
            <Routes>
                <Route path="/login" element={<Login/>}/>
                <Route path="/" element={
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
                                    openRoom ={this.openRoomButtonClickHandler}
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
                <Route path="/settings" element={<Settings/>}/>
                <Route path="/residents" element={<Residents/>}/>

                <Route path="*" element={<Navigate to="/"/>}/>
            </Routes>
        )
    }
}

export default App;
