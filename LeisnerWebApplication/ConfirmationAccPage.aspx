<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmationAccPage.aspx.cs" Inherits="LeisnerWebApplication.ConfirmationAccPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
   .inlineBlock { display: inline-block;
            margin-left: 0px;
        }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Confirmation of Accident</h1>
    <div>
        <strong>
        <asp:Panel ID="Panel1" runat="server" Height="174px" Width="232px" CssClass="inlineBlock">
            <asp:Label ID="Label1" runat="server" Text="Device ID:"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Amount:"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Time Of Accident:"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Drinks"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Time went to Sleep:"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Time Toilet before Sleep"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Toilet Visits:"></asp:Label>
            <br /> 
        </asp:Panel>
        <asp:Panel ID="Panel2" runat="server" Height="174px" Width="232px" CssClass="inlineBlock">
            <asp:Label ID="lbDevice" runat="server" BackColor="#FF3300"></asp:Label>
            <br /> 
            <asp:Label ID="lbAmount" runat="server" BackColor="#FF3300"></asp:Label>
            <br /> 
            <asp:Label ID="lbTimeAcc" runat="server" BackColor="#FF3300"></asp:Label>
            <br /> 
            <asp:Label ID="lbDrinks" runat="server" BackColor="#FF3300"></asp:Label>
            <br /> 
            <asp:Label ID="lbTimeSleep" runat="server" BackColor="#FF3300"></asp:Label>
            <br /> 
            <asp:Label ID="lbTimeToilet" runat="server" BackColor="#FF3300"></asp:Label>
            <br /> 
            <asp:Label ID="lbToiletVisit" runat="server" BackColor="#FF3300"></asp:Label>
            <br /> 
        </asp:Panel>
        
        </strong>
        
    </div>
    </form>
</body>
</html>
