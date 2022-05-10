import "./Resident.css";
import dotsImg from './img/resident3Dots.svg'
import React from "react";
import $ from 'jquery'

function template() {
  return (
      <div className={"resident-collapsible"}>
          <button
              onClick={(e) => this.openCollapsible(e)} className={"resident-header"}>
              {this.state.LastName.toUpperCase()} {this.state.FirstName.toUpperCase()} {this.state.Patronymic.toUpperCase()} <img className="header-dots" alt="dots" src={dotsImg}/>
          </button>
          <div className="resident-content" style={{maxHeight: this.state.ResidentId !== null ? "0" : "188px"}}>
              <form onSubmit={this.handleSubmit}>
                  <div className="resident-content-row">
                      <label>Фамилия:</label> <input autoFocus={this.state.ResidentId === null} name={"LastName"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.LastName} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Имя:</label> <input name={"FirstName"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.FirstName} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Отчество:</label> <input name={"Patronymic"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.Patronymic} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Пол:</label>

                      <input id={"resident_gender_male" + this.state.ResidentId} type="radio" onChange={this.handleChange} readOnly={this.props.readOnly} checked={this.state.Gender === 'М'}  name="Gender" value={"М"}/>
                      <label className="radio-label" htmlFor={"resident_gender_male" + this.state.ResidentId}>М</label>

                      <input id={"resident_gender_female" + this.state.ResidentId} type="radio" onChange={this.handleChange} readOnly={this.props.readOnly} checked={this.state.Gender === 'Ж'} name="Gender" value={"Ж"}/>
                      <label className="radio-label" htmlFor={"resident_gender_female" + this.state.ResidentId}>Ж</label>

                      <label>Дата рождения:</label> <input name={"BirthDate"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.BirthDate} type="date"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Серия и номер паспорта:</label>
                      <input name={"SeriesAndNumber"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.SeriesAndNumber} type={"text"}/>
                  </div>
                  <div className="resident-content-row">
                      <label>ИНН:</label>
                      <input name={"Tin"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.Tin}  type="text"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Рейтинг:</label>
                      <input name={"Rating"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.Rating} type="number"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Докладные:</label>
                      <input name={"Reports"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.Reports} type="number"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Задолженость:</label>
                      <input name={"Debt"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.Debt} type="number"/>
                  </div>
                  {
                      this.props.showSaveBtn ?
                          <div className="resident-content-row">
                              <input type="submit" value="Сохранить"/>
                          </div>
                          : ""
                  }
                  <div className={"resident-content-row"}>
                      <input className={"evict-btn"} type={"submit"} value={"Выселить"}/>
                  </div>
              </form>
          </div>
      </div>
  );
};

export default template;
