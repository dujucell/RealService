<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddEditAgreementControl.ascx.cs"
    Inherits="CustomControls_AddEditAgreementControl" %>
<style type="text/css">
    .style1
    {
        width: 28%;
        height: 36px;
    }
    .style2
    {
        width: 515px;
    }
    .style3
    {
        width: 275px;
    }
</style>
<table class="style1">
    <tr>
        <td class="style3">
            Agreement ID
        </td>
        <td class="style2">
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style3">
            Agreement Name
        </td>
        <td class="style2">
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="btnOpt" runat="server" OnClick="btnOpt_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" OnClientClick="return confirm('Are you sure you want to delete this record?');"
                Text="Delete" />
        </td>
    </tr>
</table>
