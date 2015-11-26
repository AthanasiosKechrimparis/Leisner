<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statistics2.aspx.cs" Inherits="BWS_ASP.Default" %><%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .inlineBlock {
            display: inline-block;
            margin-left: 40px;
        }
        .inlineBlock1 {
            display: inline-block;
            margin-left: 20px;
        }
        
        
        .auto-style1 {
            width: 252px;
        }
        .auto-style2 {
            width: 303px;
        }
        .auto-style4 {
            width: 337px;
        }
        .auto-style6 {
            width: 337px;
            height: 33px;
        }
        .auto-style7 {
            height: 33px;
        }
        .auto-style9 {
            width: 358px;
        }
        .auto-style10 {
            width: 358px;
            height: 33px;
        }
        body {
            background-color: #cccccc;
        }
        .auto-style11 {
            width: 252px;
            height: 38px;
        }
        .auto-style12 {
            width: 303px;
            height: 38px;
        }
        .auto-style13 {
            height: 38px;
            width: 374px;
        }
        .auto-style14 {
            width: 252px;
            height: 165px;
        }
        .auto-style15 {
            width: 303px;
            height: 165px;
        }
        .auto-style16 {
            height: 165px;
            width: 374px;
        }
        .auto-style17 {
            width: 374px;
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
            &nbsp;</p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style11">
            <asp:Button ID="GetDataBtn" runat="server" Text="Get Data" OnClick="GetDataBtn_Click" />
                </td>
                <td class="auto-style12">
                    <asp:Label ID="Label1" runat="server" CssClass="inlineBlockTop" Text="Start Date"></asp:Label>
                    <asp:TextBox ID="txtStartDate" CssClass="inlineBlock1" runat="server" AutoPostBack="True"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:Label ID="Label2" runat="server"  Text="End Date"></asp:Label>
                    <asp:TextBox ID="txtEndDate" CssClass="inlineBlock1" runat="server" AutoPostBack="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style14">
                    <asp:Panel ID="Panel1" runat="server" CssClass="inlineBlockTop"  Height="52px">
                        <asp:RadioButtonList ID="RadioButtonList2" CssClass="inlineBlockTop" runat="server" OnSelectedIndexChanged="RadioButtonList2_SelectedIndexChanged">
                            <asp:ListItem Text="One Day" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Multiple Days" Value="1"></asp:ListItem>
                        </asp:RadioButtonList>
                    </asp:Panel>
                </td>
                <td class="auto-style15">
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="100px" NextPrevFormat="ShortMonth" Width="321px" style="margin-right: 6px" SelectedDate="11/25/2015 11:13:22">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                        <DayStyle BackColor="#CCCCCC" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                        <TodayDayStyle BackColor="#999999" ForeColor="White" />
                    </asp:Calendar>
                </td>
                <td class="auto-style16">
                    <asp:Calendar ID="Calendar2" runat="server"  BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="100px" NextPrevFormat="ShortMonth" Width="330px" SelectedDate="11/25/2015 11:13:05" OnSelectionChanged="Calendar2_SelectionChanged">
                        <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                        <DayStyle BackColor="#CCCCCC" />
                        <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                        <OtherMonthDayStyle ForeColor="#999999" />
                        <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                        <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                        <TodayDayStyle BackColor="#999999" ForeColor="White" />
                    </asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
        </table>
        <table style="width:100%;">
            <tr>
                <td class="auto-style9">
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
                <td class="auto-style4">
                    <asp:ListView ID="ListView3" runat="server">
                        <LayoutTemplate>
                <table id="AccidentDetails" runat="server" border="1" style="">
                    <tr id="Tr1" runat="server" style="background-color: #336699; color: White;">
                        
                        <th id="Th1" runat="server">BedTime
                        </th>
                        <th id="Th2" runat="server">ToiletVisit
                        </th>
                        <th id="Th3" runat="server">Drinks

                        </th>
                        
                    </tr>
                    <tr id="itemPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr style="">
                    
                    <td>
                        <asp:Label ID="BedTime" runat="server"  Text='<%# Eval("bedTime") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ToiletVisit" runat="server" Text='<%# Eval("toiletVisit") %>' />
                    </td>
                    <td>
                        <asp:Label ID="Drinks" runat="server" Text='<%# Eval("drinksBeforeBed") %>' />
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
            </tr>
            <tr>
                <td class="auto-style10">
                    </td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td class="auto-style7"></td>
            </tr>
            <tr>
                <td class="auto-style9">
                    <div style="width: 326px">
                    </div>
                </td>
                <td class="auto-style4">
                    <div style="width: 324px">
                    </div>
                </td>
                <td>
                    <div>
                    </div>
                </td>
            </tr>
        </table>
        <p>
                    <asp:Chart ID="Chart1" runat="server" OnLoad="Chart1_Load" Width="1095px" Height="500px" BackColor="Transparent" BackImageTransparentColor="Gray" BorderlineColor="Black" BorderlineWidth="3">
                        <series>
                            <asp:Series ChartArea="ChartArea1" ChartType="Line" Name="BarChart" BorderWidth="2" Color="0, 192, 0" Font="Calibri, 7.8pt">
                            </asp:Series>
                        </series>
                        <chartareas>
                            <asp:ChartArea Name="ChartArea1">
                                <AxisX Interval="1">
                                </AxisX>
                            </asp:ChartArea>
                        </chartareas>
                        <Titles>
                            <asp:Title Name="Graph" Text="Average Results">
                            </asp:Title>
                            <asp:Title Docking="Bottom" Name="Date" Text="Date">
                            </asp:Title>
                            <asp:Title Docking="Left" Name="Result" Text="Accident">

                            </asp:Title>
                        </Titles>
                        <BorderSkin BorderWidth="3" SkinStyle="Emboss" />
                    </asp:Chart>
                </p>
    </form>
</body>
</html>
