<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Isaev_Andrey_Task6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Исходная валюта:"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 8px" Width="81px">
            <asp:ListItem Value="Ruble">Рубль</asp:ListItem>
            <asp:ListItem Value="Dollar">Доллар</asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="Label2" runat="server" Text="курс к доллару:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 8px" Width="71px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Сумма:"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 15px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Целевая валюта:    "></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server" style="margin-left: 8px" Width="81px">
            <asp:ListItem Value="Ruble">Рубль</asp:ListItem>
            <asp:ListItem Value="Dollar">Доллар</asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:Label ID="Label5" runat="server" Text="курс к доллару:"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" style="margin-left: 8px" Width="71px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Рассчитать" />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Результат расчета"></asp:Label>
    
    </div>
    </form>
</body>
</html>
