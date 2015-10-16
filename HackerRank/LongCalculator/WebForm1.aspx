<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LongCalculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

            <br>
            <asp:Button ID="CE" runat="server" Text="CE" />
            <asp:Button ID="C" runat="server" Text="C" OnClick="C_click"/>
            <asp:Button ID="delete" runat="server" Text="DEL" />          
            <br>
            <asp:Button ID="seven" runat="server" Text="7" OnClick="seven_click" />
            <asp:Button ID="eight" runat="server" Text="8" OnClick="eight_click" />
            <asp:Button ID="nine" runat="server" Text="9" OnClick="nine_click" />
            <asp:Button ID="multiplication" runat="server" Text="*" OnClick="multiplication_click"/>
            <br>
            <asp:Button ID="four" runat="server" Text="4" OnClick="four_click" />
            <asp:Button ID="five" runat="server" Text="5" OnClick="five_click" />
            <asp:Button ID="six" runat="server" Text="6" OnClick="six_click" />
            <asp:Button ID="subtraction" runat="server" Text="-" OnClick="subtraction_click" />
            <br>
            <asp:Button ID="one" runat="server" Text="1" OnClick="one_click" />
            <asp:Button ID="two" runat="server" Text="2" OnClick="two_click" />
            <asp:Button ID="three" runat="server" Text="3" OnClick="three_click" />
            <asp:Button ID="summary" runat="server" Text="+" OnClick="summary_click" />
            <br>
            <asp:Button ID="negatively" runat="server" Text="+/-" />
            <asp:Button ID="zero" runat="server" Text="0" OnClick="zero_click" />
            <asp:Button ID="fraction" runat="server" Text="." />
            <asp:Button ID="result" runat="server" Text="=" OnClick="result_click"/>
            
            

        </div>
    </form>
</body>
</html>
