using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace eRent.Helpers
{
    public static class Email
    {
        public class EmailParameters
        {
            public string mailingList { get; set; }
            public string mailSubject { get; set; }
            public string mailBody { get; set; }

            public string mailFrom { get; set; }
            public string smtpClientHost { get; set; }
            public string smtpPort { get; set; }
            public bool useSsl { get; set; }
            public string username { get; set; }
            public string password { get; set; }

            public EmailParameters(string to, string content)
            {
                mailingList = to;
                mailSubject = "eRent poruka";
                mailBody = content;
                mailFrom = "";//email adresa
                smtpClientHost = "smtp.gmail.com";
                smtpPort = "587";
                useSsl = true;
                username = "";//email adresa
                password = "";//passwordd
            }
        }

        public static void SendEmail(EmailParameters parameters)
        {
            try
            {
                System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
                message.To.Add(parameters.mailingList);
                message.From = new System.Net.Mail.MailAddress(parameters.mailFrom);
                message.Priority = System.Net.Mail.MailPriority.High;
                message.Subject = parameters.mailSubject;
                message.Body = parameters.mailBody;
                message.IsBodyHtml = false;


                using (var smtp = new SmtpClient(parameters.smtpClientHost))
                {
                    var credential = new NetworkCredential
                    {
                        UserName = parameters.username,  // replace with valid value
                        Password = parameters.password  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Port = Convert.ToInt32(parameters.smtpPort);
                    smtp.EnableSsl = parameters.useSsl;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Send(message);

                    //DISPOSE EVERYTHING
                    smtp.Timeout = 2;
                    message.Dispose();
                    smtp.Dispose();

                }
                return;
            }
            catch (Exception e)
            {

            }

        }
    }
}
