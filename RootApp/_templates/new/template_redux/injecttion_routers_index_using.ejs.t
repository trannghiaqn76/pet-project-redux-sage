---
to: src/Areas/<%= area %>/routers/index.js
inject: true
before: "IndexUsingHygen"
---
                <Route path="<%= name %>" element={<<%= name %>/>}/>