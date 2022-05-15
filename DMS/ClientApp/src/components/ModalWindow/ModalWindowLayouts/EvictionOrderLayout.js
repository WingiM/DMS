import React from "react";
import "./Layouts.css"

class EvictionOrderLayout extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            id: this.props.resident.id,
            fullName: this.props.resident["LastName"] + " " + this.props.resident["FirstName"] + " " + this.props.resident["Patronymic"],
            evictionReason: "",
            evictionDate: "",
        }
        this.handleChange = this.handleChange.bind(this)
    }

    handleChange(event) {
        this.setState({[event.target.name]: event.target.value})
    }
    
    async submitEviction(e) {
        e.preventDefault()
        await fetch("api/documents/", {
            method: "POST",
            headers: {
                "Authorization": localStorage.getItem("token"),
                "type": "SettlementOrder",
                "Content-Type": 'application/json',
            },
            body: JSON.stringify({
                "RoomId": parseInt(this.props.roomId),
                "ResidentId": parseInt(this.state.id),
                "OrderDate": new Date(Date.now()).toISOString().slice(0, 10) + "T00:00:00Z",
                "ParentsFullName": this.state.parentFullName,
                "ParentsPassportSeriesNumber": this.state.parentPassportNumber,
                "ParentsPassportIssuedBy": this.state.parentPassportIssuedBy,
                "ParentsPassportAddress": this.state.parentAddress
            })
        })
            .then((response) => response.json())
            .then((data) => {
                console.log(data)})
        //this.props.updateRoom(this.props.resident)
    }

    render() {
        return (
            <div>
                <div className="rooms-header in-modal">ПРИКАЗ О ВЫСЕЛЕНИИ</div>
                <form>
                    <div className="resident-content-row">
                        <label>ФИО:</label> <input autoFocus={this.state.id === null} name={"fullName"}
                                                   onChange={this.handleChange} readOnly={true}
                                                   value={this.state.fullName} type="text"/> <br/>
                    </div>
                    <div className="resident-content-row">
                        <label>Причина выселения:</label> <input name={"ratingAddReason"} onChange={this.handleChange}
                                                                  readOnly={false} value={this.state.evictionReason}
                                                                  type="text"/> <br/>
                    </div>
                    <div className="resident-content-row">
                        <label>Дата:</label> <input name={"ratingAddDate"} onChange={this.handleChange} readOnly={false}
                                                    value={this.state.evictionDate} type="date"/> <br/>
                    </div>
                    <div className={"resident-content-row"}>
                        <input onSubmit={(e) => this.submitEviction(e)} className={"save-btn"} type={"submit"} value={"Сохранить"}/>
                    </div>
                </form>
            </div>
        )
    }
}

export default EvictionOrderLayout;   