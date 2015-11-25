<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertAccidentPage.aspx.cs" Inherits="LeisnerWebApplication.InsertAccidentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title></title>
        <style type="text/css">
   .inlineBlock { display: inline-block;
            margin-left: 0px;
        }
            .auto-style1 {
                font-weight: bold;
            }
            body{
                background-image: url("Lejsner Main2.jpeg");
    background-color: #cccccc;
            }
        </style>
</head>
<body>
    <h1>Register Accident</h1>
    <p>&nbsp;</p>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server"  CssClass="inlineBlock" Width="500px" Height="270px">
             <strong>Enter Device ID :&nbsp;</strong> 
        <asp:TextBox ID="txtDevice" runat="server"></asp:TextBox>
        <br />
        <br />
             <div>
            <strong>Choose an Amount :</strong>
            <asp:RadioButtonList ID="rdlAmount" runat="server" style="font-weight: 700">
                <asp:ListItem Text="Small" Value="0"></asp:ListItem>
                <asp:ListItem Text="Medium" Value="1"></asp:ListItem>
                <asp:ListItem Text="Big" Value="2"></asp:ListItem>
                <asp:ListItem Value="3">Nothing</asp:ListItem>
            </asp:RadioButtonList>
            <br />
                <br />
        </div>
        </asp:Panel>
         <asp:Panel ID="Panel2" runat="server"  CssClass="inlineBlock" Width="550px" Height="270px">
             <div>
            <strong>Choose Date and Time :
        <br />
            <asp:RadioButtonList ID="rdbListDate" runat="server" AutoPostBack="True" Height="16px" RepeatDirection="Horizontal" Width="384px" OnSelectedIndexChanged="rdbListDate_SelectedIndexChanged">
                <asp:ListItem Value="0">Current Date</asp:ListItem>
                <asp:ListItem Value="1">Custom Date</asp:ListItem>
            </asp:RadioButtonList>
        </strong>
                 <div>

                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Panel ID="Panel4" runat="server" Height="95px" style="margin-left: 204px" Width="300px">
                         <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" DayNameFormat="Shortest" Font-Names="Times New Roman" Font-Size="10pt" ForeColor="Black" Height="16px" NextPrevFormat="FullMonth" TitleFormat="Month" Width="279px">
                             <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" ForeColor="#333333" Height="10pt" />
                             <DayStyle Width="14%" />
                             <NextPrevStyle Font-Size="8pt" ForeColor="White" />
                             <OtherMonthDayStyle ForeColor="#999999" />
                             <SelectedDayStyle BackColor="#CC3333" ForeColor="White" />
                             <SelectorStyle BackColor="#CCCCCC" Font-Bold="True" Font-Names="Verdana" Font-Size="8pt" ForeColor="#333333" Width="1%" />
                             <TitleStyle BackColor="Black" Font-Bold="True" Font-Size="13pt" ForeColor="White" Height="14pt" />
                             <TodayDayStyle BackColor="#CCCC99" />
                         </asp:Calendar>
                         <br />
                         <asp:TextBox ID="txtHour" runat="server" CssClass="auto-style1">Hour</asp:TextBox>
                         <br />
                         <strong>&nbsp;and </strong>
                         <br />
                         <asp:TextBox ID="txtMinute" runat="server" CssClass="auto-style1" Height="22px">Minutes</asp:TextBox>
                         <br />
                         <br />
                     </asp:Panel>
                 </div>
                   <div>
                       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                 </div>
        </div>
         </asp:Panel>
    </div>
        <div>
            <asp:Panel ID="Panel3" runat="server" Width="550px" Height="234px">
                 <div>
            <strong>Insert Drinks before sleep :</strong>
                     <br />
                     <br />
            <asp:TextBox ID="txtdrink" runat="server" CssClass="auto-style1"></asp:TextBox>
            <br />
            <br />
        </div>
        <div>

            <strong>Time went to Sleep :&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <br />
            </strong>
            &nbsp;<asp:TextBox ID="txttimeSleep" runat="server" CssClass="auto-style1">Hour</asp:TextBox>
&nbsp; and&nbsp;
            <asp:TextBox ID="txtminutesleep" runat="server" CssClass="auto-style1">Minutes</asp:TextBox>
            <br />
            <br />
        </div>
        <div>
            <strong>Toilet time before Sleep :<br /> </strong>&nbsp;
            <br />
            <asp:TextBox ID="txthoursToilet" runat="server" CssClass="auto-style1">Hours</asp:TextBox>
&nbsp; and&nbsp;
            <asp:TextBox ID="txtminutesToilet" runat="server" CssClass="auto-style1">Minutes</asp:TextBox>
            <br />
            <br />
        </div>
        <div>
            <strong>Toilet Visit during the night :</strong>
            <asp:RadioButtonList ID="rdToiletVisit" runat="server" style="font-weight: 700" RepeatDirection="Horizontal">
                <asp:ListItem Text="0" Value="0"></asp:ListItem>
                <asp:ListItem Text="1" Value="1"></asp:ListItem>
                <asp:ListItem Text="2" Value="2"></asp:ListItem>
                <asp:ListItem Text="3" Value="3"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
        </div>
            </asp:Panel>
        </div>
        <div>
        </div>
                <div>
                     <br />
                     <br />
                     <br />
                     <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" style="font-weight: 700"  />
        </div>
    </form>
</body>
</html>
