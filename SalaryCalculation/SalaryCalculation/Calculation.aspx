<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculation.aspx.cs" Inherits="SalaryCalculation.Calculation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlMonth" runat="server" AutoPostBack="True" OnSelectedIndexChanged="GodMonth_SelectedIndexChanged">               
                <asp:ListItem Value="1">Январь</asp:ListItem>
                <asp:ListItem Value="2">Февраль</asp:ListItem>
                <asp:ListItem Value="3">Март</asp:ListItem>
                <asp:ListItem Value="4">Апрель</asp:ListItem>     
                <asp:ListItem Value="5">Май</asp:ListItem>
                <asp:ListItem Value="6">Июнь</asp:ListItem>
                <asp:ListItem Value="7">Июль</asp:ListItem>
                <asp:ListItem Value="8">Август</asp:ListItem>
                <asp:ListItem Value="9">Сентябрь</asp:ListItem>
                <asp:ListItem Value="10">Октябрь</asp:ListItem>
                <asp:ListItem Value="11">Ноябрь</asp:ListItem>
                <asp:ListItem Value="12">Декабрь</asp:ListItem>             
            </asp:DropDownList>

            <asp:Label ID="God" runat="server" Text="God">Введите текущий год:</asp:Label>

            <asp:DropDownList ID="ddlGod" runat="server" AutoPostBack="True" OnSelectedIndexChanged="GodMonth_SelectedIndexChanged">               
                <asp:ListItem Value="2015">2015</asp:ListItem>
                <asp:ListItem Value="2016">2016</asp:ListItem>
                <asp:ListItem Value="2017">2017</asp:ListItem>
                <asp:ListItem Value="2018">2018</asp:ListItem>     
                <asp:ListItem Value="2019">2019</asp:ListItem>
                <asp:ListItem Value="2020">2020</asp:ListItem>             
            </asp:DropDownList>

            <asp:Label ID="Label4" runat="server" Text="Label">Ваша почасовая оплата: </asp:Label>
            <asp:DropDownList ID="ddlBaseSellary" runat="server" DataTextField="Value" DataValueField="Key" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            &nbsp;<asp:ListView ID="lvDayTimings" runat="server" AutoPostBack="True" OnItemDataBound="DayTimings_OnItemDataBound">
                <LayoutTemplate>
                    <table cellpadding="2" width="400px" border="0">
                        <tr class="bgcolor" runat="server">
                            <th runat="server"></th>
                            <th runat="server"></th>
                            <th runat="server"></th>
                        </tr>
                        <tr id="itemPlaceholder" runat="server"></tr>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr runat="server">
                        <td>
                            <asp:Label ID="Day" runat="server" Text='<%#Eval("Day") %>' />
                        </td>
                        <td>
                            <asp:Label ID="LabelStartHour" runat="server" Text='<%#Eval("StartHour") %>' Visible="false" />
                            <asp:Label ID="LabelStartMinute" runat="server" Text='<%#Eval("StartMinute") %>' Visible="false" />
                            <asp:Label ID="LabelEndHour" runat="server" Text='<%#Eval("EndHour") %>' Visible="false" />
                            <asp:Label ID="LabelEndMinute" runat="server" Text='<%#Eval("EndMinute") %>' Visible="false" />
                            <asp:Label ID="LabelHoliday" runat="server" Text='<%#Eval("DayKind") %>' Visible="false" />
                            <asp:DropDownList ID="StartHour" runat="server" DataTextField="Value" DataValueField="Key">
                            </asp:DropDownList>
                            <asp:Label ID="Label1" runat="server" Text=':' />
                            <asp:DropDownList ID="StartMinute" runat="server" DataTextField="Value" DataValueField="Key">
                            </asp:DropDownList>
                            <asp:Label ID="Label3" runat="server" Text='-' />
                            <asp:DropDownList ID="EndHour" runat="server" DataTextField="Value" DataValueField="Key">
                            </asp:DropDownList>
                            <asp:Label ID="Label2" runat="server" Text=':' />
                            <asp:DropDownList ID="EndMinute" runat="server" DataTextField="Value" DataValueField="Key">
                            </asp:DropDownList>
                            <asp:DropDownList ID="Holidays" runat="server" DataTextField="Value" DataValueField="Key">
                            </asp:DropDownList>

                        </td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>

        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Calculation_Click" Text="Calculate" Height="25px" Width="130px" />
        <asp:Label  runat="server" Text="Label">Ваша зарплата:  </asp:Label>
        <asp:Label ID="lblRezult" runat="server"></asp:Label>

    </form>
</body>
</html>
