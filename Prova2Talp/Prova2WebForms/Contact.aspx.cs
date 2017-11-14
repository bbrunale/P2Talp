using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prova2WebForms
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviaEmail_Click(object sender, EventArgs e)
        {
            SmtpClient cliente = new SmtpClient();
            cliente.Host = "smtp.gmail.com";
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.EnableSsl = true;
            cliente.Port = 587;

            System.Net.NetworkCredential credenciais = new NetworkCredential("b.brunale@gmail.com", "hellnop");
            cliente.Credentials = credenciais;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("b.brunale@gmail.com");
            mail.To.Add(new MailAddress(TxtEmail.Text));
            mail.Body = TxtCorpo.Text;
            mail.Subject = TxtAssunto.Text;
            cliente.Send(mail);
        }
    }
}