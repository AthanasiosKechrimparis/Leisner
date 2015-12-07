<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReceiveMessagesPage.aspx.cs" Inherits="LeisnerWebApplication.ReceiveMessagesPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Message Show</h1>
      <div>
            <asp:ListView ID="ListView2" DataKeyNames="MessageText" runat="server" >
                    <LayoutTemplate>
                <table id="tbShowMessage" runat="server" border="1" style="">
                    <tr id="Tr1" runat="server" style="background-color: #336699; color: White;">
                        <th id="Th1" runat="server">Name
                        </th>
                          <th id="Th2" runat="server">Tittle
                        </th>
                        <th id="Th3" runat="server">Text
                        </th>  
                        <th id="Th4" runat="server">Send Date
                        </th> 
                    </tr>
                    <tr id="itemPlaceholder" runat="server">
                    </tr>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr style="">  
                    <td>
                        <asp:Label ID="Name" runat="server" Text='<%# Eval("Name") %>' />
                    </td>
                       <td>
                        <asp:Label ID="Tittle" runat="server" Text='<%# Eval("Tittle") %>' />
                    </td>
                    <td>
                        <asp:Label ID="MessageText" runat="server" Text='<%# Eval("MessageText") %>' />
                    </td>
                       <td>
                        <asp:Label ID="SendDate" runat="server" Text='<%# Eval("SendDate") %>' />
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
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
        </div>
        <div>
            <asp:Button ID="btnShow" runat="server" Text="Show Messages" OnClick="btnShow_Click" />
        </div>
        <div>
            <asp:DropDownList ID="ddList" runat="server" DataSourceID="SqlDataSource1" DataTextField="UserName" DataValueField="UserName"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
