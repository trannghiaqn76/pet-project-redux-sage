---
to: src/Areas/<%= area %>/reducers/<%= h.changeCase.lowerCaseFirst(name) %>Reducer.js
---
import { REQUERT_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_FAILED, GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_SUCCEEDED } from '../actions/actionTypes'

const <%= h.changeCase.lowerCaseFirst(name) %>Reducer = (Data<%= name %> = [], actions) => {
    switch (actions.type) {
        case GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_SUCCEEDED:
            if(Object.keys(actions.Data<%= name %>).length > 0)
            {
                return {...Data<%= name %>,Data<%= name %>: actions.Data<%= name %>};
            }
            else
            {
                return {...Data<%= name %>,Data<%= name %>: []};
            }
        case REQUERT_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_FAILED:
            return {...Data<%= name %>,Data<%= name %>: []};
        default:
            return Data<%= name %>;
    }
}

export default <%= h.changeCase.lowerCaseFirst(name) %>Reducer;