import React from "react";
import template from "./Settings.jsx";

class Setting extends React.Component {
    constructor(props) {
        super(props);
        this.toggleModal = this.toggleModal.bind(this)
        
        this.state = {
            showModal: false,
            layout: null,
            layoutName: "",
            Floors: 0,
            RoomsCount: 0,
            RoomCapacity: 0,
            CommercialCost: 0,
            NonCommercialCost: 0,
        }
        
        this.handleChange = this.handleChange.bind(this)
        this.applyStats = this.applyStats.bind(this)
    }
    
    async componentDidMount() {
        await this.fetchStats()
    }

    toggleModal(layout, layoutName) {
        this.setState({
            showModal: !this.state.showModal,
            layout: layout,
            layoutName: layoutName
        })
    }

    handleChange(event) {
        this.setState({[event.target.name]: event.target.value})
    }
    
    async fetchStats() {
        const requestUrl = "api/stats/constants"
        await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization" : localStorage.getItem("token")
            }
        })
            .then((response) => response.json())
            .then((data) => data.Value)
            .then((val) => 
            {
                this.setState(
                    {
                        Floors: val["Floors"],
                        RoomsCount: val["RoomsCount"],
                        RoomCapacity: val["RoomCapacity"],
                        CommercialCost: val["CommercialCost"],
                        NonCommercialCost: val["NonCommercialCost"],
                    })
            })
    }
    
    async applyStats() {
        const requestUrl = "api/stats/constants"
        await fetch(requestUrl, {
            method: "POST",
            headers: {
                "Authorization": localStorage.getItem("token"),
                "Content-Type": 'application/json'
            },
            body: JSON.stringify({
                Floors: this.state.Floors,
                RoomsCount: this.state.RoomsCount,
                RoomCapacity: this.state.RoomCapacity,
                CommercialCost: this.state.CommercialCost,
                NonCommercialCost: this.state.NonCommercialCost,
            })
        })
            .then((response) => response.json())
            .then((val) => {
                console.log(val)
            })
    }
  
    render() {
        return template.call(this);
    }
}

export default Setting;
