import React from "react";
import template from "./InRoomResidents.jsx";
import ResidentsListLayout from "../ModalWindow/ModalWindowLayouts/ResidentsListLayout";

class InRoomResidents extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            showModal: false,
            modalResidentsList: [],
            modalResidentsFilterList: [],
            modalLayout: null,
            roomGender: null,
        }
        
        this.toggleHandler = this.toggleHandler.bind(this)
        this.toggleResidentsListModal = this.toggleResidentsListModal.bind(this)
        this.toggleEvictionModal = this.toggleEvictionModal.bind(this)
        this.toggleTransactionModal = this.toggleTransactionModal.bind(this)
        this.toggleRatingModal = this.toggleRatingModal.bind(this)
        this.filterHandler = this.filterHandler.bind(this)
        this.handleChange = this.handleChange.bind(this)
    }
    
    //handlers
    
    componentWillUnmount() {
        this.setState({
            roomGender: null,
        })
    }

    toggleHandler() {
        this.setState({
            showModal: !this.state.showModal
        })
    }

    async handleChange(event) {
        this.setState({[event.target.name]: event.target.value})
        if (event.target.name == "roomGender") {
           await this.postRoomGender()
        }
    }
    
    async toggleResidentsListModal() {
        const gender = this.state.roomGender !== null ? this.state.roomGender : this.props.room["Gender"] == "F" ? "Ж" : "М"
        let data = await this.fetchResidents()
        data = data.filter((i) => i["Gender"] === gender && i["RoomId"] === null)
        this.setState({
            showModal: !this.state.showModal,
            modalResidentsList: data,
            modalResidentsFilterList: data,
            modalLayout: "residentsList",
        })
    }
    
    toggleEvictionModal(resident) {
        this.setState({
            showModal: !this.state.showModal,
            chosenResident: resident,
            modalLayout: "evictionOrder",
        })
    }

    toggleTransactionModal(resident) {
        this.setState({
            showModal: !this.state.showModal,
            chosenResident: resident,
            modalLayout: "transactionOrder",
        })
    }
    
    toggleRatingModal(resident) {
        this.setState({
            showModal: !this.state.showModal,
            chosenResident: resident,
            modalLayout: "ratingModal",
        })
    }
    
    filterHandler(val) {
        this.setState({
            modalResidentsFilterList: val
        })
    }
    
    // fetch functions
    
    async fetchResidents() {
        const requestUrl = "api/stats/resettlement"
        const response = await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization" : localStorage.getItem("token")
            }
        })
        
        const data = await response.json();
        return data.Value;
    }

    render() {
        return template.call(this);
    }
    
    async postRoomGender() {
        const data = 
            {
                RoomId: parseInt(this.props.room["RoomId"]),
                Gender: this.state.roomGender == "Ж" ? 'F': 'M'
            }
        
        await fetch("api/rooms/gender", {
            method: "POST",
            headers: {
                "Authorization": localStorage.getItem("token"),
                "Content-Type": 'application/json'
            },
            body: JSON.stringify(data)
        })
    }

}

export default InRoomResidents;
