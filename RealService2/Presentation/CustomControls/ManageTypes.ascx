<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageTypes.ascx.cs" Inherits="CustomControls_ManageTypes" %>
<%@ Register src="AddEditTypeControl.ascx" tagname="AddEditTypeControl" tagprefix="uc1" %>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
<asp:View runat="server" ID="ViewTypes">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        AllowPaging="True" cssClass="GridViewStyle" GridLines="None"
        AlternatingRowStyle-CssClass="AltRowStyle" 
        EditRowStyle-CssClass="EditRowStyle" HeaderStyle-CssClass="HeaderStyle" 
        PagerStyle-CssClass="PagerStyle" RowStyle-CssClass="RowStyle" SelectedRowStyle-CssClass="SelectedRowStyle"
        DataKeyNames="RealType_ID" DataSourceID="ObjectDataSource1" 
        onselectedindexchanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="True" ButtonType="Button"/>
            <asp:BoundField DataField="RealType_ID" HeaderText="Type_ID" 
                SortExpression="RealType_ID" />
            <asp:BoundField DataField="RealType_Name" HeaderText="Type_Name" 
                SortExpression="Type_Name" />
        </Columns>
        <EmptyDataTemplate>
            There are no types in the system at this time!!
        </EmptyDataTemplate>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        OldValuesParameterFormatString="original_{0}" 
        SelectMethod="selectAllRealTypes" 
        TypeName="RealService2.Business.RealTypeManager"></asp:ObjectDataSource>
    <br />
    <br />
    <asp:Button ID="btnNew" runat="server" onclick="btnNew_Click" Text="New Type" />
</asp:View>
<asp:View runat="server" ID="ModifyTypes">
    <uc1:AddEditTypeControl ID="AddEditTypeControl1" runat="server" />
    <asp:Button ID="btnTypes" runat="server" Text="View Types" 
        onclick="btnTypes_Click" />
</asp:View>
</asp:MultiView>
