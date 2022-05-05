import "./Residents.css";
import React from "react";
import Resident from "../Resident";

function template() {

    return (
        this.props.show ?
            <div className="residents">
                <div className="residents-block-name">СПИСКИ</div>
                <div className="residents-container">
                    <div className="residents-nav">
                        <input type="text" placeholder="Введите имя"/>
                        <div className="filters">
                            <button className="yellow-btn"/>
                            <button className="green-btn"/>
                            <button className="red-btn"/>

                            <button className="w-filter-btn">Ж</button>
                            <button className="m-filter-btn">М</button>
                            <button className="resident-add-btn"/>

                        </div>
                    </div>
                    <div className="residents-list-scroll">
                        <div className="residents-list">
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>
                            <Resident key="12"
                                      id="12"
                                      lastname="ASDa"
                                      firstName="asd"
                                      patronymic="asd"
                                      gender="Ж"/>

                        </div>
                    </div>


                </div>
            </div> : ""
    );
}

export default template;
