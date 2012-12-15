<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageLocations.ascx.cs" Inherits="CustomControls_ManageLocations" %>
<%@ Register src="AddEditLocationControl.ascx" tagname="AddEditLocationControl" tagprefix="uc1" %>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="ViewLocation" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            AllowPaging="True" cssClass="GridViewStyle" GridLines="None"
            AlternatingRowStyle-CssClass="AltRowStyle" 
            EditRowStyle-CssClass="EditRowStyle" HeaderStyle-CssClass="HeaderStyle" 
            PagerStyle-CssClass="PagerStyle" RowStyle-CssClass="RowStyle" SelectedRowStyle-CssClass="SelectedRowStyle"
            DataKeyNames="Location_ID" DataSourceID="ObjectDataSource1" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <RowStyle CssClass="RowStyle" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button"/>
                <asp:BoundField DataField="Location_ID" HeaderText="Location_ID" 
                    SortExpression="Location_ID" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country_ID" HeaderText="Country_ID" 
                    SortExpression="Country_ID" />
            </Columns>
            <PagerStyle CssClass="PagerStyle" />
            <EmptyDataTemplate>
                There are no Locations in th system at this time
            </EmptyDataTemplate>
            <SelectedRowStyle CssClass="SelectedRowStyle" />
            <HeaderStyle CssClass="HeaderStyle" />
            <EditRowStyle CssClass="EditRowStyle" />
            <AlternatingRowStyle CssClass="AltRowStyle" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            OldValuesParameterFormatString="original_{0}" SelectMethod="selectAllLocations" 
            TypeName="RealService2.Business.LocationManager"></asp:ObjectDataSource>
        <asp:Button ID="btnNew" runat="server" onclick="btnNew_Click" 
            Text="New Location" />
    </asp:View>
    <asp:View ID="ModifyLocation" runat="server">
        <uc1:AddEditLocationControl ID="AddEditLocationControl1" runat="server" />
        <asp:Button ID="btnLocation" runat="server" Text="View Locations" 
            onclick="btnLocation_Click" />
    </asp:View>
</asp:MultiView>
