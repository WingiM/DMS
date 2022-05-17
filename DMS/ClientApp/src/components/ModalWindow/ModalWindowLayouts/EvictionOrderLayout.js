import React from "react";
import "./Layouts.css"

class EvictionOrderLayout extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            id: this.props.resident["ResidentId"],
            fullName: this.props.resident["LastName"] + " " + this.props.resident["FirstName"] + " " + this.props.resident["Patronymic"],
            evictionReason: this.props.document === undefined ? '' : this.props.document["Description"],
            evictionDate: this.props.document === undefined ? new Date(Date.now()).toISOString().slice(0, 10) : this.props.document["OrderDate"].slice(0, 10),
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
                "type": "EvictionOrder",
                "Content-Type": 'application/json',
            },
            body: JSON.stringify({
                "ResidentId": parseInt(this.state.id),
                "OrderDate": this.state.evictionDate + "T00:00:00Z",
                "Description": this.state.evictionReason
            })
        })
            .then((response) => response.json())
            .then((data) => {
                console.log(data)})
        
        this.props.updateChartStats(
            {
                settled: this.props.chartStats.settled - 1,
                total: this.props.chartStats.total,
                free: this.props.chartStats.free + 1,
                percentage: (this.props.chartStats.settled - 1) / (this.props.chartStats.total) * 100 | 0
            }
        )
        this.props.updateRoom(this.props.resident, false, true)
        this.props.toggleHandler()
    }

    render() {
        return (
            <div>
                <div className="rooms-header in-modal">ПРИКАЗ О ВЫСЕЛЕНИИ</div>
                <form>
                    <div className="resident-content-row">
                        <label>ФИО:</label> <input name={"fullName"}
                                                   value={this.state.fullName} readOnly={true} type="text"/> <br/>
                    </div>
                    <div className="resident-content-row">
                        <label>Причина выселения:</label> <input name={"evictionReason"} onChange={this.handleChange}
                                                                  readOnly={this.props.readOnly} value={this.state.evictionReason}
                                                                  type="text"/> <br/>
                    </div>
                    <div className="resident-content-row">
                        <label>Дата:</label> <input name={"evictionDate"} onChange={this.handleChange} readOnly={this.props.readOnly}
                                                    value={this.state.evictionDate} type="date"/> <br/>
                    </div>
                    {
                        this.props.readOnly ? "" :
                            <div className={"resident-content-row"}>
                                <input onClick={(e) => this.submitEviction(e)} className={"save-btn"} type={"submit"} value={"Сохранить"}/>
                            </div>
                    }
                    
                </form>
            </div>
        )
    }
}

export default EvictionOrderLayout;   