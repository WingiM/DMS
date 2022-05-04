import React from 'react';
import './custom.css'
import Sidebar from "./components/Sidebar";
import RoomsBlock from "./components/RoomsBlock"
import InRoomResidents from "./components/InRoomResidents";

class App extends React.Component {
    static displayName = App.name;

    constructor(props) {
        super(props);

        this.state = {
            showRooms: false,
            showInRoomResidents: false,
        }

        this.showRoomsButtonClickHandler = this.showRoomsButtonClickHandler.bind(this);
        this.openRoomButtonClickHandler = this.openRoomButtonClickHandler.bind(this);
        this.closeRoomButtonClickHandler = this.closeRoomButtonClickHandler.bind(this);
    }

    showRoomsButtonClickHandler() {
        this.setState({showRooms: true})
    }

    openRoomButtonClickHandler() {
        this.setState({showInRoomResidents: true})
    }

    closeRoomButtonClickHandler() {
        this.setState({showInRoomResidents : false})
    }

    render() {
        return (
            <React.StrictMode>
                <Sidebar
                    showRooms={this.showRoomsButtonClickHandler}
                />
                <RoomsBlock
                    show={this.state.showRooms}
                    openRoom = {this.openRoomButtonClickHandler}
                />
                <InRoomResidents
                    show={this.state.showInRoomResidents}
                    closeButtonClickHandler = {this.closeRoomButtonClickHandler}
                />
            </React.StrictMode>
        )
    }
}

export default App;
