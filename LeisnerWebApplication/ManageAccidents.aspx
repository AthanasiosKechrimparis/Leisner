﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageAccidents.aspx.cs" Inherits="LeisnerWebApplication.ManageAccidents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            width: 400px;
            height: auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width:auto" border="1";>
            <tr>
                <td class="auto-style3" >
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="DeviceID" OnSelectedIndexChanged="ListView1_SelectedIndexChanged"
            OnSelectedIndexChanging="ListView1_SelectedIndexChanging">
            <LayoutTemplate>
                <table id="itemPlaceholderContainer" runat="server" border="1">
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
                </td>
                <td aria-multiline="False">
                    <asp:Button ID="btn_GetAccidents" runat="server" Text="Get Accidents" />
                    <br />
                    <asp:TextBox ID="txtb_UserID" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_DeleteAccident" runat="server" Text="Delete Accident" />
                    <br />
        <asp:Button ID="btn_Update" runat="server" Text="Update Accident" />
                    
                </td>
                
            </tr>
            <tr>
                <td class="auto-style3"> <br />
                    <asp:RadioButton ID="rBtn_DeviceID" runat="server" GroupName="UpdatePage" />
        <asp:Label ID="Label1" runat="server" Text="DeviceID"></asp:Label>
        <asp:TextBox ID="txtb_DeviceID" runat="server"></asp:TextBox>
        <br />
                     <asp:RadioButton ID="rBtn_Amount" runat="server" GroupName="UpdatePage" />
                     <asp:Label ID="Label3" runat="server" Text="Amount"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtb_Amount" runat="server"></asp:TextBox>
        <br />
                </td>
                <td>
                    <asp:RadioButton ID="rBtn_Date" runat="server" GroupName="UpdatePage" />
       
        <asp:Label ID="Label2" runat="server" Text="Date"></asp:Label>
                </td>
                
            </tr>
            
        </table>
       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
       
        <br />
        <br />
    </div>
    </form>
</body>
</html>
