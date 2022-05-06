import "./Login.css";
import logo from "./img/logo.svg";
import f_circle from "./img/Intersect-1.svg";
import s_circle from "./img/Intersect-2.svg";
import t_circle from "./img/Intersect-3.svg";
import circle from "./img/Intersect.svg";
import React from "react";

function template() {
    let state = this.state.isVisible ? "visible" : "";
    return (
        <div className="main">
            <div className="login-form-container">
                <div className="col-2-3" style={{height: "100%", position: "relative"}}>
                    <div className="row">
                        <div className="logo">
                            <img src={t_circle} style={{position: "relative", top: 0, bottom: 0}} alt=""/>
                            <img src={logo} style={{position: "absolute", top: "4%", left: 0}} alt=""/>
                        </div>
                    </div>
                    <div className="row" style={{textAlign: "center", marginTop: "5.07071%", height: "75.773282%"}} onKeyDown={e => this.keyUpController(e)}>
                        <p className="authorization-text">Авторизация</p>
                            <input style={{zIndex: 4,}} type="password" onChange={ e => this.setState({password: e.target.value, isVisible: false}) }
                                   className="password-input" placeholder="пароль"/> <br/>
                            <span className={`incorrect-password ${state}`}>неверный пароль</span> <br/>
                            <button className="login-btn" type={"submit"} onClick={this.loginHandler} >Войти</button>
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
}

export default template;
