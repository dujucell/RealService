<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageAgencies.ascx.cs" Inherits="CustomControls_ManageAgencies" %>
<%@ Register src="AddEditAgencyControl.ascx" tagname="AddEditAgencyControl" tagprefix="uc1" %>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="ViewAgencies" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            AllowPaging="True" cssClass="GridViewStyle" GridLines="None"
            AlternatingRowStyle-CssClass="AltRowStyle" 
            EditRowStyle-CssClass="EditRowStyle" HeaderStyle-CssClass="HeaderStyle" 
            PagerStyle-CssClass="PagerStyle" RowStyle-CssClass="RowStyle" SelectedRowStyle-CssClass="SelectedRowStyle"
            DataKeyNames="Agency_ID" DataSourceID="ObjectDataSource1" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <RowStyle CssClass="RowStyle" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button"/>
                <asp:BoundField DataField="Agency_ID" HeaderText="Agency_ID" 
                    SortExpression="Agency_ID" />
                <asp:BoundField DataField="Agency_Name" HeaderText="Agency_Name" 
                    SortExpression="Agency_Name" />
            </Columns>
            <PagerStyle CssClass="PagerStyle" />
            <EmptyDataTemplate>
                There are no agencies in the system at this time!!
            </EmptyDataTemplate>
            <SelectedRowStyle CssClass="SelectedRowStyle" />
            <HeaderStyle CssClass="HeaderStyle" />
            <EditRowStyle CssClass="EditRowStyle" />
            <AlternatingRowStyle CssClass="AltRowStyle" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            OldValuesParameterFormatString="original_{0}" SelectMethod="selectAllAgencies" 
            TypeName="RealService2.Business.AgencyManager"></asp:ObjectDataSource>
        <br />
        <br />
        <asp:Button ID="btnNew" runat="server" onclick="btnNew_Click" 
            Text="New Agency" />
    </asp:View>
    <asp:View ID="ModifyAgencies" runat="server">
        <uc1:AddEditAgencyControl ID="AddEditAgencyControl1" runat="server" />
        <asp:Button ID="btnAgency" runat="server" Text="View Agencies" 
            onclick="btnAgency_Click" />
    </asp:View>
</asp:MultiView>
