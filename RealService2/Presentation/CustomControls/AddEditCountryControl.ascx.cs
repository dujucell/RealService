using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using RealService2.Models;
using RealService2.Business;

public partial class CustomControls_AddEditCountryControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = CustomErrors.EMPTY_STRING;
    }

    [Category("Misc")]
    public void populateControls(Country obj)
    {
        Session.Remove("Flag");
        Session.Add("Flag", "Edit");
        btnOpt.Text = "Modify Country";
        btnDelete.Enabled = true;
        txtID.Text = obj.Country_ID;
        txtName.Text = obj.Country_Name;
        btnDelete.Enabled = true;
    }

    [Category("Misc")]
    public void ClearControls()
    {
        Session.Remove("Flag");
        Session.Add("Flag", "New");
        btnOpt.Text = "Insert Country";
        btnDelete.Enabled = false;
        txtID.Text = CustomErrors.EMPTY_STRING;
        txtName.Text = CustomErrors.EMPTY_STRING;
        btnDelete.Enabled = false;
    }

    protected void btnOpt_Click(object sender, EventArgs e)
    {
        try
        {
            Country obj = CaptureData();

            CountryManager mgr = new CountryManager();

            if ((string)Session["Flag"] == "New")
            {
                lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.insertCountry(obj);
                ClearControls();
            }
            else
            {
                lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.updateCountry(obj);
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

    protected Country CaptureData()
    {
         Country obj = new Country();
         obj.Country_ID = txtID.Text.Trim();
         obj.Country_Name = txtName.Text.Trim();
         return obj;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            CountryManager mgr = new CountryManager();
            Country obj = new Country();
            obj.Country_ID = txtID.Text.Trim();
            lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.deleteCountry(obj);
            ClearControls();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}
