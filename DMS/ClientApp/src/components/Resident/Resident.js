import React from "react";
import template from "./Resident.jsx";

class Resident extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            submitFail: false,
            ResidentId: this.props.id,
            LastName: this.props.lastname,
            FirstName: this.props.firstName,
            Patronymic: this.props.patronymic,
            Gender: this.props.gender,
            BirthDate: this.props.birthDate.slice(0, 10),
            SeriesAndNumber: this.props.passportInformation,
            Tin: this.props.tin,
            Rating: this.props.rating,
            Debt: this.props.debt,
            Reports: this.props.reports,
            PassportInformation: {SeriesAndNumber: this.props.passportInformation},
            RoomId: this.props.roomId,
        }

        this.handleSubmit = this.handleSubmit.bind(this)
        this.handleChange = this.handleChange.bind(this)
    }

    render() {
        return template.call(this);
    }

    openCollapsible(e) {
        let elem = e.currentTarget
        elem.classList.toggle("active");
        let content = elem.nextElementSibling;
        if (content.style.maxHeight) {
            content.style.maxHeight = null;
        } else {
            content.style.maxHeight = content.scrollHeight + "px";
        }
    }
    
    //handlers

    handleChange(event) {
        this.setState({[event.target.name]: event.target.value})
    }

    async handleSubmit(event) {
        event.preventDefault()
        
        const data = {
            LastName: this.state.LastName,
            FirstName: this.state.FirstName,
            Patronymic: this.state.Patronymic,
            Gender: this.state.Gender,
            BirthDate: this.state.BirthDate + "T00:00:00Z",
            PassportInformation: {SeriesAndNumber: this.state.SeriesAndNumber},
            Tin: this.state.Tin,
            RoomId: this.state.RoomId,
        }
        const requestUrl =  this.state.id === null ? "api/residents/" : "api/residents/" + this.state.ResidentId
        const response = await fetch(requestUrl, {
            method: this.state.ResidentId === null ? "POST" : "PUT",
            headers: {
                "Authorization": localStorage.getItem("token"),
                "Content-Type": 'application/json'
            },
            body: JSON.stringify(data)
        })
        
        //update residents list of current stream
        this.props.updateResidentsList(this.state, this.state.ResidentId !== null)
        
        const json = await response.json();
        console.log(json)
    }
}

export default Resident;
