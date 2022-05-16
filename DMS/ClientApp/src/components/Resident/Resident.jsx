import "./Resident.css";
import dotsImg from './img/resident3Dots.svg'
import yellowDot from './img/yellowDot.svg'
import greenDot from './img/greenDot.svg'
import redDot from './img/redDot.svg'
import React from "react";
import $ from 'jquery'

function template() {
  return (
      <div className={"resident-collapsible"}>
          <button
              onClick={(e) => this.openCollapsible(e)} className={"resident-header"}>
              {this.state.LastName.toUpperCase()} {this.state.FirstName.toUpperCase()} {this.state.Patronymic.toUpperCase()}
              <img className="header-dots" alt="dots" src={dotsImg}/>
              {this.state.Rating < 0 ? <img alt={"dot"} className={"state-dot"} src={redDot}/> : ''}
              {this.state.Course == 1 ? <img alt={"dot"} className={"state-dot"} src={greenDot}/> : ''}
              {this.state.RoomId === null ? <img alt={"dot"} className={"state-dot"} src={yellowDot}/> : ''}
          </button>
          <div className="resident-content" style={{maxHeight: this.state.ResidentId !== null ? null : "188px"}}>
              <form>
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
                      <label>Кем выдан:</label>
                      <input name={"IssuedBy"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.IssuedBy}  type="text"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Дата выдачи:</label>
                      <input name={"IssueDate"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.IssueDate} type="date"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Код подразделения:</label>
                      <input name={"DepartmentCode"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.DepartmentCode} type="number"/>
                  </div>

                  <div className="resident-content-row">
                      <label>ИНН:</label>
                      <input name={"Tin"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.Tin} style={{width: "35%", marginRight: "15%"}} type="text"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Адрес прописки:</label>
                      <input name={"Address"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.Address}  style={{width: "35%", marginRight: "15%"}} type="text"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Курс:</label>
                      <input name={"Course"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.Course}  type="number"/>
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
              </form>
              <div className={"button-content-row"}>
                  <span className={"submit-text"}>Ошибка</span>
                  <input className={"evict-btn"} type={"submit"} value={"Выселить"}/>
                  <input className={"transaction-btn"} type={"submit"} value={"Транзакция"}/>
                  {
                      this.props.showSaveBtn ?
                          <input type="submit" onClick={(e) => this.handleSubmit(e)} value="Сохранить"/>
                          : ""
                  }
              </div>
          </div>
      </div>
  );
};

export default template;
