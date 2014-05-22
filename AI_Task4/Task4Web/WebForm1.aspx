<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Task4Web.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem Value ="Memory">Memory</asp:ListItem>
        <asp:ListItem Value ="File">File</asp:ListItem>
        <asp:ListItem Value ="DataBase">DataBase</asp:ListItem>
        <asp:ListItem Value ="CustomORM">CustomORM</asp:ListItem>
    </asp:RadioButtonList>
    <p>
        <asp:Label ID="Namelbl" runat="server" Text="Name"></asp:Label>
        &nbsp;<asp:TextBox ID="Name" runat="server"></asp:TextBox>



    </p>
    <p>
        <asp:Label ID="Valuelbl" runat="server" Text="Value"></asp:Label>
        &nbsp;<asp:TextBox ID="Value" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="GetAllButton" runat="server" Text="GetAll" OnClick="GetAllButton_Click" />
        <asp:Button ID="GetByNameButton" runat="server" Text="GetByName" OnClick="GetByNameButton_Click" />
        <asp:Button ID="UpdateButton" runat="server" Text="Update" OnClick="UpdateButton_Click" />
        <asp:Button ID="DeleteButton" runat="server" Text="Delete" OnClick="DeleteButton_Click" />
        <asp:Button ID="AddButton" runat="server" Text="Add" OnClick="AddButton_Click" />
    </p>
    <p>
        <asp:Label ID="Resultlbl" runat="server" Text=""></asp:Label>
    </p>
</asp:Content>
