import React from "react";
import "./Layouts.css"

class RatingOperationsLayout extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            id: this.props.resident["ResidentId"],
            fullName: this.props.resident["LastName"] + " " + this.props.resident["FirstName"] + " " + this.props.resident["Patronymic"],
            ratingAddReason: this.props.document === undefined ? "" : this.props.document["Description"],
            ratingAddDate: this.props.document === undefined ? new Date(Date.now()).toISOString().slice(0, 10) :  this.props.document["OrderDate"].slice(0, 10),
            changeValue: this.props.document === undefined ? null : this.props.document["ChangeValue"],
            type: this.props.document === undefined ? null : this.props.document["CategoryId"]
        }
        this.handleChange = this.handleChange.bind(this)
    }

    async submitRating(e) {
        e.preventDefault()
        console.log(this.state.type)
        await fetch("api/documents/", {
            method: "POST",
            headers: {
                "Authorization": localStorage.getItem("token"),
                "type": "RatingOperation",
                "Content-Type": 'application/json',
            },
            body: JSON.stringify({
                "ResidentId": parseInt(this.state.id),
                "OrderDate": this.state.ratingAddDate + "T00:00:00Z",
                "ChangeValue": parseInt(this.state.changeValue),
                "Description": this.state.ratingAddReason,
                "CategoryId": this.state.type === "Докладная" ? 1 : this.state.type === "Поощрение" ? 2 : 3
            })
        })
            .then((response) => response.json())
            .then((val) => {
                console.log(val)
            })
        let residentToPush = this.props.resident
        residentToPush.Rating = parseInt(residentToPush.Rating) + parseInt(this.state.changeValue)
        residentToPush.Reports = this.state.type === "Докладная" ? parseInt(residentToPush.Reports) + 1 : residentToPush.Reports
        this.props.updateRoom(residentToPush, true, false, "ratingChange")
        this.props.toggleHandler()
    }

    handleChange(event) {
        this.setState({[event.target.name]: event.target.value})
    }

    render() {
        return (
            <div>
                <div className="rooms-header in-modal">ЗАЧИСЛЕНИЕ РЕЙТИНГА</div>
                <form onSubmit={this.handleSubmit}>
                    <div className="resident-content-row">
                        <label>ФИО:</label> <input autoFocus={this.state.id === null} name={"fullName"}
                                                   onChange={this.handleChange} readOnly={true}
                                                   value={this.state.fullName} type="text"/> <br/>
                    </div>
                    
                    <div className="resident-content-row" style={{marginRight: "1%", width: "110%"}}>
                        <label style={{marginRight: "1%"}}>Категория:</label>
                        <input id={"report" + this.state.id} type="radio" defaultChecked={this.state.type === 1} disabled={this.props.readOnly} onChange={this.handleChange}  name="type" value={"Докладная"}/>
                        <label className="radio-label" htmlFor={"report" + this.state.id}>Докладная</label>
                        <input id={"rebuke" + this.state.id} type="radio" defaultChecked={this.state.type === 3} disabled={this.props.readOnly} onChange={this.handleChange}  name="type" value={"Выговор"}/>
                        <label className="radio-label" htmlFor={"rebuke" + this.state.id}>Выговор</label>
                        <input id={"promotion" + this.state.id} type="radio" defaultChecked={this.state.type === 2} disabled={this.props.readOnly} onChange={this.handleChange}  name="type" value={"Поощрение"}/>
                        <label className="radio-label" htmlFor={"promotion" + this.state.id}>Поощрение</label> <br/>
                    </div>
                    
                    <div className="resident-content-row">
                        <label>Значение:</label> <input value={this.state.changeValue} readOnly={this.props.readOnly} name={"changeValue"} onChange={this.handleChange}
                                                                  type="number"/> <br/>
                    </div>
                    <div className="resident-content-row">
                        <label>Причина зачисления:</label> <input value={this.state.ratingAddReason} readOnly={this.props.readOnly} name={"ratingAddReason"} onChange={this.handleChange}
                                                           type="text"/> <br/>
                    </div>
                    <div className="resident-content-row">
                        <label>Дата:</label> <input name={"ratingAddDate"} value={this.state.ratingAddDate} onChange={this.handleChange} readOnly={this.props.readOnly} type="date"/> <br/>
                    </div>

                    {
                        this.props.readOnly ? "" :
                            <div className={"resident-content-row"}>
                                <input onClick={(e) => this.submitRating(e)} className={"save-btn"} type={"submit"} value={"Добавить"}/>
                            </div>
                    }
                    
                </form>
            </div>
        )
    }
}

export default RatingOperationsLayout;   