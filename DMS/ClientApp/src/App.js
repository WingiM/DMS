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
            allResidentsList: [],
            allResidentsFilterList: [],
        }
        
        //binds
        this.showRoomsButtonClickHandler = this.showRoomsButtonClickHandler.bind(this);
        this.openRoomButtonClickHandler = this.openRoomButtonClickHandler.bind(this);
        this.closeRoomButtonClickHandler = this.closeRoomButtonClickHandler.bind(this);
        this.showResidentsBlockButtonClickHandler = this.showResidentsBlockButtonClickHandler.bind(this);
        this.addNewResidentHandler = this.addNewResidentHandler.bind(this);
        this.filterResidentsHandler = this.filterResidentsHandler.bind(this);
        this.updateAllResidentsList = this.updateAllResidentsList.bind(this);
    }
    
    /* Handlers */

    //open all resident of dormitory list
    async showResidentsBlockButtonClickHandler() {
        const data = await this.fetchAllResidentsList()
        this.setState({
            showRooms: false,
            showInRoomResidents: false,
            showResidents: true,
            allResidentsList: data,
            allResidentsFilterList: data
        })
    }
    
    
    //open all dormitory rooms'n'floors block
    showRoomsButtonClickHandler() {
        this.setState({
            showResidents: false,
            showRooms: true})
    }

    //open and fetch data for specified room
    async openRoomButtonClickHandler(room) {
        this.setState({showInRoomResidents: false})
        const data = await this.fetchRoom(room)
        this.setState({activeRoom: data})
        this.setState({showInRoomResidents: true})
    }

    closeRoomButtonClickHandler() {
        this.setState({showInRoomResidents : false})
    }
    
    addNewResidentHandler() {
        this.state.allResidentsList.push({
                ResidentId: null,
                LastName: '',
                FirstName: '',
                Patronymic: '',
                Gender: 'М',
                BirthDate: '',
                PassportInformation: {SeriesAndNumber: null},
                Tin: null,
                Rating: null,
                Debt: null,
                Reports: null,
            })
        this.setState({
            allResidentsList: this.state.allResidentsList,
            allResidentFilterList: this.state.allResidentsList,
        })
    }
    
    // residents list filtration
    async filterResidentsHandler(list) {
        this.setState({
            allResidentsFilterList: list,
        })
    }
    
    async updateAllResidentsList(elem, update=false) {
        if (update) {
            this.state.allResidentsList[
                this.state.allResidentsList.indexOf(
                    this.state.allResidentsList.find(
                        i => i.ResidentId === elem.ResidentId))] = elem
        }
        else {
            this.state.allResidentsList.push(elem)
        }
    }
    
    /* Fetch Functions */
    
    //get all residents in dormitory
    async fetchAllResidentsList() {
        const requestUrl = "api/residents"
        const response = await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization" : localStorage.getItem("token")
            }
        })
        const data = await response.json()
        return data.Value
    }
    
    //get room with specified ID
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

    getTokenExpDate() {
        let token = localStorage.getItem("token").split(" ")[1];
        let base64Url = token.split('.')[1];
        let base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
        let jsonPayload = decodeURIComponent(atob(base64).split('').map(function (c) {
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
                                />
                                <Residents 
                                    show={this.state.showResidents}
                                    residentsList={this.state.allResidentsList}
                                    residentsFilterList={this.state.allResidentsFilterList}
                                    addResidentBtnClickHandler={this.addNewResidentHandler}
                                    filterHandler={this.filterResidentsHandler}
                                    updateResidentsList={this.updateAllResidentsList}
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
            </Routes>
        )
    }
}

export default App;
