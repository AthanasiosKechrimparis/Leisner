<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewAccidents.aspx.cs" Inherits="LeisnerWebApplication.ViewAccidents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="User Id"></asp:Label>
    
    </div>
        <asp:TextBox ID="IDBox" runat="server" Width="129px" OnTextChanged="IDBox_TextChanged"></asp:TextBox>
        <asp:Button ID="Refresh" runat="server" OnClick="Button1_Click" style="margin-left: 26px" Text="Refresh" Height="23px" />
        <br />
        <br />
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
                        <asp:Label ID="AccidentIDLabel" runat="server" Text='<%# Eval("AccidentID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="DateLabel" runat="server" Text='<%# Eval("Date") %>' />
                    </td>
                    <td>
                        <asp:Label ID="AmountLabel" runat="server" Text='<%# Eval("Amount") %>' />

                    </td>
                    <td>
                        <asp:Label ID="DeviceIDLabel" runat="server" Text='<%# Eval("DeviceID") %>' />
                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
