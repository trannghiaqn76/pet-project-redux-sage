---
to: src/Areas/<%= area %>/actions/index.js
inject: true
before: "//IndexUsingHygen"
---

//<%= name%><%= area %>
export const GetData<%= name%><%= area %>Action = () => {
    return {
        type: GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>
    }
}
export const GetData<%= name%><%= area %>SuccessAction = (Data<%= name%>) => {
    return {
        type: GET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_SUCCEEDED,
        Data<%= name%>: Data<%= name%>
    }
}
export const Requert<%= name%><%= area %>FaileAction = (Err) => {
    return {
        type: REQUERT_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>_FAILED,
        err: Err
    }
}
export const SetData<%= name%><%= area %>Action = (Data<%= name%>) => {
    return {
        type: SET_DATA_<%= h.changeCase.upperCase(name) %>_<%= h.changeCase.upperCase(area) %>,
        Data<%= name%>: Data<%= name%>
    }
}