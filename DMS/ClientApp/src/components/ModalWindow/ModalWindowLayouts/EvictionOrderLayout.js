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

    render() {
        return (
            <div>
                <div className="rooms-header in-modal">ПРИКАЗ О ВЫСЕЛЕНИИ</div>
                <form onSubmit={this.handleSubmit}>
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
                        <input className={"save-btn"} type={"submit"} value={"Сохранить"}/>
                    </div>
                </form>
            </div>
        )
    }
}

export default EvictionOrderLayout;   