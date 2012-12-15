using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RealService2.Business;
using RealService2.Models;

public partial class CustomControls_ManageCountry : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCountry_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
        GridView1.DataBind();
    }

    protected void btnNew_Click(object sender, EventArgs e)
    {
        AddEditCountryControl1.ClearControls();
        MultiView1.ActiveViewIndex = 1;
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        CountryManager mgr = new CountryManager();
        Country obj = new Country();
        obj.Country_ID = (GridView1.SelectedDataKey).Value.ToString();
        obj = mgr.selectCountry(obj);
        AddEditCountryControl1.populateControls(obj);
        MultiView1.ActiveViewIndex = 1;
    }
}
