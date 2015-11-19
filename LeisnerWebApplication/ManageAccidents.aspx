<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageAccidents.aspx.cs" Inherits="LeisnerWebApplication.ManageAccidents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="DeviceID" OnSelectedIndexChanged="ListView1_SelectedIndexChanged"
            OnSelectedIndexChanging="ListView1_SelectedIndexChanging">
            <LayoutTemplate>
                <table id="itemPlaceholderContainer" runat="server" >
                    <tr id="Tr1" runat="server">
                        <th>Select
                        </th>
                        <th id="Th1" runat="server">DeviceNr
                        </th>
                        <th id="Th2" runat="server">Date
                        </th>
                        <th id="Th3" runat="server">Amount
                        </th>
                    </tr>
                    <tr id="itemPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
               <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:LinkButton ID="lnkSelect" Text="Select" CommandName="Select" runat="server" />
                    </td>
                    <td>
                        <asp:Label ID="DeviceNrLabel" runat="server" Text='<%# Eval("deviceID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DateLabel" runat="server" Text='<%# Eval("timeofAccident") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AmountLabel" runat="server" Text='<%# Eval("amount") %>' />
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="DeviceID"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Date"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Amount"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Update" />
        <br />
    </div>
    </form>
</body>
</html>
