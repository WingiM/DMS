import React    from "react";
import template from "./ModalWindow.jsx";
import './ModalWindowLayouts/Layouts.css'

class ModalWindow extends React.Component {
  constructor(props) {
    super(props);
  }
  
  render() {
    return template.call(this);
  }
}

export default ModalWindow;
