<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StatisticsPage.aspx.cs" Inherits="LeisnerWebApplication.StatisticsPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    
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
    
    
    </form>
</body>
</html>
