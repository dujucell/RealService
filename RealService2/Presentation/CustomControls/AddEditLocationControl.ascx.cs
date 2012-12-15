using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using RealService2.Models;
using RealService2.Business;

public partial class CustomControls_AddEditLocationControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ddlCountry.DataBind();
        }
        lblError.Text = CustomErrors.EMPTY_STRING;
    }

    [Category("Misc")]
    public void populateControls(Location obj)
    {
        Session.Remove("Flag");
        Session.Add("Flag", "Edit");
        btnOpt.Text = "Modify Location";
        btnDelete.Enabled = true;
        txtID.Text = obj.Location_ID;
        txtCity.Text = obj.City;
        ddlCountry.SelectedValue = obj.Country_ID;
    }

    [Category("Misc")]
    public void ClearControls()
    {
        Session.Remove("Flag");
        Session.Add("Flag", "New");
        btnOpt.Text = "Insert Location";
        btnDelete.Enabled = false;
        txtID.Text = CustomErrors.EMPTY_STRING;
        txtCity.Text = CustomErrors.EMPTY_STRING;
        ddlCountry.SelectedIndex = -1;
    }

    protected void btnOpt_Click(object sender, EventArgs e)
    {
        try
        {
            Location obj = CaptureData();
            LocationManager mgr = new LocationManager();

            if ((string)Session["Flag"] == "New")
            {
                lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.insertLocation(obj);
                ClearControls();
            }
            else
            {
                lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.updateLocation(obj);
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LocationManager mgr = new LocationManager();
            Location obj = new Location();
            obj.Location_ID = txtID.Text.Trim();
            lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.deleteLocation(obj);
            ClearControls();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

    protected Location CaptureData()
    {
        Location obj = new Location();
        obj.Location_ID = txtID.Text.Trim();
        obj.City = txtCity.Text.Trim();
        obj.Country_ID = ddlCountry.SelectedValue;
        return obj;
    }
}
