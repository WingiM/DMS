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
        await this.fetchStats()
    }

    async fetchStats() {
        const requestUrl = "api/stats"
        await fetch(requestUrl, {
            method: "GET",
            headers: {
                "Authorization" : localStorage.getItem("token")
            }
        })
            .then((response) => response.json())
            .then((data) => data.Value)
            .then((val) => {
                this.setState({
                    settled: val["Settled"],
                    total: val["Total"],
                    free: val["Total"] - val["Settled"],
                    percentage: val["Settled"] / val["Total"] * 100 | 0
                })
            })
    }

    render() {
        return template.call(this);
    }
}

export default Sidebar;
