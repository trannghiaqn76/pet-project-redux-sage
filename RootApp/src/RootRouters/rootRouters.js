import React from 'react';
import {
    Routes, Route, Navigate
} from "react-router-dom";
import Cookies from 'universal-cookie';
import RouterTest from '../Areas/Test/routers';
//IndexImportHygen

const cookies = new Cookies();
function rootRouters() {
    return (
            <Routes>
                <Route path="/*" element={<RouterTest/>}/>
                {/* IndexUsingHygen */}
            </Routes>
    );
}
export default rootRouters;
