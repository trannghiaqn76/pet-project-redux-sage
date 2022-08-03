import {GET_DATA_TEST_TEST, SET_DATA_TEST_TEST} from '../actions/actionTypes'
import {RequertTestTestFaileAction, GetDataTestTestSuccessAction, IsResultAction } from '../actions'

import { put, takeLatest} from 'redux-saga/effects'
import { Api } from './api'

function* GetDataTest(){
    try{
        const DataTest = yield Api.GetDataTestFromApi();
        yield put(GetDataTestTestSuccessAction(DataTest))
    }catch(error){
        yield put(RequertTestTestFaileAction(error))
    }
}
export function* watchGetDataTest(){
    yield takeLatest(GET_DATA_TEST_TEST, GetDataTest)
}

function* SetDataTest(action){
    try{
        const isResult = yield Api.SetDataTestFromApi(action.DataTest);
        if(isResult)
        {
            yield put(IsResultAction(isResult))
        }
        else
        {
            yield put(RequertTestTestFaileAction("error"))
        }
    }catch(error){
        yield put(RequertTestTestFaileAction(error))
    }
}
export function* watchSetDataTest(){
    yield takeLatest(SET_DATA_TEST_TEST, SetDataTest)
}