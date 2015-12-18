using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Biology_Department_Equipment_Revision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void teacher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            Object selectedTeacher = teacher.SelectedItem;
            String selectedDate = calendar.Value.ToString("dd/MM");
            String selectedTime = time.Value.ToShortTimeString();
            Object selectedYearGroup = yearGroup.SelectedItem;
            Object selectedGroup = groups.SelectedItem;
            Object selectedPeriod = period.SelectedItem;
            Object selectedEquipment = equipment.Text;
            Object selectedHazcards = hazcards.Text;
            Boolean selectedRiskAssessment = riskAssessment.Checked;
            /* (selectedTeacher.ToString() != null && selectedYearGroup.ToString() != null && selectedGroup.ToString() != null && selectedPeriod.ToString() != null && selectedEquipment.ToString() != "Enter Equipment here...." && selectedHazcards.ToString() != "Enter Hazcards here...." && selectedRiskAssessment) */
            if (selectedTeacher != null && selectedYearGroup != null && selectedGroup != null && selectedPeriod.ToString() != null && selectedEquipment.ToString() != "Enter Equipment here...." && selectedHazcards.ToString() != "Enter Hazcards here...." && selectedRiskAssessment)
            {
                /* With thanks to http://stackoverflow.com/questions/19911230/sending-email-through-outlook-2010-via-c-sharp */
                Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
                Microsoft.Office.Interop.Outlook.MailItem mailItem = app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                mailItem.Subject = "Practical Request from " + selectedTeacher.ToString() + " on " + selectedDate;
                mailItem.To = "technicians@gsal.org.uk";
                mailItem.HTMLBody = (@selectedTeacher + " has requested the following equipment on " + selectedDate + " at " + selectedTime + ":<br><h1 style='color:blue'> " + selectedEquipment + "</h1>");
                mailItem.Importance = Outlook.OlImportance.olImportanceHigh;

                StringBuilder str = new StringBuilder();
                str.AppendLine("BEGIN:VCALENDAR");
                str.AppendLine("PRODID:-//Schedule a Meeting");
                str.AppendLine("VERSION:2.0");
                str.AppendLine("METHOD:REQUEST");
                str.AppendLine("BEGIN:VEVENT");
                str.AppendLine(string.Format("DTSTART:{0:yyyyMMddTHHmmssZ}", DateTime.Now.AddMinutes(+10)));
                str.AppendLine(string.Format("DTSTAMP:{0:yyyyMMddTHHmmssZ}", DateTime.UtcNow));
                str.AppendLine(string.Format("DTEND:{0:yyyyMMddTHHmmssZ}", DateTime.Now.AddMinutes(+60)));
                str.AppendLine("LOCATION: GSAL");
                str.AppendLine(string.Format("UID:{0}", Guid.NewGuid()));
                str.AppendLine(string.Format("DESCRIPTION:{0}", mailItem.HTMLBody));
                str.AppendLine(string.Format("X-ALT-DESC;FMTTYPE=text/html:{0}", mailItem.HTMLBody));
                str.AppendLine(string.Format("SUMMARY:{0}", mailItem.Subject));
                str.AppendLine(string.Format("ORGANIZER:MAILTO:{0}", "Null"));

                /* str.AppendLine("BEGIN:VALARM");
                str.AppendLine("TRIGGER:-PT15M");
                str.AppendLine("ACTION:DISPLAY");
                str.AppendLine("DESCRIPTION:Reminder");
                str.AppendLine("END:VALARM"); */
                str.AppendLine("END:VEVENT");
                str.AppendLine("END:VCALENDAR");

                string exeRuntimeDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                System.IO.StreamWriter file = new System.IO.StreamWriter("reminder.ics");
                file.WriteLine(str);

                String whereTheIcsIs = exeRuntimeDirectory += "\reminder.ics";
                MessageBox.Show(whereTheIcsIs);
                mailItem.Attachments.Add(whereTheIcsIs);

                mailItem.Display(true);
            }
            else
            {
                MessageBox.Show(@"You have either left some boxes blank or filled them out incorrectly.
Make sure you have confirmed a risk assessment has been carried out.", "Warning");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
