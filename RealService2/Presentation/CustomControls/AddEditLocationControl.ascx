<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddEditLocationControl.ascx.cs"
    Inherits="CustomControls_AddEditLocationControl" %>
<style type="text/css">
    .style3
    {
        width: 25%;
    }
    .style4
    {
        width: 84px;
    }
</style>
<table class="style3">
    <tr>
        <td class="style4">
            Location ID
        </td>
        <td>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
            City
        </td>
        <td>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style4">
            Country
        </td>
        <td>
            <asp:DropDownList ID="ddlCountry" runat="server" DataSourceID="ObjectDataSource1"
                DataTextField="Country_Name" DataValueField="Country_ID">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}"
                SelectMethod="selectAllCountries" 
                TypeName="RealService2.Business.CountryManager"></asp:ObjectDataSource>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="btnOpt" runat="server" Text="" OnClick="btnOpt_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"
                OnClientClick="return confirm('Are you sure you want to delete this record?');" />
        </td>
    </tr>
</table>
