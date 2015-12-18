using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Mail;
using System.Net.Mail;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    private void AttachementBody(DateTime startTime, DateTime endTime, string fileName, string dirPath)
    {
        string schLocation = "";
        string schSubject = "your subject";
        string schDescription = "";
        System.DateTime schBeginDate = Convert.ToDateTime(startTime);
        System.DateTime schEndDate = Convert.ToDateTime(endTime);
        String[] contents = { "BEGIN:VCALENDAR",
        "PRODID:-//Flo Inc.//FloSoft//EN",
        "BEGIN:VEVENT",
        "DTSTART:" + schBeginDate.ToUniversalTime().ToString("yyyyMMdd\\THHmmss\\Z"), 
        "DTEND:" + schEndDate.ToUniversalTime().ToString("yyyyMMdd\\THHmmss\\Z"), 
        "LOCATION:" + schLocation, 
        "DESCRIPTION;ENCODING=QUOTED-PRINTABLE:" + schDescription,
        "SUMMARY:" + schSubject, "PRIORITY:3", 
        "END:VEVENT", "END:VCALENDAR" };       
        System.IO.DirectoryInfo dr = new DirectoryInfo(dirPath);
        if (!dr.Exists)
        {
            dr.Create();
        }
        System.IO.File.WriteAllLines(dirPath + "\\" + fileName, contents);
    }
    protected void btnClick_Click(object sender, EventArgs e)
    {
        System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage("you@yourcompany.com", "user@hotmail.com");
        SmtpClient client = new SmtpClient();
        client.Port = 25;
        client.DeliveryMethod = SmtpDeliveryMethod.Network;
        client.UseDefaultCredentials = false;
        client.Host = "smtp.gmail.com";
        mail.Subject = txtSubject.Text;
        mail.Body = txtBody.Text;
        string fileName="myIcs.ics";
        DateTime schBeginDate=DateTime.Now.AddDays(1);
        DateTime schEndDate=DateTime.Now.AddDays(4);
        string dirPath = "your path here";
        AttachementBody(schBeginDate, schEndDate, fileName, dirPath);        
        Attachment attach = new Attachment(dirPath+"\\"+fileName);
        mail.Attachments.Add(attach);
        client.Send(mail);
    }
}