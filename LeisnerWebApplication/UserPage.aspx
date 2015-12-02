<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserPage.aspx.cs" Inherits="LeisnerWebApplication.UserPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Accidents" />
    </div>
        <div>
            <asp:Button ID="btnCreateAcc" runat="server" Text="Add New Accident" OnClick="btnCreateAcc_Click" />
            <br />
            <asp:Button ID="btn_ManageAccident" runat="server" OnClick="btn_ManageAccident_Click" Text="Manage Accidents" />
            <br />
            <asp:Button ID="btn_Messages" runat="server" Text="Messages" OnClick="btn_Messages_Click" />
        </div>
    </form>
</body>
</html>
