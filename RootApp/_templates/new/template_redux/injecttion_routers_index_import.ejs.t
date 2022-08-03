---
to: src/Areas/<%= area %>/routers/index.js
inject: true
before: "//IndexImportHygen"
---
import <%= name %> from "../containers/<%= h.changeCase.lowerCaseFirst(name) %>Container"