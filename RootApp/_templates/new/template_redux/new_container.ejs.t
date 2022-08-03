---
to: src/Areas/<%= area %>/containers/<%= h.changeCase.lowerCaseFirst(name) %>Container.js
---
import { <%= name %>Component } from "../components";
import { connect } from "react-redux";
import { GetData<%= name %><%= area %>Action, SetData<%= name %><%= area %>Action } from "../actions";

const mapStateToProps = state => {
    return {
        ...state,
        Data<%= name %>: state.all<%= area %>Reducers.<%= h.changeCase.lowerCaseFirst(name) %>Reducer.Data<%= name %>,
        isResult: state.all<%= area %>Reducers.isResultReducer.isResult
    };
};

const mapDispatchToProps = dispatch => {
    return {
        GetData<%= name %>: () => {
            dispatch(GetData<%= name %><%= area %>Action());
        },
        SetData<%= name %>: (Data<%= name %>) => {
            dispatch(SetData<%= name %><%= area %>Action(Data<%= name %>));
        }
    };
};

export default connect(mapStateToProps, mapDispatchToProps)(<%= name %>Component);