import React from "react";
import { Routes, Route } from "react-router-dom";
import Test from "../containers/testContainer"
//IndexImportHygen

function RouterTest() {
    return (
            <Routes>
                <Route path="Test" element={<Test/>}/>
                <Route path="Test/Home" element={<Test/>}/>
                {/* IndexUsingHygen */}
            </Routes>
    );
}
export default RouterTest;
