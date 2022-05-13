import React    from "react";
import template from "./Residents.jsx";

class Residents extends React.Component {
  constructor(props) {
    super(props);
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
        (i["Course"] === 1)))
  }
  
  filterByRating(e) {
    this.props.filterHandler(this.props.residentsList.filter(i=>
        (i["Rating"] < 0)))
  }
  
  filterBySettlement(e) {
    this.props.filterHandler(this.props.residentsList.filter(i=>
        (i["RoomId"] === null)))
  }
  
  render() {
    return template.call(this);
  }
}

export default Residents;
