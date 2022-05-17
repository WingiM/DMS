import React from "react";
import dotsImg from "../../Resident/img/resident3Dots.svg";
import "./Layouts.css"
import template from "../ModalWindow";

class SettlementOrderLayout extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            id: this.props.resident["ResidentId"],
            fullName: this.props.resident["LastName"] + " " + this.props.resident["FirstName"] + " " + this.props.resident["Patronymic"],
            passportNumber: this.props.resident["PassportInformation"]["SeriesAndNumber"],
            issuedBy: this.props.resident["PassportInformation"]["IssuedBy"],
            address: this.props.resident["PassportInformation"]["Address"],
            parentFullName: "",
            parentPassportNumber: "",
            parentPassportIssuedBy: "",
            parentAddress: "",
            date: new Date(Date.now()).toISOString().slice(0, 10),
        }

        this.handleChange = this.handleChange.bind(this)
    }
    
    componentDidMount() {
        if (this.props.document !== undefined) {
            this.setState({
                parentFullName: this.props.document["ParentsFullName"],
                parentPassportNumber: this.props.document["ParentsPassportSeriesNumber"],
                parentPassportIssuedBy: this.props.document["ParentsPassportIssuedBy"],
                parentAddress: this.props.document["ParentsPassportAddress"],
                date: this.props.document["OrderDate"].slice(0, 10)
            })
        }
    }

    handleChange(event) {
        this.setState({[event.target.name]: event.target.value})
    }
    
    async submitSettlement(e) {
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
                "OrderDate": this.state.date + "T00:00:00Z",
                "ParentsFullName": this.state.parentFullName,
                "ParentsPassportSeriesNumber": this.state.parentPassportNumber,
                "ParentsPassportIssuedBy": this.state.parentPassportIssuedBy,
                "ParentsPassportAddress": this.state.parentAddress
            })
        })

        this.props.updateChartStats(
            {
                settled: this.props.chartStats.settled + 1,
                total: this.props.chartStats.total,
                free: this.props.chartStats.free - 1,
                percentage: (this.props.chartStats.settled + 1) / (this.props.chartStats.total) * 100 | 0
            }
        )
        let residentToPush = this.props.resident
        residentToPush.RoomId = this.props.roomId
        this.props.updateRoom(residentToPush)
        this.props.toggleHandler()
    }

    render() {
        return (
            <div className={"settlement-order-body"}>
                <div className="rooms-header in-modal" style={{marginBottom: "5%"}}>ПРИКАЗ О ЗАСЕЛЕНИИ</div>
                <div className="rooms-header mini">реквизиты нанимателя</div>
                
                <div className="settlement-content">
                    <div className="rooms-header mini type">студент</div>
                    <form>
                        <div className="resident-content-row">
                            <label>ФИО:</label> <input autoFocus={this.state.id === null} name={"fullName"}
                                                       onChange={this.handleChange} readOnly={true}
                                                       value={this.state.fullName} type="text"/> <br/>
                        </div>
                        <div className="resident-content-row">
                            <label>Серия номер:</label> <input name={"passportNumber"} onChange={this.handleChange}
                                                               readOnly={true} value={this.state.passportNumber}
                                                               type="text"/> <br/>
                        </div>
                        <div className="resident-content-row">
                            <label>Выдан:</label> <input name={"issuedBy"} onChange={this.handleChange} readOnly={true}
                                                         value={this.state.issuedBy} type="text"/> <br/>
                        </div>
                        <div className="resident-content-row">
                            <label>Адрес:</label> <input name={"address"} onChange={this.handleChange} readOnly={true}
                                                         value={this.state.address} type="text"/> <br/>
                        </div>
                    </form>
                    <div className="rooms-header mini type">родитель, законный представитель</div>
                    <form>
                        <div className="resident-content-row">
                            <label>ФИО:</label> <input name={"parentFullName"}
                                                       onChange={this.handleChange} readOnly={this.props.readOnly}
                                                       value={this.state.parentFullName} type="text"/> <br/>
                        </div>
                        <div className="resident-content-row">
                            <label>Серия номер:</label> <input name={"parentPassportNumber"} onChange={this.handleChange}
                                                               readOnly={this.props.readOnly} value={this.state.parentPassportNumber}
                                                               type="text"/> <br/>
                        </div>
                        <div className="resident-content-row">
                            <label>Выдан:</label> <input name={"parentPassportIssuedBy"} onChange={this.handleChange} readOnly={this.props.readOnly}
                                                         value={this.state.parentPassportIssuedBy} type="text"/> <br/>
                        </div>
                        <div className="resident-content-row">
                            <label>Адрес:</label> <input name={"parentAddress"} onChange={this.handleChange} readOnly={this.props.readOnly}
                                                         value={this.state.parentAddress} type="text"/> <br/>
                        </div>

                        {
                            this.props.readOnly ? "" :
                                <div className={"resident-content-row"}>
                                    <input onClick={(e) => this.submitSettlement(e)} className={"save-btn"} type={"submit"} value={"Сохранить"}/>
                                </div>
                        }
                        
                    </form>
                    
                </div>
                
            </div>
        )
    }
}

export default SettlementOrderLayout;