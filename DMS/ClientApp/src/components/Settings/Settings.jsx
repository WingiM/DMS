import "./Settings.css";
import React from "react";

function template() {
  return (
      <div className="settings">
          <div className="settings-name">
              <p>НАСТРОЙКИ</p>
          </div>

          <div className="settings-main-block">
              <div className="settings-container">
                  <div className="settings-container-block">
                      <span>Количество этажей:</span>
                      <input type="text" placeholder="..."/>
                  </div>
                  <div className="settings-container-block">
                      <span>Количество комнат:</span>
                      <input type="text" placeholder="..."/>
                  </div>
                  <div className="settings-container-block">
                      <span>Вместимость комнаты:</span>
                      <input type="text" placeholder="..."/>
                  </div>
              </div> 
              <button className="settings-save-btn">Сохранить</button>
          </div>
      </div>

  );
};

export default template;
