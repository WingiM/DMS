import React    from "react";
import template from "./Settings.jsx";

class Setting extends React.Component {
  constructor(props) {
    super(props);
    this.toggleModal = this.toggleModal.bind(this)
    this.state = {
      showModal: false,
      layout: null,
      layoutName: ""
    }
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
}

export default Setting;
