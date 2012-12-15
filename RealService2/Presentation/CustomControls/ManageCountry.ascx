<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageCountry.ascx.cs" Inherits="CustomControls_ManageCountry" %>
<%@ Register src="AddEditCountryControl.ascx" tagname="AddEditCountryControl" tagprefix="uc1" %>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="ViewCountries" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            AllowPaging="True" cssClass="GridViewStyle" GridLines="None"
            AlternatingRowStyle-CssClass="AltRowStyle" 
            EditRowStyle-CssClass="EditRowStyle" HeaderStyle-CssClass="HeaderStyle" 
            PagerStyle-CssClass="PagerStyle" RowStyle-CssClass="RowStyle" SelectedRowStyle-CssClass="SelectedRowStyle"
            DataKeyNames="Country_ID" DataSourceID="ObjectDataSource1" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" />
                <asp:BoundField DataField="Country_ID" HeaderText="Country_ID" 
                    SortExpression="Country_ID" />
                <asp:BoundField DataField="Country_Name" HeaderText="Country_Name" 
                    SortExpression="Country_Name" />
            </Columns>
            <EmptyDataTemplate>
                There are no countries in the system at this time!!
            </EmptyDataTemplate>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            OldValuesParameterFormatString="original_{0}" SelectMethod="selectAllCountries" 
            TypeName="RealService2.Business.CountryManager"></asp:ObjectDataSource>
        <br />
        <br />
        <asp:Button ID="btnNew" runat="server" onclick="btnNew_Click" 
            Text="New Country" />
    </asp:View>
    <asp:View ID="ModifyCountries" runat="server">
        <uc1:AddEditCountryControl ID="AddEditCountryControl1" runat="server" />
        <asp:Button ID="btnCountry" runat="server" Text="View Countries" 
            onclick="btnCountry_Click" />
    </asp:View>
</asp:MultiView>
