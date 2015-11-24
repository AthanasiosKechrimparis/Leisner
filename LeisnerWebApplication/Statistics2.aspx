<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statistics2.aspx.cs" Inherits="Statistics.Default" %><%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 252px;
        }
        .auto-style2 {
            width: 268px;
        }
        .auto-style3 {
            width: 331px;
        }
        .auto-style4 {
            width: 337px;
        }
        .auto-style5 {
            width: 331px;
            height: 122px;
        }
        .auto-style6 {
            width: 337px;
            height: 122px;
        }
        .auto-style7 {
            height: 122px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="GetDataBtn" runat="server" Text="Get Data" OnClick="GetDataBtn_Click" />
        </p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Text=" Results and Statistics" Value="0"></asp:ListItem>
            <asp:ListItem Text=" Results Only" Value="1"></asp:ListItem>
            <asp:ListItem Text=" Statistics Only" Value="2"></asp:ListItem>
        </asp:RadioButtonList>
                </td>
                <td class="auto-style2">
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                        <asp:ListItem Text="One Day" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Multiple Days" Value="1"></asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3">
                    <asp:ListView ID="ListView1" runat="server" DataKeyNames="Date" OnSelectedIndexChanged="ListView1_SelectedIndexChanged"
            OnSelectedIndexChanging="ListView1_SelectedIndexChanging">
            <LayoutTemplate>
                <table id="AccidentList" runat="server" border="1" style="">
                    <tr id="Tr1" runat="server" style="background-color: #336699; color: White;">
                        
                        <th id="Th1" runat="server">Date
                        </th>
                        <th id="Th3" runat="server">Accidents
                        </th>
                        <th id="Th4" runat="server">Average
                        </th>
                        
                    </tr>
                    <tr id="itemPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr style="">
                    
                    <td>
                        <asp:LinkButton ID="Date" runat="server" CommandName="Date"  OnClick="Method" CommandArgument='<%# Eval("Date") %>'  Text='<%# Eval("Date") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Accidents" runat="server" Text='<%# Eval("AccidentsNumber") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Average" runat="server" Text='<%# Eval("Average") %>' />
                    </td>
                    
                </tr>
            </ItemTemplate>
            
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No data.
                        </td>
                    </tr>
                </table>
            </EmptyDataTemplate>
        </asp:ListView>
                </td>
                <td class="auto-style4">
                    <asp:ListView ID="ListView2" DataKeyNames="AccidentID" runat="server">
                    <LayoutTemplate>
                <table id="AccidentsOfDay" runat="server" border="1" style="">
                    <tr id="Tr1" runat="server" style="background-color: #336699; color: White;">
                        
                        <th id="Th1" runat="server">AccidentID
                        </th>
                        <th id="Th2" runat="server">TimeOfAccident
                        </th>
                        <th id="Th3" runat="server">Accident Size

                        </th>
                        
                    </tr>
                    <tr id="itemPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr style="">
                    
                    <td>
                        <asp:Label ID="AccidentID" runat="server"  Text='<%# Eval("AccidentID") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Time" runat="server" Text='<%# Eval("timeOfAccident") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Size" runat="server" Text='<%# Eval("sizeOfAccident") %>' />
                    </td>
                    
                </tr>
            </ItemTemplate>
           
            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No data.
                        </td>
                    </tr>
                </table>
            </EmptyDataTemplate>
                    </asp:ListView>
                </td>
                <td>
                    <asp:ListBox ID="ListBox3" runat="server" Width="280px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                <td class="auto-style6">
                    <asp:Chart ID="Chart1" runat="server" OnLoad="Chart1_Load" Width="489px">
                        <series>
                            <asp:Series ChartArea="ChartArea1" Name="BarChart">
                            </asp:Series>
                        </series>
                        <chartareas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                            <asp:ChartArea Name="ChartArea2">
                            </asp:ChartArea>
                        </chartareas>
                    </asp:Chart>
                </td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
