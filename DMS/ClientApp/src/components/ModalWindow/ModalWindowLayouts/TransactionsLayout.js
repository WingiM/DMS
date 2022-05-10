import React from "react";
import "./Layouts.css"

class EvictionOrderLayout extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            id: this.props.resident.id,
            fullName: this.props.resident["LastName"] + " " + this.props.resident["FirstName"] + " " + this.props.resident["Patronymic"],
            transactionSum: "",
            transactionDate: "",
        }
    }

    render() {
        return (
            <div>
                <div className="rooms-header in-modal">ПРИКАЗ О ВЫСЕЛЕНИИ</div>
                <form onSubmit={this.handleSubmit}>
                    <div className="resident-content-row">
                        <label>ФИО:</label> <input autoFocus={this.state.id === null} name={"fullName"}
                                                   onChange={this.handleChange} readOnly={false}
                                                   value={this.state.fullName} type="text"/> <br/>
                    </div>

                    <div className="resident-content-row">
                        <label>Сумма:</label> <input name={"transactionSum"} onChange={this.handleChange} readOnly={true}
                                                     value={this.state.transactionSum} type="number"/> <br/>
                    </div>
                    <div className="resident-content-row">
                        <label style={{marginRight: "19%"}}>Вид:</label>
                        <input id={"replenishment" + this.state.id} type="radio" onChange={this.handleChange}  name="type" value={"пополнение"}/>
                        <label className="radio-label" htmlFor={"replenishment" + this.state.id}>пополнение</label>
                        <input id={"write-off" + this.state.id} type="radio" onChange={this.handleChange}  name="type" value={"списание"}/>
                        <label className="radio-label" htmlFor={"write-off" + this.state.id}>списание</label> <br/>
                    </div>
                    <div className="resident-content-row">
                        <label>Дата:</label>
                        <input name={"transactionDate"} onChange={this.handleChange}
                               readOnly={false} value={this.state.transactionDate}
                               type="date"/><br/>
                    </div>
                    <div className={"resident-content-row"}>
                        <input className={"save-btn"} type={"submit"} value={"Сохранить"}/>
                    </div>
                </form>
            </div>
        )
    }
}

export default EvictionOrderLayout;   