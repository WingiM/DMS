import "./Settings.css";
import React from "react";

function template() {
    return (
        this.props.show ? 
        <div className="settings">
            <div className="settings-name">
                <p>НАСТРОЙКИ</p>
            </div>

            <div className="settings-main-block">
                <div className="settings-container">
                    <div className="settings-container-block header">
                        <span>Основные настройки</span>
                    </div>
                    <div className="settings-container-block">
                        <span>Наименование</span>
                        <input type="text" placeholder="..." step={1}/>
                    </div>
                    <div className="settings-container-block">
                        <span>Количество этажей:</span>
                        <input type="number" placeholder="..." step={1}/>
                    </div>
                    <div className="settings-container-block">
                        <span>Количество комнат:</span>
                        <input type="number" placeholder="..."/>
                    </div>
                    <div className="settings-container-block">
                        <span>Вместимость комнаты:</span>
                        <input type="number" placeholder="..."/>
                    </div>
                    <button className="settings-save-btn">Сохранить</button>
                    <div className="settings-container-block header">
                        <span>Стоимость проживания</span>
                    </div>
                    <div className="settings-container-block" style={{marginBottom: "10px", height: "20%"}}>
                        <span>Стоимость проживания</span>
                        <ul style={{marginTop: "5%"}}>
                            <li> <span>для бюджета</span> <input type="number" placeholder="..."/></li>
                            <li> <span>для коммерции</span> <input type="number" placeholder="..."/></li>
                        </ul>
                    
                    </div>
                    <button className="settings-constant-change-btn">Изменить</button>
                </div>
            </div>
        </div> : ""

    );
};

export default template;