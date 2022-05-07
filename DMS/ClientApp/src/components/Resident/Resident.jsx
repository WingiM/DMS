import "./Resident.css";
import dotsImg from './img/resident3Dots.svg'
import React from "react";
import ModalWindow from "../ModalWindow";

function template() {
  return (
      <div className="resident-collapsible">
          <button
              onClick={(e) => this.openCollapsible(e)} className="resident-header">
              {this.state.lastname.toUpperCase()} {this.state.firstName.toUpperCase()} {this.state.patronymic.toUpperCase()} <img className="header-dots" alt="dots" src={dotsImg}/>
          </button>
          <div className="resident-content">
              <form onSubmit={this.handleSubmit}>
                  <div className="resident-content-row">
                      <label>Фамилия:</label> <input name={"lastname"} onChange={this.handleChange} defaultValue={this.state.lastname} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Имя:</label> <input name={"firstName"} onChange={this.handleChange} defaultValue={this.state.firstName} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Отчество:</label> <input name={"patronymic"} onChange={this.handleChange} defaultValue={this.state.patronymic} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Пол:</label>

                      <input id={"resident_gender_male" + this.state.id} onChange={this.handleChange} type="radio" defaultChecked={this.state.gender === 'M'}  name="gender" value={"М"}/>
                      <label className="radio-label" htmlFor={"resident_gender_male" + this.state.id}>М</label>

                      <input id={"resident_gender_female" + this.state.id} onChange={this.handleChange} type="radio" defaultChecked={this.state.gender === 'Ж'} name="gender" value={"Ж"}/>
                      <label className="radio-label" htmlFor={"resident_gender_female" + this.state.id}>Ж</label>

                      <label>Дата рождения:</label> <input name={"birthdate"} defaultValue={this.state.birthDate} type="date"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Серия и номер паспорта:</label>
                      <input name={"passportInformation"} onChange={this.handleChange} defaultValue={this.state.passportInformation} type={"text"}/>
                  </div>
                  <div className="resident-content-row">
                      <label>ИНН:</label>
                      <input name={"tin"} onChange={this.handleChange} defaultValue={this.state.tin} type="text"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Рейтинг:</label>
                      <input name={"rating"} onChange={this.handleChange} defaultValue={this.state.rating} type="number"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Докладные:</label>
                      <input name={"reports"} onChange={this.handleChange} defaultValue={this.state.reports} type="number"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Задолженость:</label>
                      <input name={"debt"} onChange={this.handleChange} defaultValue={this.state.debt} type="number"/>
                  </div>

                  <div className="resident-content-row">
                      <input type="submit" value="Сохранить"/>
                  </div>

              </form>
              
          </div>
      </div>
  );
};

export default template;
