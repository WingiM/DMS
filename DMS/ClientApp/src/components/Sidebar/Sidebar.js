import React    from "react";
import template from "./Sidebar.jsx";

class Sidebar extends React.Component {
    constructor(props) {
        super(props);
        
        this.state = {
            settled: 0,
            free: 0,
            total: 0,
            percentage: 0,
        }
    }
    
    async componentDidMount() {
        const data = await this.fetchStats()
        this.setState({
            settled: data["Settled"],
            total: data["Total"],
            free: data["Total"] - data["Settled"],
            percentage: data["Settled"] / data["Total"] * 100 | 0
        })
    }

    async fetchStats() {
        const requestUrl = "api/stats"
        const response = await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization" : localStorage.getItem("token")
            }
        })

        const data = await response.json()
        return data.Value
    }

    render() {
        return template.call(this);
    }
}

export default Sidebar;
