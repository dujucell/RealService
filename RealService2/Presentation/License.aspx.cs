﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RealAsmx;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnLicense_Click(object sender, EventArgs e)
    {
        //ServiceWCFClient client = new ServiceWCFClient();
        RealAsmxSoapClient client = new RealAsmxSoapClient();
        RealLicenseWCF obj = new RealLicenseWCF();
        obj.LicenseNumber = TextBox1.Text;
        Session["User"] = client.AuthenticateLicense(obj);
        client.Close();
        if (((Boolean)Session["User"] == true))
        {
            Response.Redirect("~/Presentation/AdminPanel.aspx");
        }
        else
        {
            Response.Redirect("~/Presentation/Expired.aspx");
        }
    }
}