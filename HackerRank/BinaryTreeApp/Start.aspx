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
        <label for="currency">Key:</label>
        <input id="currency" type="number" min="0" max="100" style="width: 100%;" />

        <button id="textButton_Add" class ="button" >Add new root</button>
        <button id="textButton_Remove" class ="button">Remove root</button>

        <script>
            $("#textButton_Add").click(addKeyEvent);
            $("#textButton_Remove").click(removeKey);
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
