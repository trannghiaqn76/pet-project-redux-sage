---
to: src/Areas/<%= area %>/components/<%= name %>/styles.scss
---
.ui{
    display: flex;
    justify-content: center;
    margin-top: 15px;
    align-items: center;
    flex-direction: column;
    .body-task{
        width: 500px;
        width: 500px;
        min-height: 700px;
        background: linear-gradient(-45deg, #4facfe, #4facfe);
        position: relative;
        .inputTast{
            padding: 20px;
            display: flex;
            input{
                flex: 1;
                border: none;
                border-radius: 5px;
                margin-right: 5px;
                outline: none;
                padding: 5px 10px;
                color: #4facfe;
            }
            button{
                border: none;
                border-radius: 5px;
                width: 70px;
                color: #4facfe;
                background: #fff;
                font-weight: bold;
                outline: none;
                transition: all 0.25s;
                &:hover{
                    box-shadow: 0px 10px 20px 0px rgba(0, 0, 0, 0.14), 0px 1px 20px 0px rgba(0, 0, 0, 0.14);
                }
            }
        }
        .list-task{
            ul{
                list-style: none;
                margin: 0px 20px;
                color: #fff;
                padding: 0 5px;
                li{
                    display: flex;
                    border-bottom: 1px solid #fff;
                    padding: 5px 0px;
                    .text{
                        flex: 1;
                    }
                    .btn-hading{
                        display: flex;
                        i{
                            padding: 0px 3px;
                            cursor: pointer;
                        }
                    }
                }
            }
        }
        .ui_title{
            position: absolute;
            bottom: 10px;
            right: 10px;
            color: #fff;
            font-size: 13px;
        }
    }
}