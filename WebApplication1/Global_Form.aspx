<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Global_Form.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <meta charset="utf-8" />
    <script src="lib/jquery-1.11.3.js"></script>
    <script src="js/MovieApi.js"></script>
    <link href="Css/CSS.css" rel="stylesheet" />
    <link href="lib/bootstrap-3.3.5-dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="lib/bootstrap-3.3.5-dist/js/bootstrap.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ul class="nav nav-pills" role="tablist">
  <li role="presentation" class="active"><a href="One_Form.aspx">Home <span class="badge"></span></a></li>
  <li role="presentation"><a href="Two_Form.aspx">Profile</a></li>
  <li role="presentation"><a href="Three_Form.aspx">Messages <span class="badge"></span></a></li>
</ul>
    </div>
    </form>
</body>
</html>
