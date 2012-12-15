using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RealService2.Business;
using RealService2.Models;

public partial class CustomControls_ManageAgreements : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }

    protected void btnAgree_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        GridView1.DataBind();
    }

    protected void btnNew_Click(object sender, EventArgs e)
    {
        AddEditAgreementControl1.ClearControls();
        MultiView1.ActiveViewIndex = 1;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        AgreementManager mgr = new AgreementManager();
        Agreement obj = new Agreement();
        obj.Agreement_ID = (GridView1.SelectedDataKey).Value.ToString();
        obj = mgr.selectAgreement(obj);
        AddEditAgreementControl1.populateControls(obj);
        MultiView1.ActiveViewIndex = 1;
    }
}
