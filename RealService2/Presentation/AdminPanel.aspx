<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdminPanel.aspx.cs" Inherits="AdminPanel" %>

<%@ Register src="~/Presentation/CustomControls/ManageAgencies.ascx" tagname="ManageAgencies" tagprefix="uc1" %>

<%@ Register src="~/Presentation/CustomControls/ManageAgreements.ascx" tagname="ManageAgreements" tagprefix="uc2" %>

<%@ Register src="~/Presentation/CustomControls/ManageCountry.ascx" tagname="ManageCountry" tagprefix="uc3" %>

<%@ Register src="~/Presentation/CustomControls/ManageLocations.ascx" tagname="ManageLocations" tagprefix="uc4" %>

<%@ Register src="~/Presentation/CustomControls/ManageTypes.ascx" tagname="ManageTypes" tagprefix="uc5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="~/App_Themes/GridView/ChromeBlackGridView.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblHits" runat="server" Text=""></asp:Label>
        <br />
        <asp:LoginName ID="LoginName1" runat="server" />
&nbsp;<asp:LoginStatus ID="LoginStatus1" runat="server" 
            onloggingout="LoginStatus1_LoggingOut"  />
        <asp:ChangePassword ID="ChangePassword1" runat="server">
        </asp:ChangePassword>
        <hr />
        <uc1:ManageAgencies ID="ManageAgencies1" runat="server" />
        <hr />
        <uc2:ManageAgreements ID="ManageAgreements1" runat="server" />
        <hr />
        <uc3:ManageCountry ID="ManageCountry1" runat="server" />
        <hr />
        <uc4:ManageLocations ID="ManageLocations1" runat="server" />
        <hr />
        <uc5:ManageTypes ID="ManageTypes1" runat="server" />
        <hr />

    </div>
    </form>
</body>
</html>
