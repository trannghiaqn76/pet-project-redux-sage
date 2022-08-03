import { REQUERT_TEST_TEST_FAILED, GET_DATA_TEST_TEST_SUCCEEDED } from '../actions/actionTypes'

const testReducer = (DataTest = [], actions) => {
    console.log(actions)
    switch (actions.type) {
        case GET_DATA_TEST_TEST_SUCCEEDED:
            if(Object.keys(actions.DataTest).length > 0)
            {
                return {...DataTest,DataTest: actions.DataTest};
            }
            else
            {
                return {...DataTest,DataTest: []};
            }
        case REQUERT_TEST_TEST_FAILED:
            return {...DataTest,DataTest: []};
        default:
            return DataTest;
    }
}

export default testReducer;