import "./Registration.css";
import React from "react";
import t_circle from "../Login/img/Intersect-3.svg";
import logo from "../Login/img/logo.svg";
import circle from "../Login/img/Intersect.svg";
import f_circle from "../Login/img/Intersect-1.svg";
import s_circle from "../Login/img/Intersect-2.svg";

function template() {
    return (
        <div className="main">
            <div className="registration-form-container">
                <div className="col-2-3" style={{height: "100%", position: "relative"}}>
                    <div className="row">
                        <div className="logo">
                            <img src={t_circle} style={{position: "relative", top: 0, bottom: 0}} alt=""/>
                            <img src={logo} style={{position: "absolute", top: "4%", left: 0}} alt=""/>
                        </div>
                    </div>
                    <div className="row" style={{textAlign: "center", marginTop: "5.07071%", height: "75.773282%"}} onKeyDown={e => this.keyDownController(e)}>
                        <p className="registration-text">Регистрация</p>
                        <input style={{zIndex: 4,}} type="password" onChange={ e => this.setState({password: e.target.value}) }
                               className="password-input" placeholder="пароль"/> <br/>
                        <input style={{zIndex: 4,}} type="password" onChange={ e => this.setState({repeatPassword: e.target.value}) }
                               className="password-input" placeholder="повторите пароль"/> <br/>
                        <button className="registration-btn" type={"submit"} onClick={this.setPassword} >Зарегестрироваться</button>
                    </div>
                </div>
                <div className="col-1-3" style={{height: "100%", position: "relative"}}>
                    <img src={circle} style={{position: "relative", zIndex: 1, width: "100%"}} alt=""/>
                    <img src={f_circle}
                         style={{position: "absolute", zIndex: 3, right: "-1px", width: "76.1079137%"}} alt=""/>
                    <img src={s_circle}
                         style={{position: "absolute", right: "-1px", zIndex: 4, width: "49.1606715%"}} alt=""/>
                </div>
            </div>
        </div>

    )
};

export default template;
