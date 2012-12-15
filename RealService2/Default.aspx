<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
           Please Login <asp:LoginStatus ID="LoginStatus1" runat="server" />
        </AnonymousTemplate>
        <LoggedInTemplate>       
            You are logged in as <asp:LoginName ID="LoginName1" runat="server" />
        </LoggedInTemplate>
    </asp:LoginView>
    <h3>Please Login to Continue</h3>
    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Presentation/AdminPanel.aspx">Admin Panel</asp:LinkButton>
    </div>
    </form>
</body>
</html>
