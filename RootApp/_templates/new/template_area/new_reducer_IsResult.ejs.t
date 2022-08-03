---
to: src/Areas/<%= area %>/reducers/isResultReducer.js
---
import { ISRESULT } from '../actions/actionTypes'

const isResultReducer = (isResult = false, actions) => {
    switch (actions.type) {
        case ISRESULT:
            return {...isResult,isResult: actions.isResult};
        default:
            return {...isResult,isResult: false};
    }
}

export default isResultReducer;