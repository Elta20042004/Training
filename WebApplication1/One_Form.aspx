<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="One_Form.aspx.cs" 
    Inherits="WebApplication1.One_Form" 
    EnableEventValidation="false" %>

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
            <asp:GridView ID="UsersGridView"
                DataSourceID="Authors"
                AutoGenerateColumns="true"
                EmptyDataText="No data available."
                AllowSorting="true"
                runat="server"
                OnRowDataBound="UsersGridView_RowDataBound"
                OnSelectedIndexChanged="UsersGridView_SelectedIndexChanged"
                CssClass="table table-hover"                
                >                         
            
            </asp:GridView>

            <asp:SqlDataSource ID="Authors"
                SelectCommand="Select  [Name], [Age] from [Authors]"
                ConnectionString="Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=Books;User ID=sa;Password=p@ssword1"
                runat="server" />
        </div>
    </form>
</body>
</html>
