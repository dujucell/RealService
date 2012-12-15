using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RealService2.Business;
using RealService2.Models;

public partial class CustomControls_ManageAgencies : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAgency_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        GridView1.DataBind();
    }

    protected void btnNew_Click(object sender, EventArgs e)
    {
        AddEditAgencyControl1.ClearControls();
        MultiView1.ActiveViewIndex = 1;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        AgencyManager mgr = new AgencyManager();
        Agency obj = new Agency();
        obj.Agency_ID = (GridView1.SelectedDataKey).Value.ToString();
        obj = mgr.selectAgency(obj);
        AddEditAgencyControl1.populateControls(obj);
        MultiView1.ActiveViewIndex = 1;
    }
}
