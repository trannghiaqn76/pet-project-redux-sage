---
to: src/Areas/<%= area %>/sagas/<%= h.changeCase.lowerCaseFirst(name) %>Saga.js
---
import {GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>, SET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>} from '../actions/actionTypes'
import {Requert<%= name %><%= area %>FaileAction, GetData<%= name %><%= area %>SuccessAction, IsResultAction } from '../actions'

import { put, takeLatest} from 'redux-saga/effects'
import { Api } from './api'

function* GetData<%= name %>(){
    try{
        const Data<%= name %> = yield Api.GetData<%= name %>FromApi();
        yield put(GetData<%= name %><%= area %>SuccessAction(Data<%= name %>))
    }catch(error){
        yield put(Requert<%= name %><%= area %>FaileAction(error))
    }
}
export function* watchGetData<%= name %>(){
    yield takeLatest(GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>, GetData<%= name %>)
}

function* SetData<%= name %>(action){
    try{
        const isResult = yield Api.SetData<%= name %>FromApi(action.Data<%= name %>);
        if(isResult)
        {
            yield put(IsResultAction(isResult))
        }
        else
        {
            yield put(Requert<%= name %><%= area %>FaileAction("error"))
        }
    }catch(error){
        yield put(Requert<%= name %><%= area %>FaileAction(error))
    }
}
export function* watchSetData<%= name %>(){
    yield takeLatest(SET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>, SetData<%= name %>)
}