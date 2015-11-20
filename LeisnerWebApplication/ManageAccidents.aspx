<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageAccidents.aspx.cs" Inherits="LeisnerWebApplication.ManageAccidents" %>

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
    <asp:ListView ID="ListView1" runat="server" DataKeyNames="AccidentID" OnSelectedIndexChanged="ListView1_SelectedIndexChanged"
            OnSelectedIndexChanging="ListView1_SelectedIndexChanging" >
            <LayoutTemplate>
                <table id="itemPlaceholderContainer" runat="server" border="1">
                    <tr id="Tr1" runat="server">
                        <th>Select
                        </th>
                        <th id="Th1" runat="server">AccidentID
                        </th>
                        <th id="Th2" runat="server">Date
                        </th>
                        <th id="Th3" runat="server">Amount
                        </th>
                        <th id="Th4" runat="server">DeviceID
                        </th>
                    </tr>
                    <tr id="itemPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
               <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:LinkButton ID="lnkSelect" Text="Select" CommandName="Select" runat="server" OnClick="SelectAccident" CommandArgument='<%# Eval("AccidentID") %>'/>
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
         <%--<SelectedItemTemplate>
                <tr style="background-color: #336699; color: White;">
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
            </SelectedItemTemplate>--%>
        </asp:ListView>
                </td>
                <td aria-multiline="False">
                    <asp:Button ID="btn_GetAccidents" runat="server" Text="Get Accidents" OnClick="btn_GetAccidents_Click" />
                    <br />
                    <asp:Label ID="Label6" runat="server" Text="UserID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="txtb_UserID" runat="server"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Choose Date"></asp:Label>
                    <asp:TextBox ID="txtb_AccidentDate" runat="server"></asp:TextBox>
                    <br />
                    <asp:Button ID="btn_DeleteAccident" runat="server" Text="Delete Accident" />
                    <br />
        <asp:Button ID="btn_Update" runat="server" Text="Update Accident" OnClick="btn_Update_Click" />
                    
                    <br />
                    <asp:Label ID="Label8" runat="server" Text="AccidentID"></asp:Label>
                    <asp:TextBox ID="txtb_AccidentID" runat="server"></asp:TextBox>
                    
                    <br />
                    <asp:Label ID="lbl_Status" runat="server" Text="Status"></asp:Label>
                    
                </td>
                
            </tr>
            <tr>
                <td class="auto-style3"> <br />
                    <asp:RadioButton ID="rBtn_DeviceID" runat="server" AutoPostBack="True" GroupName="UpdatePage" OnCheckedChanged="rBtn_DeviceID_CheckedChanged" />
        <asp:Label ID="Label1" runat="server" Text="DeviceID"></asp:Label>
        <asp:TextBox ID="txtb_DeviceID" runat="server"></asp:TextBox>
        <br />
                     <asp:RadioButton ID="rBtn_Amount" runat="server" AutoPostBack="True" GroupName="UpdatePage" OnCheckedChanged="rBtn_Amount_CheckedChanged" />
                     <asp:Label ID="Label3" runat="server" Text="Amount"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtb_Amount" runat="server"></asp:TextBox>
        <br />
                </td>
                <td>
                    <asp:RadioButton ID="rBtn_Date" runat="server" AutoPostBack="True" GroupName="UpdatePage" OnCheckedChanged="rBtn_Date_CheckedChanged" />
       
        <asp:Label ID="Label2" runat="server" Text="Date"></asp:Label>
                    <asp:TextBox ID="txtb_Date" runat="server"></asp:TextBox>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Hour"></asp:Label>
                    <asp:TextBox ID="txtb_Hour" runat="server"></asp:TextBox>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label5" runat="server" Text="Minute"></asp:Label>
                    <asp:TextBox ID="txtb_Minute" runat="server"></asp:TextBox>
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
