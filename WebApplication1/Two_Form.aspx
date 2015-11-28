<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Two_Form.aspx.cs" Inherits="WebApplication1.Two_Form" %>

<%@ Register Src="~/WebUserControl1.ascx" TagPrefix="uc1" TagName="WebUserControl1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
    <asp:Repeater ID="Repeater" runat="server" DataSourceID="SqlDataSource">

        <ItemTemplate>                        
           <asp:Label ID="Label1" runat="server" Text='<%# Eval("ShopName") %>'></asp:Label>
           <uc1:WebUserControl1 runat="server" ID="WebUserControl1" StoreId='<%#Eval("StoreID")%>'/>   
          <%--<asp:Label ID="Label2" runat="server" Text='<%# Eval("BookSold") %>'></asp:Label>
             <asp:Label ID="Label3" runat="server" Text='<%# Eval("Profit") %>'></asp:Label>--%>
          <%--  </br>--%>
        </ItemTemplate>
    </asp:Repeater>
        
        <asp:SqlDataSource ID = "SqlDataSource" runat="server"
            ConnectionString="Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=Books;User ID=sa;Password=p@ssword1"
             SelectCommand="Select * from [MyView]">                     
        </asp:SqlDataSource>
        

    </div>
    </form>
</body>
</html>
