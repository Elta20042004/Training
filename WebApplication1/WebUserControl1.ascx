<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="WebApplication1.WebUserControl1" %>

<asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource"></asp:GridView>

<asp:SqlDataSource ID="SqlDataSource" runat="server"
    ConnectionString="Data Source=HOME-PC\SQLEXPRESS;Initial Catalog=Books;User ID=sa;Password=p@ssword1"
    SelectCommand="Select BookSold, Profit from [MyView] where StoreId = @stId">

    <SelectParameters>
        <asp:SessionParameter SessionField="stId" Name="stId"/>
    </SelectParameters>

</asp:SqlDataSource>





<%--create view MyView as
Select Max (st.Name) as 'Name of shop',
COUNT(s.BookId) as 'Sale',
sum(b.Price) as 'Profit'
from Sales s
INNER JOIN Boooks b ON (b.ID = s.BookID)
INNER JOIN Stores st ON (st.ID = s.StoreID)
GROUP BY s.StoreID--%>
