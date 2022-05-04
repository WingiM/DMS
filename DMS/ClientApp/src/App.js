import React from 'react';
import './custom.css'
import Sidebar from "./components/Sidebar";
import RoomsBlock from "./components/RoomsBlock"
import InRoomResidents from "./components/InRoomResidents";
import {Navigate, Route, Routes} from "react-router-dom";
import Login from "./components/Login";

class App extends React.Component {
    static displayName = App.name;

    constructor(props) {
        super(props);

        this.state = {
            showRooms: false,
            showInRoomResidents: false,
            activeRoom: [],
        }

        this.showRoomsButtonClickHandler = this.showRoomsButtonClickHandler.bind(this);
        this.openRoomButtonClickHandler = this.openRoomButtonClickHandler.bind(this);
        this.closeRoomButtonClickHandler = this.closeRoomButtonClickHandler.bind(this);
    }
    
    //handlers

    showRoomsButtonClickHandler() {
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
        
        const data = await response.json()
        return data.value
    }

    render() {
        
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
                                />
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
                <Route path="*" element={<Navigate to="/"/>}/>
            </Routes>
        )
    }
}

export default App;
