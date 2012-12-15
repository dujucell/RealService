<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ManageAgreements.ascx.cs" Inherits="CustomControls_ManageAgreements" %>
<%@ Register src="AddEditAgreementControl.ascx" tagname="AddEditAgreementControl" tagprefix="uc1" %>
<asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
    <asp:View ID="ViewAgree" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            AllowPaging="True" cssClass="GridViewStyle" GridLines="None"
           AlternatingRowStyle-CssClass="AltRowStyle" EditRowStyle-CssClass="EditRowStyle" HeaderStyle-CssClass="HeaderStyle" 
            PagerStyle-CssClass="PagerStyle" RowStyle-CssClass="RowStyle" SelectedRowStyle-CssClass="SelectedRowStyle"
            DataKeyNames="Agreement_ID" DataSourceID="ObjectDataSource1" 
            onselectedindexchanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button"/>
                <asp:BoundField DataField="Agreement_ID" HeaderText="Agreement_ID" 
                    SortExpression="Agreement_ID" />
                <asp:BoundField DataField="Agreement_Name" HeaderText="Agreement_Name" 
                    SortExpression="Agreement_Name" />
            </Columns>
            <EmptyDataTemplate>
                You do not have any agreement types in the system at this time!!
            </EmptyDataTemplate>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            OldValuesParameterFormatString="original_{0}" 
            SelectMethod="selectAllAgreements" 
            TypeName="RealService2.Business.AgreementManager"></asp:ObjectDataSource>
        <br />
        <br />
        <asp:Button ID="btnNew" runat="server" Text="New Agreement" 
            onclick="btnNew_Click" />
    </asp:View>
    <asp:View ID="ModifyAgree" runat="server">
        <uc1:AddEditAgreementControl ID="AddEditAgreementControl1" runat="server" />
        <asp:Button ID="btnAgree" runat="server" Text="View Agreements" 
            onclick="btnAgree_Click" />
    </asp:View>
</asp:MultiView>
