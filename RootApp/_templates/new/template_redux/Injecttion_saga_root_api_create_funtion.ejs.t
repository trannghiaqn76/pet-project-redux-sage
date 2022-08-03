---
to: src/Areas/<%= area %>/sagas/api.js
inject: true
before: "//CreateFuntionHygen"
---
//<%= name %>
function* GetData<%= name %>FromApi() {
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
function* SetData<%= name %>FromApi(Data<%= name %>) {
    if (!Data<%= name %>.StatusDelete) {
        if(!Data<%= name %>.ID)
        {
            let ID = 1;
            DataTest.map((item)=>{
                if(item.ID >= ID)
                {
                    ID = item.ID;
                }
            })
            DataTest.push({ID:ID+1,Task:Data<%= name %>.Task})
            NotificationManager.success("Thêm thành công");
            return true;
        }
        else
        {
            DataTest.map((item) => {
                if (item.ID === Data<%= name %>.ID) {
                    item.Task = Data<%= name %>.Task;
                }
            });
            NotificationManager.success("Sửa thành công");
            return true;
        }
    }
    else {
        var index1;
        DataTest.map((item, index) => {
            if (item.ID === Data<%= name %>.ID) {
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