<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUserPage.aspx.cs" Inherits="LeisnerWebApplication.CreateUserPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbl_Name" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtb_Name" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_Username" runat="server" Text="Username"></asp:Label>
&nbsp;<asp:TextBox ID="txtb_Username" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_Password" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="txtb_Password" runat="server"></asp:TextBox>
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
