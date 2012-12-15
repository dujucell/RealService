using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Web.Security;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblError.Text = CustomErrors.EMPTY_STRING;
    }

    protected void PasswordRecovery1_SendingMail(object sender, MailMessageEventArgs e)
    {
        e.Cancel = true;
        MailMessage message = new MailMessage();
        message.IsBodyHtml = true;
        message.To.Add(e.Message.To.ToString());
        message.From = new MailAddress(Membership.GetUser("root").Email);
        message.Subject = e.Message.Subject;
        message.Body = e.Message.Body;

        try
        {
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.Send(message);
        }
        catch (Exception ex)
        {
            lblError.Text = CustomErrors.ERROR_EMAIL_FAILED;
        }
    }

    public void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        Roles.AddUserToRole(CreateUserWizard1.UserName, "Administrator");
    }

    protected void CreateUserWizard1_SendingMail(Object sender, MailMessageEventArgs e)
    {
        e.Cancel = true;
        MailMessage message = new MailMessage();
        message.From = new MailAddress(Membership.GetUser("root").Email);
        message.IsBodyHtml = true;
        message.To.Add(CreateUserWizard1.Email);
        message.Subject = e.Message.Subject;
        message.Body = e.Message.Body;

        SmtpClient client = new SmtpClient();

        client.EnableSsl = true;

        try
        {
            client.Send(message);
        }
        catch (Exception ex)
        {
            lblError.Text = CustomErrors.ERROR_EMAIL_FAILED;
        }
    }
}