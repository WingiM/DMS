import "./Resident.css";
import dotsImg from './img/resident3Dots.svg'
import React from "react";

function template() {
  return (
      <div className={"resident-collapsible"}>
          <button
              onClick={(e) => this.openCollapsible(e)} className={"resident-header"}>
              {this.state.lastname.toUpperCase()} {this.state.firstName.toUpperCase()} {this.state.patronymic.toUpperCase()} <img className="header-dots" alt="dots" src={dotsImg}/>
          </button>
          <div className="resident-content" style={{maxHeight: this.state.id !== null ? "0" : "188px"}}>
              <form onSubmit={this.handleSubmit}>
                  <div className="resident-content-row">
                      <label>Фамилия:</label> <input autoFocus={this.state.id === null} name={"lastname"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.lastname} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Имя:</label> <input name={"firstName"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.firstName} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Отчество:</label> <input name={"patronymic"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.patronymic} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Пол:</label>

                      <input id={"resident_gender_male" + this.state.id} type="radio" onChange={this.handleChange} readOnly={this.props.readOnly} checked={this.state.gender === 'М'}  name="gender" value={"М"}/>
                      <label className="radio-label" htmlFor={"resident_gender_male" + this.state.id}>М</label>

                      <input id={"resident_gender_female" + this.state.id} type="radio" onChange={this.handleChange} readOnly={this.props.readOnly} checked={this.state.gender === 'Ж'} name="gender" value={"Ж"}/>
                      <label className="radio-label" htmlFor={"resident_gender_female" + this.state.id}>Ж</label>

                      <label>Дата рождения:</label> <input name={"birthDate"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.birthDate} type="date"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Серия и номер паспорта:</label>
                      <input name={"passportInformation"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.passportInformation} type={"text"}/>
                  </div>
                  
                  <div className="resident-content-row">
                      <label>ИНН:</label>
                      <input name={"tin"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.tin}  type="text"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Курс:</label>
                      <input name={"course"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.course}  type="number"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Рейтинг:</label>
                      <input name={"rating"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.rating} type="number"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Докладные:</label>
                      <input name={"reports"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.reports} type="number"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Задолженость:</label>
                      <input name={"debt"} onChange={this.handleChange} readOnly={this.props.readOnly} value={this.state.debt} type="number"/>
                  </div>
                  
                 
              </form>
              <div className={"button-content-row"}>
                  <input className={"evict-btn"} type={"submit"} value={"Выселить"}/>
                  <input className={"transaction-btn"} type={"submit"} value={"Транзакция"}/>
                  {
                      this.props.showSaveBtn ?
                          <input type="submit" value="Сохранить"/>
                          : ""
                  }
              </div>
          </div>
      </div>
  );
};

export default template;
