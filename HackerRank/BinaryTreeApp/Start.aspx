<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Start.aspx.cs" Inherits="BinaryTreeApp.Start" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
 
    <link rel="stylesheet" href="Kendo/styles/kendo.common.min.css" />
    <link rel="stylesheet" href="Kendo/styles/kendo.default.min.css" />
    <script src="Kendo/js/jquery.min.js"></script>
    <script src="Kendo/js/kendo.all.min.js"></script>
    <link href="Style.css" rel="stylesheet" />
    <script src="Js/events.js"></script>
    <script src="Js/bst.js"></script>
</head>
<body>
        <label for="currency" class=".label">Key:</label>
        <input id="currency" type="number" min="-1000" max="1000" />

        <button id="textButton_Add" class ="button" >Add new root</button>
        <button id="textButton_Remove" class ="button">Remove root</button>
        <label for="randomNumbers" class=".label">Insert random numbers:</label>
        <input id="randomNumbers" type="number" min="1" max="1024" />

        <button id="textButton_Random" class ="button" >Add</button>
        <button id="textButton_Refresh" class ="button">Refresh</button>
        <script>
            $("#textButton_Add").click(addKeyEvent);
            $("#textButton_Remove").click(removeKeyEvent);
            $("#textButton_Random").click(randomsEvent);
            $("#textButton_Refresh").click(refreshEvent);
            $(document).ready(documentReady);
            

        </script>

        <div id="example">
            <div id="diagram">
            </div>
            <script>               
                $(document).bind("kendo:skinChange", createDiagram);
            </script>

        </div>
    


</body>
</html>
