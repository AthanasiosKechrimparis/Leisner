<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="LeisnerWebApplication.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
            width: 301px;
        }
        .auto-style2 {
            width: 300px;
        }
        .auto-style3 {
            height: 23px;
            width: 300px;
        }
        .auto-style4 {
            width: 298px;
        }
        .auto-style5 {
            height: 23px;
            width: 298px;
        }
        .auto-style6 {
            width: 301px;
        }
        .auto-style7 {
            width: 100%;
        }
        .auto-style8 {
            width: 278px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style7">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btn_ManageAcc" runat="server" OnClick="btn_ManageAcc_Click" Text="Manage Accidents" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btn_Statistics" runat="server" OnClick="btn_Statistics_Click" Text="Statistics" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btn_CreateUser" runat="server" OnClick="btn_CreateUser_Click" Text="Create User" />
                </td>
                <td class="auto-style8">

                    <asp:Button ID="btn_Messages" runat="server" Text="Messages" OnClick="btn_Messages_Click" />

                &nbsp;&nbsp;&nbsp;&nbsp;

                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style1"></td>
                <td class="auto-style5"></td>
                <td class="auto-style8">

                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style8">

                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
