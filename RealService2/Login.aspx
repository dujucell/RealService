<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Presentation/AdminPanel.aspx">Admin Panel</asp:LinkButton>
        <hr />
        <asp:Login runat="server" DestinationPageUrl="~/Presentation/AdminPanel.aspx">
        </asp:Login>
        <hr />
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" OnSendingMail="PasswordRecovery1_SendingMail">
            <MailDefinition BodyFileName="~/Html Emails/password.html" IsBodyHtml="True" Priority="High"
                Subject="Your Real Report Password!!">
            </MailDefinition>
        </asp:PasswordRecovery>
        <hr />
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" OnSendingMail="CreateUserWizard1_SendingMail" ContinueDestinationPageUrl="~/Presentation/AdminPanel.aspx"
            OnCreatedUser="CreateUserWizard1_CreatedUser">
            <MailDefinition BodyFileName="~/Html Emails/Sign_up.html" Subject="Welcome to RealReport, Your Real Estate Solution">
            </MailDefinition>
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                </asp:CompleteWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </div>
    </form>
</body>
</html>
