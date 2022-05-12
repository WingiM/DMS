import React from "react";
class SettingsSaveLayout extends React.Component {
    constructor(props) {
        super(props);
        
        this.state = {
            applyBtnDisabled: true,
            passwordValue: null,
        }
    }
    
    async passwordInputHandler(e) {
        this.state.passwordValue = e.target.value
        this.setState({
            applyBtnDisabled: this.state.passwordValue !== localStorage["password"]
        })
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
                    <input 
                        onInput={(e) => this.passwordInputHandler(e)} 
                        value={this.state.passwordValue}
                        type="password" className={"password-repeat"} placeholder={"Введите пароль"}
                    />
                    <span className={"additional-info"}>*Для подтверждения сброса введите пароль</span>
                    <div className="buttons-container">
                        <button onClick={this.props.toggleHandler} className="settings-btn cancel">Отмена</button>
                        <button 
                            disabled={this.state.applyBtnDisabled} 
                            onClick={this.props.applyHardReset}
                            className={this.state.applyBtnDisabled ? "settings-btn done" : "settings-btn active"}>Применить</button>
                    </div>
                </div>
            </div>
        )
    }
}

export default SettingsSaveLayout;   