import "./Resident.css";
import dotsImg from './img/resident3Dots.svg'
import React from "react";

function template() {
  return (
      <div className="resident-collapsible">
          <button
              onClick={(e) => this.openCollapsible(e)} className="resident-header">
              LOREM IPSUM DOLOR <img className="header-dots" alt="dots" src={dotsImg}/>
          </button>
          <div className="resident-content">
              <form>
                  <div className="resident-content-row">
                      <label>Фамилия:</label> <input id={"resident_lastname_" + 1} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Имя:</label> <input id={"resident_name_" + 1} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Отчество:</label> <input id={"resident_patronymic_" + 1} type="text"/> <br/>
                  </div>
                  <div className="resident-content-row">
                      <label>Пол:</label>

                      <input id={"resident_gender_male" + 1} type="radio" checked name="gender" value={"М"}/>
                      <label className="radio-label" htmlFor={"resident_gender_male" + 1}>М</label>

                      <input id={"resident_gender_female" + 1} type="radio" name="gender" value={"Ж"}/>
                      <label className="radio-label" htmlFor={"resident_gender_female" + 1}>Ж</label>

                      <label>Дата рождения:</label> <input id={"resident_birthdate_" + 1} type="date"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Серия и номер паспорта:</label>
                      <input id={"resident_passport_" + 1} type={"text"}/>
                  </div>
                  <div className="resident-content-row">
                      <label>ИНН:</label>
                      <input id={"resident_TIN_" + 1} type="text"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Рейтинг:</label>
                      <input id={"resident_rating_" + 1} type="number"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Докладные:</label>
                      <input id={"resident_report_" + 1} type="number"/>
                  </div>
                  <div className="resident-content-row">
                      <label>Задолженость:</label>
                      <input id={"resident_debt_" + 1} type="number"/>
                  </div>

              </form>

          </div>
      </div>
  );
};

export default template;
