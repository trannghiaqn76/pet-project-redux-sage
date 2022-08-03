import {
  ISRESULT,
  GET_DATA_TEST_TEST,
  GET_DATA_TEST_TEST_SUCCEEDED,
  REQUERT_TEST_TEST_FAILED,
  SET_DATA_TEST_TEST,
  GET_DATA_TEST123_TEST,
  GET_DATA_TEST123_TEST_SUCCEEDED,
  REQUERT_TEST123_TEST_FAILED,
  SET_DATA_TEST123_TEST,

  //IndexImportHygen
} from "./actionTypes";

export const IsResultAction = (isResult) => {
  return {
    type: ISRESULT,
    isResult: isResult,
  };
};

//TestTest
export const GetDataTestTestAction = () => {
  return {
    type: GET_DATA_TEST_TEST,
  };
};
export const GetDataTestTestSuccessAction = (DataTest) => {
  return {
    type: GET_DATA_TEST_TEST_SUCCEEDED,
    DataTest: DataTest,
  };
};
export const RequertTestTestFaileAction = (Err) => {
  return {
    type: REQUERT_TEST_TEST_FAILED,
    err: Err,
  };
};
export const SetDataTestTestAction = (DataTest) => {
  return {
    type: SET_DATA_TEST_TEST,
    DataTest: DataTest,
  };
};
//Test123Test
export const GetDataTest123TestAction = () => {
  return {
    type: GET_DATA_TEST123_TEST,
  };
};
export const GetDataTest123TestSuccessAction = (DataTest123) => {
  return {
    type: GET_DATA_TEST123_TEST_SUCCEEDED,
    DataTest123: DataTest123,
  };
};
export const RequertTest123TestFaileAction = (Err) => {
  return {
    type: REQUERT_TEST123_TEST_FAILED,
    err: Err,
  };
};
export const SetDataTest123TestAction = (DataTest123) => {
  return {
    type: SET_DATA_TEST123_TEST,
    DataTest123: DataTest123,
  };
};
//Test123Test
// export const GetDataTest123TestAction = () => {
//   return {
//     type: GET_DATA_TEST123_TEST,
//   };
// };
// export const GetDataTest123TestSuccessAction = (DataTest123) => {
//   return {
//     type: GET_DATA_TEST123_TEST_SUCCEEDED,
//     DataTest123: DataTest123,
//   };
// };
// export const RequertTest123TestFaileAction = (Err) => {
//   return {
//     type: REQUERT_TEST123_TEST_FAILED,
//     err: Err,
//   };
// };
// export const SetDataTest123TestAction = (DataTest123) => {
//   return {
//     type: SET_DATA_TEST123_TEST,
//     DataTest123: DataTest123,
//   };
// };
//Test123Test
// export const GetDataTest123TestAction = () => {
//     return {
//         type: GET_DATA_TEST123_TEST
//     }
// }
// export const GetDataTest123TestSuccessAction = (DataTest123) => {
//     return {
//         type: GET_DATA_TEST123_TEST_SUCCEEDED,
//         DataTest123: DataTest123
//     }
// }
// export const RequertTest123TestFaileAction = (Err) => {
//     return {
//         type: REQUERT_TEST123_TEST_FAILED,
//         err: Err
//     }
// }
// export const SetDataTest123TestAction = (DataTest123) => {
//     return {
//         type: SET_DATA_TEST123_TEST,
//         DataTest123: DataTest123
//     }
// }
//IndexUsingHygen
