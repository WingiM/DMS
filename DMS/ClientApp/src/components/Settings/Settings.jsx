import "./Settings.css";
import React from "react";
import ModalWindow from "../ModalWindow";
import RatingOperationsLayout from "../ModalWindow/ModalWindowLayouts/RatingOperationsLayout";
import SettingsSaveLayout from "../ModalWindow/ModalWindowLayouts/SettingsSaveLayout";

function template() {
    return (
        this.props.show ? 
            
        <div className="settings">
            <ModalWindow
                show={this.state.showModal}
                toggleHandler={this.toggleModal}
                layout={this.state.layout}
                residents={this.state.modalResidents}
                layoutName={this.state.layoutName}
            />
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
                    <button className="settings-save-btn" onClick={() => this.toggleModal(
                        <SettingsSaveLayout/>, "settings-save")}>Сохранить</button>
                    <div className="settings-container-block header">
                        <span>Стоимость проживания</span>
                    </div>
                    <div className="settings-container-block" style={{marginBottom: "0", height: "19%"}}>
                        <ul>
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