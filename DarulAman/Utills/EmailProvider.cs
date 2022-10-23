using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace DarulAman.Utills
{
    public static class EmailProvider
    {
        public static void Email(string receiverEmail,string emailSubject, string mailBody)//BODY OF EMAIL WITH EMAIL
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("yousafge00@gmail.com");
                message.To.Add(new MailAddress(receiverEmail));
                //message.CC = ;
                message.Subject = emailSubject;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = mailBody;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("yousafge00@gmail.com", "iqra@6543.0");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception) { }
        }
    }
}