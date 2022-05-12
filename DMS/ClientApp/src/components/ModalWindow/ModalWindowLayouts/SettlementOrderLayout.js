import React from "react";
import dotsImg from "../../Resident/img/resident3Dots.svg";
import "./Layouts.css"
import template from "../ModalWindow";

class SettlementOrderLayout extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            id: this.props.resident.id,
            fullName: this.props.resident["LastName"] + " " + this.props.resident["FirstName"] + " " + this.props.resident["Patronymic"],
            passportNumber: this.props.resident["PassportInformation"]["SeriesAndNumber"],
            issuedBy: "",
            address: "",
            parentFullName: "",
            parentPassportNumber: "",
            parentPassportIssuedBy: "",
            parentAddress: "",
        }

        this.handleChange = this.handleChange.bind(this)
    }

    handleChange(event) {
        this.setState({[event.target.name]: event.target.value})
    }

    render() {
        console.log(this.props.resident)
        return (
            <div className={"settlement-order-body"}>
                <div className="rooms-header in-modal" style={{marginBottom: "5%"}}>ПРИКАЗ О ЗАСЕЛЕНИИ</div>
                <div className="rooms-header mini">реквизиты нанимателя</div>
                
                <div className="settlement-content">
                    <div className="rooms-header mini type">студент</div>
                    <form onSubmit={this.handleSubmit}>
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
                    <form onSubmit={this.handleSubmit}>
                        <div className="resident-content-row">
                            <label>ФИО:</label> <input autoFocus={this.state.id === null} name={"parentFullName"}
                                                       onChange={this.handleChange} readOnly={false}
                                                       value={this.state.parentFullName} type="text"/> <br/>
                        </div>
                        <div className="resident-content-row">
                            <label>Серия номер:</label> <input name={"parentPassportNumber"} onChange={this.handleChange}
                                                               readOnly={false} value={this.state.parentPassportNumber}
                                                               type="text"/> <br/>
                        </div>
                        <div className="resident-content-row">
                            <label>Выдан:</label> <input name={"parentPassportIssuedBy"} onChange={this.handleChange} readOnly={false}
                                                         value={this.state.parentPassportIssuedBy} type="text"/> <br/>
                        </div>
                        <div className="resident-content-row">
                            <label>Адрес:</label> <input name={"parentAddress"} onChange={this.handleChange} readOnly={false}
                                                         value={this.state.parentAddress} type="text"/> <br/>
                        </div>
                        <div className={"resident-content-row"}>
                            <input className={"save-btn"} type={"submit"} value={"Сохранить"}/>
                        </div>
                    </form>
                    
                </div>
                
            </div>
        )
    }
}

export default SettlementOrderLayout;