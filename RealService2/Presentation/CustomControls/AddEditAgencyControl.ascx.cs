using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using RealService2.Models;
using RealService2.Business;

public partial class CustomControls_AddEditAgencyControl : System.Web.UI.UserControl
{

    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = CustomErrors.EMPTY_STRING;
    }

    [Category("Misc")]
    public void populateControls(Agency obj)
    {
        Session.Remove("Flag");
        Session.Add("Flag", "Edit");
        btnOpt.Text = "Modify Agency";
        btnDelete.Enabled = true;
        txtID.Text = obj.Agency_ID;
        txtName.Text = obj.Agency_Name;
        btnDelete.Enabled = true;
    }

    [Category("Misc")]
    public void ClearControls()
    {
        Session.Remove("Flag");
        Session.Add("Flag", "New");
        btnOpt.Text = "Insert Agency";
        btnDelete.Enabled = false;
        txtID.Text = CustomErrors.EMPTY_STRING;
        txtName.Text = CustomErrors.EMPTY_STRING;
        btnDelete.Enabled = false;
    }

    protected void btnOpt_Click(object sender, EventArgs e)
    {
        try
        {
            Agency obj = CaptureData();

            AgencyManager mgr = new AgencyManager();

            if ((string)Session["Flag"] == "New")
            {
                lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.insertAgency(obj);
                ClearControls();
            }
            else
            {
                lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.updateAgency(obj);
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

    protected Agency CaptureData()
    {
        Agency obj = new Agency();
        obj.Agency_ID = txtID.Text.Trim();
        obj.Agency_Name = txtName.Text.Trim();
        return obj;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            AgencyManager mgr = new AgencyManager();
            Agency obj = new Agency();
            obj.Agency_ID = txtID.Text.Trim();
            lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.deleteAgency(obj);
            ClearControls();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}
