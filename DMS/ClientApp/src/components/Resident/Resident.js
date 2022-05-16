import React from "react";
import template from "./Resident.jsx";
import $ from 'jquery'

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

            PassportInformation: this.props.passportInformation,
            // SeriesAndNumber: this.props.passportInformation["SeriesAndNumber"],
            IssuedBy: this.props.passportInformation["IssuedBy"],
            IssueDate: this.props.passportInformation["IssueDate"],
            DepartmentCode: this.props.passportInformation["DepartmentCode"],
            Address: this.props.passportInformation["Address"],

            Tin: this.props.tin,
            Rating: this.props.rating,
            Debt: this.props.debt,
            Reports: this.props.reports,
            RoomId: this.props.roomId,
            Course: this.props.course,

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
            content.style.maxHeight = content.scrollHeight + 150 + "px";
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
            PassportInformation: {
                SeriesAndNumber: this.state.SeriesAndNumber,
                IssueBy: this.state.IssuedBy,
                IssuedDate: this.state.IssuedDate,
                DepartmentCode: parseInt(this.state.DepartmentCode),
                Address: this.state.Address,
            },
            Tin: this.state.Tin,
            RoomId: this.state.RoomId,
            Course: parseInt(this.state.Course),
        }
        const requestUrl = this.state.id === null ? "api/residents/" : "api/residents/" + this.state.ResidentId
        const response = await fetch(requestUrl, {
            method: this.state.ResidentId === null ? "POST" : "PUT",
            headers: {
                "Authorization": localStorage.getItem("token"),
                "Content-Type": 'application/json'
            },
            body: JSON.stringify(data)
        })
        .then((val) => {
            let thisSubmitText = event.target.parentNode.querySelector(".submit-text")
            if (val["StatusCode"] !== 200) {
                thisSubmitText.innerHTML = "Ошибка"
                thisSubmitText.style.color = "#FF8787";

            } else {
                thisSubmitText.innerHTML = "Успешно"
                thisSubmitText.style.color = "#3A7890";
            }
            thisSubmitText.classList.add("active")
            setTimeout(() => {
                thisSubmitText.classList.remove("active")
            }, 7000);
        })

        //update residents list of current stream
        this.props.updateResidentsList(this.state, this.state.ResidentId !== null)

        const json = await response.json();
        console.log(json)
    }
}

export default Resident;
