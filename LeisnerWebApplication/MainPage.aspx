<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="LeisnerWebApplication.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lbl_Username" runat="server" Text="Username"></asp:Label>
&nbsp;<asp:TextBox ID="txtb_Username" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lbl_Password" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="txtb_Password" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btn_Login" runat="server" OnClick="btn_Login_Click" Text="Login" />
    
    </div>
    </form>
</body>
</html>
