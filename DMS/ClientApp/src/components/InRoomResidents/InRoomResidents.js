import React from "react";
import template from "./InRoomResidents.jsx";

class InRoomResidents extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            showModal: false,
            show: true,
            residents: [],
        }
        
        this.toggleModal = this.toggleModal.bind(this)
    }
    
    //handlers
    
    async toggleModal() {
        const data = await this.fetchResidents()
        this.setState({
            showModal: !this.state.showModal,
            residents: data
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
