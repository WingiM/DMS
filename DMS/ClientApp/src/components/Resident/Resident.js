import React from "react";
import template from "./Resident.jsx";

class Resident extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            submitFail: false,
            lastname: this.props.lastname,
            firstName: this.props.firstName,
            patronymic: this.props.patronymic,
            gender: this.props.gender,
            birthDate: this.props.birthDate,
            passportInformation: this.props.passportInformation,
            tin: this.props.tin,
            rating: this.props.rating,
            debt: this.props.debt,
            reports: this.props.reports
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
            LastName: this.state.lastname,
            FirstName: this.state.firstName,
            Patronymic: this.state.patronymic,
            Gender: this.state.gender,
            BirthDate: this.state.birthDate,
            PassportInformation: this.state.passportInformation,
            Tin: this.state.tin
        }
        const requestUrl = "api/residents/" + this.props.id
        const response = await fetch(requestUrl, {
            method: "PUT",
            headers: {
                "Authorization": localStorage.getItem("token"),
                "Content-Type": 'application/json'
            },
            body: JSON.stringify(data)
        })
        const json = await response.json();
        console.log(json)
    }
}

export default Resident;
