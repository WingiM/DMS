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
                    <div className="settings-container-block" style={{marginBottom: "10px", height: "40%"}}>
                        <span>Стоимость проживания</span>
                        <ul style={{marginTop: "5%"}}>
                            <li> <span>для бюджета</span> <input type="text" placeholder="..."/></li>
                            <li> <span>для коммерции</span> <input type="text" placeholder="..."/></li>
                        </ul>

                    </div>
                </div>
                <button className="settings-save-btn">Сохранить</button>
            </div>
        </div>

    );
};

export default template;