using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RealService2.Models;
using RealService2.Business;

public partial class CustomControls_ManageLocations : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLocation_Click(object sender, EventArgs e)
    {
        GridView1.DataBind();
        MultiView1.ActiveViewIndex = 0;
    }

    protected void btnNew_Click(object sender, EventArgs e)
    {
        AddEditLocationControl1.ClearControls();
        MultiView1.ActiveViewIndex = 1;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        LocationManager mgr = new LocationManager();
        Location obj = new Location();
        obj.Location_ID = (GridView1.SelectedDataKey.Value).ToString();
        obj= mgr.selectLocation(obj);
        AddEditLocationControl1.populateControls(obj);
        MultiView1.ActiveViewIndex = 1;
    }
}
