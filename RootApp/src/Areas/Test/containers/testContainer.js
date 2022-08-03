import TestComponent from "../components/Test/index";
import { connect } from "react-redux";
import { GetDataTestTestAction, SetDataTestTestAction } from "../actions";

const mapStateToProps = (state) => {
  console.log(state);
  return {
    ...state,
    DataTest: state.allTestReducers.testReducer.DataTest,
    isResult: state.allTestReducers.isResultReducer.isResult,
  };
};

const mapDispatchToProps = (dispatch) => {
  return {
    GetDataTest: () => {
      dispatch(GetDataTestTestAction());
    },
    SetDataTest: (DataTest) => {
      dispatch(SetDataTestTestAction(DataTest));
    },
  };
};

export default connect(mapStateToProps, mapDispatchToProps)(TestComponent);
