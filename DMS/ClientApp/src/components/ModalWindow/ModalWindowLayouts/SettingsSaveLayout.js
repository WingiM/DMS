import React from "react";
class SettingsSaveLayout extends React.Component {
    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <div className="rooms-header in-modal">ПРЕДУПРЕЖДЕНИЕ!</div>
                <div className="settings-save-content">
                    <span className={"info"}>
                        При применении настроек будет выполнен <strong>полный сброс</strong> проживающих в комнатах. 
                        <br/> Комнаты будут пересозданы, но списки проживающих и документы сохранятся.
                    </span>
                    <input type="text" className={"password-repeat"} placeholder={"Введите пароль"}/>
                    <span className={"additional-info"}>*Для подтверждения сброса введите пароль</span>
                    <div className="buttons-container">
                        <button className="settings-btn cancel">Отмена</button>
                        <button className="settings-btn done">Применить</button>
                    </div>
                </div>
            </div>
        )
    }
}

export default SettingsSaveLayout;   