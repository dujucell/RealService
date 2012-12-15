using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using RealService2.Models;
using RealService2.Business;

public partial class CustomControls_AddEditTypeControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = CustomErrors.EMPTY_STRING;
    }

    [Category("Misc")]
    public void populateControls(RealType obj)
    {
        Session.Remove("Flag");
        Session.Add("Flag", "Edit");
        btnOpt.Text = "Modify Agreement";
        btnDelete.Enabled = true;
        txtID.Text = obj.RealType_ID;
        txtName.Text = obj.RealType_Name;
    }

    [Category("Misc")]
    public void ClearControls()
    {
        Session.Remove("Flag");
        Session.Add("Flag", "New");
        btnOpt.Text = "Insert Type";
        btnDelete.Enabled = false;
        txtID.Text = CustomErrors.EMPTY_STRING;
        txtName.Text = CustomErrors.EMPTY_STRING;
    }

    protected void btnOpt_Click(object sender, EventArgs e)
    {
        try
        {
            RealType obj = CaptureData();
            RealTypeManager mgr = new RealTypeManager();

            if ((string)Session["Flag"] == "New")
            {
                lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.insertRealType(obj);
                ClearControls();
            }
            else
            {
                lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.updateRealType(obj);
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

    protected RealType CaptureData()
    {
        RealType obj = new RealType();
        obj.RealType_ID = txtID.Text.Trim();
        obj.RealType_Name = txtName.Text.Trim();

        return obj;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            RealTypeManager mgr = new RealTypeManager();
            RealType obj = new RealType();
            obj.RealType_ID = txtID.Text.Trim();
            lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.deleteRealType(obj);
            ClearControls();
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}
