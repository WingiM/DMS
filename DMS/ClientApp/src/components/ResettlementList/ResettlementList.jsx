import "./ResettlementList.css";
import React from "react";
import Resident from "../Resident";

function template() {
  return (
      this.props.show ?
          <div className="resettlement">
              <div className="resettlement-list-block-header">ПЕРЕЗАСЕЛЕНИЕ</div>
              <div className="resettlement-list-container">
                  <div className="resettlement-list-nav">
                      <input type="text" onInput={(e) => this.filterByName(e)} placeholder="Введите имя"/>
                  </div>
                  <div className="resettlement-list-scroll">
                      <div className="resettlement-list">
                          {
                              this.props.residentsList !== undefined ?
                                  this.props.residentsList.map(resident =>
                                      <Resident
                                          updateResidentsList={this.props.updateResidentsList}
                                          key={resident["ResidentId"]}
                                          readOnly={false}
                                          showSaveBtn={true}
                                          id={resident["ResidentId"]}
                                          lastname={resident["LastName"]}
                                          firstName={resident["FirstName"]}
                                          patronymic={resident["Patronymic"]}
                                          gender={resident["Gender"]}
                                          birthDate={resident["BirthDate"]}
                                          passportInformation={resident["PassportInformation"] === null ? '' : resident["PassportInformation"]}
                                          tin={resident["Tin"]}
                                          rating={resident["Rating"]}
                                          debt={resident["Debt"]}
                                          reports={resident["Reports"]}
                                          roomId={resident["RoomId"]}
                                          course={resident["Course"]}
                                      />) : ''
                          }
                      </div>
                  </div>
              </div>
          </div> : ""
  );
};

export default template;
