import { NotificationManager } from "react-notifications";
let DataTest = [
  {
    ID: 1,
    Task: "Task1",
  },
  {
    ID: 2,
    Task: "Task2",
  },
  {
    ID: 3,
    Task: "Task3",
  },
  {
    ID: 4,
    Task: "Task4",
  },
  {
    ID: 5,
    Task: "Task5",
  },
];
//Test
function* GetDataTestFromApi() {
  // const response = yield fetch('http://eschecklist-api-dev.fpt.net/api/Err/GetAllUser');
  // console.log("response", response)
  // const Data = yield response.json();
  // if (Data.Status === "Success") {
  // 	console.log("Data.Status", Data.Data)
  // 	return yield Data.Data;
  // }
  // return yield {};
  return DataTest;
}
function* SetDataTestFromApi(DataTest) {
  console.log("DataTest", DataTest);
  if (!DataTest.StatusDelete) {
    if (!DataTest.ID) {
      let ID = 1;
      DataTest.map((item) => {
        if (item.ID >= ID) {
          ID = item.ID;
        }
      });
      DataTest.push({ ID: ID + 1, Task: DataTest.Task });
      NotificationManager.success("Thêm thành công");
      return true;
    } else {
      DataTest.map((item) => {
        if (item.ID === DataTest.ID) {
          item.Task = DataTest.Task;
        }
      });
      NotificationManager.success("Sửa thành công");
      return true;
    }
  } else {
    var index1;
    DataTest.map((item, index) => {
      if (item.ID === DataTest.ID) {
        index1 = index;
      }
    });

    if (index1 !== undefined) {
      NotificationManager.success("Xóa thành công");
      DataTest.splice(index1, 1);
      return yield true;
    } else {
      NotificationManager.error("Task không tồn tại");
      return false;
    }
  }
  return yield false;
}

//Test123
function* GetDataTest123FromApi() {
  // const response = yield fetch('http://eschecklist-api-dev.fpt.net/api/Err/GetAllUser');
  // console.log("response", response)
  // const Data = yield response.json();
  // if (Data.Status === "Success") {
  // 	console.log("Data.Status", Data.Data)
  // 	return yield Data.Data;
  // }
  // return yield {};
  return DataTest;
}
function* SetDataTest123FromApi(DataTest123) {
  if (!DataTest123.StatusDelete) {
    if (!DataTest123.ID) {
      let ID = 1;
      DataTest.map((item) => {
        if (item.ID >= ID) {
          ID = item.ID;
        }
      });
      DataTest.push({ ID: ID + 1, Task: DataTest123.Task });
      NotificationManager.success("Thêm thành công");
      return true;
    } else {
      DataTest.map((item) => {
        if (item.ID === DataTest123.ID) {
          item.Task = DataTest123.Task;
        }
      });
      NotificationManager.success("Sửa thành công");
      return true;
    }
  } else {
    var index1;
    DataTest.map((item, index) => {
      if (item.ID === DataTest123.ID) {
        index1 = index;
      }
    });

    if (index1 !== undefined) {
      NotificationManager.success("Xóa thành công");
      DataTest.splice(index1, 1);
      return yield true;
    } else {
      NotificationManager.error("Task không tồn tại");
      return false;
    }
  }
  return yield false;
}
//CreateFuntionHygen
export const Api = {
  GetDataTestFromApi,
  SetDataTestFromApi,
  GetDataTest123FromApi,
  SetDataTest123FromApi,
  //ExportFuntionHygen
};
