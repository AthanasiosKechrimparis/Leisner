<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertAccidentPage.aspx.cs" Inherits="LeisnerWebApplication.InsertAccidentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Enter Accident</h1>
    <form id="form1" runat="server">
    <div>   
        <strong>Enter Device ID :&nbsp;</strong> 
        <asp:TextBox ID="txtDevice" runat="server"></asp:TextBox>
        <br />
        <br />
    </div>
        <div>
            <strong>Choose an Amount :</strong>
            <asp:RadioButtonList ID="rdlAmount" runat="server" style="font-weight: 700" OnSelectedIndexChanged="rdlAmount_SelectedIndexChanged">
                <asp:ListItem Text="Small" Value="0"></asp:ListItem>
                <asp:ListItem Text="Medium" Value="1"></asp:ListItem>
                <asp:ListItem Text="Big" Value="2"></asp:ListItem>
                <asp:ListItem Value="3">Nothing</asp:ListItem>
            </asp:RadioButtonList>
            <br />
                <br />
        </div>
        <div>
            <strong>Choose Date and Time :
        <br />
            <asp:RadioButtonList ID="rdbListDate" runat="server" AutoPostBack="True" Height="16px" RepeatDirection="Horizontal" Width="384px">
                <asp:ListItem Value="0">Current Date</asp:ListItem>
                <asp:ListItem Value="1">Custom Date</asp:ListItem>
            </asp:RadioButtonList>
        </strong>
        </div>
        <div>

            &nbsp;

            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="23px" Width="114px" SelectionMode="DayWeekMonth">
                <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                <WeekendDayStyle BackColor="#CCCCFF" />
            </asp:Calendar>
            <br />
            &nbsp;<asp:TextBox ID="txtHour" runat="server" AutoPostBack="True">Hour</asp:TextBox>
&nbsp;&nbsp; <strong>&nbsp;and</strong>&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtMinute" runat="server" AutoPostBack="True">Minutes</asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
        </div>
        <div>
            <strong>Insert Drinks before sleep :</strong>
            <asp:TextBox ID="txtdrink" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <div>

            <strong>Time went to Sleep :&nbsp;</strong>
            <asp:TextBox ID="txttimeSleep" runat="server" CssClass="auto-style1">Hour</asp:TextBox>
&nbsp; and&nbsp;
            <asp:TextBox ID="txtminutesleep" runat="server" CssClass="auto-style1">Minutes</asp:TextBox>
            <br />
            <br />
        </div>
        <div>

            <strong>Toilet time before Sleep :</strong>&nbsp;
            <asp:TextBox ID="txthoursToilet" runat="server" CssClass="auto-style1">Hours</asp:TextBox>
&nbsp; and&nbsp;
            <asp:TextBox ID="txtminutesToilet" runat="server" CssClass="auto-style1">Minutes</asp:TextBox>
            <br />
            <br />
        </div>
        <div>
            <strong>Toilet Visit :</strong>
            <asp:RadioButtonList ID="rdToiletVisit" runat="server" style="font-weight: 700">
                <asp:ListItem Text="1" Value="0"></asp:ListItem>
                <asp:ListItem Text="2" Value="1"></asp:ListItem>
                <asp:ListItem Text="3" Value="2"></asp:ListItem>
            </asp:RadioButtonList>
            <br />
        </div>
        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" style="font-weight: 700" />
    </form>
</body>
</html>
