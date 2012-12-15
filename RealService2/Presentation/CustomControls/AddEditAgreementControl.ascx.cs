using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using RealService2.Models;
using RealService2.Business;

public partial class CustomControls_AddEditAgreementControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = CustomErrors.EMPTY_STRING;
    }

    [Category("Misc")]
    public void populateControls(Agreement obj)
    {
        Session.Remove("Flag");
        Session.Add("Flag", "Edit");
        btnOpt.Text = "Modify Agreement";
        btnDelete.Enabled = true;
        txtID.Text = obj.Agreement_ID;
        txtName.Text = obj.Agreement_Name;
    }

    [Category("Misc")]
    public void ClearControls()
    {
        Session.Remove("Flag");
        Session.Add("Flag", "New");
        btnDelete.Enabled = false;
        btnOpt.Text = "Insert Agreement";
        txtID.Text = CustomErrors.EMPTY_STRING;
        txtName.Text = CustomErrors.EMPTY_STRING;
    }

    protected void btnOpt_Click(object sender, EventArgs e)
    {
        try
        {
            Agreement obj = this.CaptureData();

            AgreementManager mgr = new AgreementManager();

            if ((string)Session["Flag"] == "New")
            {
                lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.insertAgreement(obj);
                ClearControls();
            }
            else
            {
                lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.updateAgreement(obj);
            }
        }
        catch (Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }

    protected Agreement CaptureData()
    {
        Agreement obj = new Agreement();
        obj.Agreement_ID = txtID.Text.Trim();
        obj.Agreement_Name = txtName.Text.Trim();
        return obj;
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        try
        {
            AgreementManager mgr = new AgreementManager();
            Agreement obj = new Agreement();
            obj.Agreement_ID = txtID.Text.Trim();
            lblError.Text = CustomErrors.CHANGES_ACCEDTED_STATUS + mgr.deleteAgreement(obj);
            ClearControls();
        }
        catch(Exception ex)
        {
            lblError.Text = ex.Message;
        }
    }
}
