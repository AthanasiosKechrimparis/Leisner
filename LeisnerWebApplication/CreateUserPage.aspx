﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUserPage.aspx.cs" Inherits="LeisnerWebApplication.CreateUserPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <asp:Label ID="Label2" runat="server" Text="UserType"></asp:Label>
&nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Width="123px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Choose User type"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;&nbsp;
    <br />
        <asp:Label ID="lbl_Name" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtb_Name" runat="server" style="margin-top: 4px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtb_Name" ErrorMessage="Please enter Name"></asp:RequiredFieldValidator>
        <br />
                <asp:Label ID="Label8" runat="server" Text="Birthd"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtb_Birthday" runat="server" style="margin-left: 0px"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_Username" runat="server" Text="Username"></asp:Label>
&nbsp;<asp:TextBox ID="txtb_Username" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtb_Username" ErrorMessage="Please enter Username"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lbl_Password" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="txtb_Password" runat="server" style="margin-left: 0px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Please enter Password"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="lbl_Device" runat="server" Text="Device"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtb_Device" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_Create" runat="server" OnClick="btn_Create_Click" Text="Create" />
    
    </div>
    </form>
</body>
</html>
