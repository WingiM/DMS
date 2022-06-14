import React from "react";

class DeleteResidentConfirmLayout extends React.Component {
    constructor(props) {
        super(props);
        console.log(props)
        
        this.deleteResidentHandler = this.deleteResidentHandler.bind(this)
    }

    async deleteResidentHandler() {
        const url = "api/residents/" + this.props.resident["ResidentId"]
        await fetch(url, {
            method: "Delete",
            headers: {
                "Authorization": localStorage.getItem("token")
            }
        })
            .then((response) => response.json())
            .then((val) => {
                console.log(val)
                if (val["StatusCode"] === 200) {
                    this.props.updateResidentsList(this.props.resident, false, true)
                    this.props.toggleHandler()
                    
                    if (this.props.resident["RoomId"] !== null) {
                        this.props.updateChartStats(
                            {
                                settled: this.props.chartStats.settled - 1,
                                total: this.props.chartStats.total,
                                free: this.props.chartStats.free + 1,
                                percentage: (this.props.chartStats.settled - 1) / (this.props.chartStats.total) * 100 | 0
                            }
                        )
                    }
                }
            })
    }

    render() {
        return (
            <div>
                <div className="rooms-header in-modal">ПРЕДУПРЕЖДЕНИЕ!</div>
                <div className="settings-save-content" style={{marginTop: "5%"}}>
                    <span className={"info"}>
                        При применении, проживающий, а также связанные
                        с ним документы <strong>будут удалены</strong> из системы.<br/>
                        Отменить это действие невозможно.
                    </span>
                    <div className="buttons-container" style={{marginTop: "20%"}}>
                        <button onClick={this.props.toggleHandler} className="settings-btn cancel">Отмена</button>
                        <button
                            onClick={this.deleteResidentHandler}
                            className={"settings-btn active"}>Применить
                        </button>
                    </div>
                </div>
            </div>
        )
    }
}

export default DeleteResidentConfirmLayout;   