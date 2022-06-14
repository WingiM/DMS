import React from "react";
import template from "./Documents.jsx"; 

class Documents extends React.Component {
    constructor(props) {
        super(props);
        this.toggleModal = this.toggleModal.bind(this)
        this.state = {
            showModal: false,
            layout: null,
            layoutName: ""
        }
    }

    filterByName(e) {
        this.props.filterHandler(this.props.residentsList.filter(i=>
            (~(i["FirstName"] + i["LastName"] + i["Patronymic"]).toLowerCase().indexOf(e.target.value.toLowerCase()))))
    }

    toggleModal(layout, layoutName) {
        this.setState({
            showModal: !this.state.showModal,
            layout: layout,
            layoutName: layoutName
        })
    }
    
    render() {
        return template.call(this);
    }

    openCollapsible(e) {
        let elem = e.currentTarget
        elem.classList.toggle("active");
        let content = elem.nextElementSibling;
        if (content.style.maxHeight) {
            content.style.maxHeight = null;
        } else {
            content.style.maxHeight = content.scrollHeight + "px";
        }

    }
}

export default Documents;
