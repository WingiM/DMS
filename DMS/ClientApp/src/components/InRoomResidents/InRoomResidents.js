import React from "react";
import template from "./InRoomResidents.jsx";

class InRoomResidents extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            showModal: false,
            showSettlementModal: false,
            chosenResident: null,
            show: true,
            modalResidentsList: [],
            modalResidentsFilterList: [],
        }
        
        this.toggleModal = this.toggleModal.bind(this)
        this.filterHandler = this.filterHandler.bind(this)
    }
    
    //handlers
    
    async toggleModal(resident) {
        const gender = this.props.room["Gender"] === "F" ? "Ж" : "М"
        
        let data = await this.fetchResidents()
        data = data.filter((i) => i["Gender"] === gender)
        this.setState({
            showModal: !this.state.showModal,
            modalResidentsList: data,
            modalResidentsFilterList: data,
            chosenResident: resident
        })
    }
    
    filterHandler(val) {
        this.setState({
            modalResidentsFilterList: val
        })
    }
    
    // fetch functions
    
    async fetchResidents() {
        const requestUrl = "api/residents"
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

}

export default InRoomResidents;
