﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace TirdaadSchool.Core.Senders
{
    public class SendEmail
    {
        public static void Send(string To,string Subject,string Body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("amirtirtest@gmail.com", "آموزشگاه تیرداد");
            mail.To.Add(To);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            //System.Net.Mail.Attachment attachment;
            // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            // mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("amirtirtest@gmail.com", "ecdnovxwxuajcjxk");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}