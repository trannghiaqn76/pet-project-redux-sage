---
to: src/Areas/<%= area %>/components/<%= name %>/index.js
---
import React, { useState, useEffect, useRef } from 'react';
import './styles.scss';
import { MdModeEdit, MdDelete } from 'react-icons/md';
import { NotificationManager } from "react-notifications";

export default function <%= name %>Component(props) {

    const [task, setTask] = useState("");
    const [iD, setID] = useState();

    const txtTask = useRef(null);

    useEffect(() => {
        txtTask.current.focus();
        props.GetData<%= name %>()
    }, []
    );

    useEffect(() => {
        if (props.isResult) {
            props.GetData<%= name %>();
        }
    }, [props.isResult])

    const handleTask = (event) => {
        setTask(event.target.value);
    };
    const saveTask = () => {
        if(!task)
        {
            NotificationManager.error("Vui lòng nhập Task");
            return false;
        }
        const Data<%= name %> = {
            ID: iD,
            Task: task,
        }
        setTask("");
        txtTask.current.focus();
        props.SetData<%= name %>(Data<%= name %>);
        setID();
    };
    const deleteTask = (iD) => {
        const Data<%= name %> = {
            ID: iD,
            StatusDelete: true
        }
        props.SetData<%= name %>(Data<%= name %>);
    };
    const editTask = (item) => {
        setID(item.ID);
        setTask(item.Task)
        txtTask.current.focus();
    };

    return (
        <div className="ui">
            <div className="body-task">
                <div className="inputTast">
                    <input ref={txtTask} type="text" value={task} onChange={handleTask} />
                    <button onClick={saveTask}>save</button>
                </div>
                <div className="list-task">
                    <ul>
                        {props.Data<%= name %> && props.Data<%= name %>.map((item, index) => {
                            return (
                                <li key={index}>
                                    <div className="text">{item.Task}</div>
                                    <div className="btn-hading">
                                        <i onClick={() => editTask(item)}><MdModeEdit /></i>
                                        <i onClick={() => deleteTask(item.ID)}><MdDelete /></i>
                                    </div>
                                </li>
                            )
                        })}
                    </ul>
                </div>
                <i className="ui_title">
                    Wecome Area <%= area %> - <%= name %>
                </i>
            </div>
        </div>
    );
}
