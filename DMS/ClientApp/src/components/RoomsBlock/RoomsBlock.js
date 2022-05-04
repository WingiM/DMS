import React from "react";
import template from "./RoomsBlock.jsx";

class RoomsBlock extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            floors: [],
            rooms: []
        }
    }
    
    componentDidMount() {
        this.fetchFloors()
            .then((data) => this.setState({floors: data}))
    }

    render() {
        return template.call(this);
    }

    tabClick(e) {
        try {
            e.preventDefault();
            try {
                document.querySelector('.active').classList.remove('active');
            }
            catch (TypeError) {
            }
            document.getElementById(e.currentTarget.id).classList.add('active');
        }
        catch (TypeError) {
        }
        
        this.fetchRooms(e.currentTarget.id)
            .then((data) => this.setState({rooms: data}))
    }
    
     async fetchFloors() {
        const requestUrl = "api/rooms/floors";
        const response = await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization" : localStorage.getItem("token")
            }
        });
        const data = await response.json()
        return data.value;
    }
    
    async fetchRooms(floor) {
        const requestUrl = "api/rooms/floors/" + floor
        const response = await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization" : localStorage.getItem("token")
            }
        });
        const data = await response.json()
        return data.value;
    }
}

export default RoomsBlock;
