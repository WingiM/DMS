import React from "react";
import "./Layouts.css"

class EvictionOrderLayout extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            id: this.props.resident["ResidentId"],
            fullName: this.props.resident["LastName"] + " " + this.props.resident["FirstName"] + " " + this.props.resident["Patronymic"],
            transactionSum: this.props.document === undefined ? '' : this.props.document["Sum"],
            transactionDate: this.props.document === undefined ? new Date(Date.now()).toISOString().slice(0, 10) : this.props.document["OperationDate"].slice(0, 10)
        }
        this.handleChange = this.handleChange.bind(this)
    }

    handleChange(event) {
        this.setState({[event.target.name]: event.target.value})
    }
    
    async submitTransaction(e) {
        e.preventDefault()
        await fetch("api/documents/", {
            method: "POST",
            headers: {
                "Authorization": localStorage.getItem("token"),
                "type": "Transaction",
                "Content-Type": 'application/json',
            },
            body: JSON.stringify({
                "ResidentId": parseInt(this.state.id),
                "OperationDate": this.state.transactionDate + "T00:00:00Z",
                "Sum": parseInt(this.state.transactionSum)
            })
        })
            .then((response) => response.json())
            .then((data) => {
                console.log(data)})

        let residentToPush = this.props.resident
        residentToPush.Debt = parseInt(residentToPush.Debt) + parseInt(this.state.transactionSum)
        this.props.updateRoom(residentToPush, true, false, "transactionChange")
        this.props.toggleHandler()
    }

    render() {
        return (
            <div>
                <div className="rooms-header in-modal">Транзакции</div>
                <form onSubmit={this.handleSubmit}>
                    <div className="resident-content-row">
                        <label>ФИО:</label> <input name={"fullName"}
                                                   readOnly={true}
                                                   value={this.state.fullName} type="text"/> <br/>
                    </div>

                    <div className="resident-content-row">
                        <label>Сумма:</label> <input name={"transactionSum"} onChange={this.handleChange} readOnly={this.props.readOnly}
                                                     value={this.state.transactionSum} type="number"/> <br/>
                    </div>
                    <div className="resident-content-row">
                        <label>Дата:</label>
                        <input name={"transactionDate"} onChange={this.handleChange}
                               readOnly={this.props.readOnly} value={this.state.transactionDate}
                               type="date"/><br/>
                    </div>
                    
                    {
                        this.props.readOnly ? "" :
                            <div className={"resident-content-row"}>
                                <input onClick={(e) => this.submitTransaction(e)} className={"save-btn"} type={"submit"} value={"Сохранить"}/>
                            </div>
                    }
                    
                </form>
            </div>
        )
    }
}

export default EvictionOrderLayout;   