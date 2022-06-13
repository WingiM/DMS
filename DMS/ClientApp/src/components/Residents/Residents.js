import React    from "react";
import template from "./Residents.jsx";

class Residents extends React.Component {
  constructor(props) {
    super(props);
    
    this.state = {
      showModal: false,
      chosenResident: null,
      modalLayout: null,
    }

    this.toggleHandler = this.toggleHandler.bind(this)
    this.toggleDeleteResidentConfirmModal = this.toggleDeleteResidentConfirmModal.bind(this)
    this.toggleTransactionModal = this.toggleTransactionModal.bind(this)
    this.toggleRatingModal = this.toggleRatingModal.bind(this)
    this.multicastAccrual = this.multicastAccrual.bind(this)
  }
  
  filterByName(e) {
    this.props.filterHandler(this.props.residentsList.filter(i=>
        (~(i["FirstName"] + i["LastName"] + i["Patronymic"]).toLowerCase().indexOf(e.target.value.toLowerCase()))))
  }
  
  filterByGender(e) {
    this.props.filterHandler(this.props.residentsList.filter(i=>
        ((i["Gender"] === e.target.textContent))))
  }
  
  filterByCourse(e) {
    this.props.filterHandler(this.props.residentsList.filter(i=>
        (i["Course"] == 1)))
  }
  
  filterByRating(e) {
    this.props.filterHandler(this.props.residentsList.filter(i=>
        (i["Rating"] < 0)))
  }
  
  filterBySettlement(e) {
    this.props.filterHandler(this.props.residentsList.filter(i=>
        (i["RoomId"] === null)))
  }

  toggleHandler() {
    this.setState({
      showModal: !this.state.showModal
    })
  }

  toggleTransactionModal(resident) {
    this.setState({
      showModal: !this.state.showModal,
      chosenResident: resident,
      modalLayout: "transactionOrder",
    })
  }

  toggleRatingModal(resident) {
    this.setState({
      showModal: !this.state.showModal,
      chosenResident: resident,
      modalLayout: "ratingModal",
    })
  }
  
  toggleDeleteResidentConfirmModal(resident) {
    this.setState({
      showModal: !this.state.showModal,
      chosenResident: resident,
      modalLayout: "deleteResidentModal"
    })
  }
  
  async multicastAccrual() {
    await fetch("api/stats/accruals", {
      method: "POST",
      headers: {
        "Authorization": localStorage.getItem("token"),
        "Content-Type": 'application/json',
      },
    })
    this.props.updateResidentsList()
  }
  
  render() {
    return template.call(this);
  }
}

export default Residents;
