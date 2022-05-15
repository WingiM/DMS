import React    from "react";
import template from "./ModalWindow.jsx";
import './ModalWindowLayouts/Layouts.css'

class ModalWindow extends React.Component {
  constructor(props) {
    super(props);
  }

  layoutsNameToHtmlClassName(layoutName) {
    const layoutsName = {
      "SettlementOrderLayout": "settlement-order",
      "ResidentsListLayout": "residents-list-layout",
      "EvictionOrderLayout": "eviction-order",
      "RatingOperationsLayout": "rating-operation",
      "TransactionsLayout": "transaction-layout"
    }
    return layoutsName[layoutName]
  }
  
  render() {
    return template.call(this);
  }
}

export default ModalWindow;
