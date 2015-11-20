<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="LeisnerWebApplication.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Button ID="btn_ManageAcc" runat="server" OnClick="btn_ManageAcc_Click" Text="Manage Accidents" />
                </td>
                <td>
                    <asp:Button ID="btn_Statistics" runat="server" OnClick="btn_Statistics_Click" Text="Statistics" />
                </td>
                <td>
                    <asp:Button ID="btn_CreateUser" runat="server" OnClick="btn_CreateUser_Click" Text="Create User" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
