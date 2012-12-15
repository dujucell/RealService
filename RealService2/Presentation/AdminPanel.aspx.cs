using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPanel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.checkLicense();
        this.keepCount();
    }

    private void keepCount()
    {
        if (!IsPostBack)
        {
            Int32 count = (Int32)Application["Count"];
            count++;
            Application["Count"] = count;
            lblHits.Text = Application["Count"].ToString() + " Hits for this page";
        }
    }

    private void checkLicense()
    {
        if (Session["User"] == null)
        {
            Response.Redirect("~/Presentation/License.aspx");
        }
        else
        {
            if (((Boolean)Session["User"] == false))
            {
                Response.Redirect("~/Presentation//Expired.aspx");
            }
        }
    }

    protected void LoginStatus1_LoggingOut(object sender, LoginCancelEventArgs e)
    {
        Session["User"] = null;
    }
}