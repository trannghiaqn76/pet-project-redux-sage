---
to: src/Areas/<%= area %>/actions/index.js
---

import {
    ISRESULT,
    //IndexImportHygen
} from './actionTypes';

export const IsResultAction = (isResult) => {
    return {
        type: ISRESULT,
        isResult: isResult
    }
}

//IndexUsingHygen