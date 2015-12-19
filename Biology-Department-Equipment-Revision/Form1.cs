using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using Outlook = Microsoft.Office.Interop.Outlook;
using static BDER.Form2;

namespace BDER
{
    public partial class appWindow : Form
    {
        public appWindow()
        {
            InitializeComponent();
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            versionLabel.Text = String.Format("Version {0}", version);
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
            Object selectedYearGroup = yearGroup.SelectedItem;
            Object selectedGroup = groups.SelectedItem;
            Object selectedPeriod = period.SelectedItem;
            Object selectedEquipment = equipment.Text;
            Object selectedHazcards = hazcards.Text;
            Boolean selectedRiskAssessment = riskAssessment.Checked;
            /* (selectedTeacher.ToString() != null && selectedYearGroup.ToString() != null && selectedGroup.ToString() != null && selectedPeriod.ToString() != null && selectedEquipment.ToString() != "Enter Equipment here...." && selectedHazcards.ToString() != "Enter Hazcards here...." && selectedRiskAssessment) */
            if (selectedTeacher != null && selectedYearGroup != null && selectedGroup != null && selectedPeriod.ToString() != null && selectedEquipment.ToString() != null && selectedHazcards.ToString() != null && selectedRiskAssessment)
            {
                /* With thanks to http://stackoverflow.com/questions/19911230/sending-email-through-outlook-2010-via-c-sharp */
                Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
                Microsoft.Office.Interop.Outlook.MailItem mailItem = app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                mailItem.Subject = "Practical Request from " + selectedTeacher.ToString() + " on " + selectedDate;
                mailItem.To = "technicians@gsal.org.uk";
                mailItem.HTMLBody = (@selectedTeacher + " has requested the following equipment on " + selectedDate + " during " + selectedPeriod + ":<br><h1 style='color:blue'> " + selectedEquipment + "</h1><br><br><h3>Sent with QuickPractical a.k.a Biology Department Equipment Requisition</h3>");
                mailItem.Importance = Outlook.OlImportance.olImportanceHigh;

                string theTime = "";
                switch (selectedPeriod.ToString())
                {
                    case "Period 1":
                        theTime = "09:00";
                        break;

                    case "Period 2":
                        theTime = "09:55";
                        break;

                    case "Period 3":
                        theTime = "11:05";
                        break;

                    case "Period 4":
                        theTime = "12:00";
                        break;

                    case "Period 5":
                        theTime = "2:10";
                        break;

                    case "Period 6":
                        theTime = "3:00";
                        break;
                }

                string schLocation = "";
                string schSubject = mailItem.Subject;
                string schDescription = "";
                System.DateTime schBeginDate = Convert.ToDateTime(selectedDate);
                System.DateTime schEndDate = Convert.ToDateTime(selectedDate);
                String[] contents = { "BEGIN:VCALENDAR",
                "PRODID: -//Flo Inc.//FloSoft//EN",
                "BEGIN: VEVENT",
                "DTSTART:" +schBeginDate.ToUniversalTime().ToString("yyyyMMdd\\THHmmss\\Z") + theTime,
                "DTEND:" +schEndDate.ToUniversalTime().ToString("yyyyMMdd\\THHmmss\\Z") + theTime,
                "LOCATION:" +schLocation,
                "DESCRIPTION; ENCODING = QUOTED - PRINTABLE:" +schDescription,
                "SUMMARY:" +schSubject, "PRIORITY: 3",
                "END: VEVENT", "END: VCALENDAR" };

                string exeRuntimeDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

                System.IO.DirectoryInfo dr = new System.IO.DirectoryInfo(exeRuntimeDirectory);
                if (!dr.Exists)
                {
                    dr.Create();
                }
                System.IO.File.WriteAllLines(exeRuntimeDirectory + "\\" +"reminder2.ics", contents);

                String whereTheIcsIs = exeRuntimeDirectory += "\\reminder2.ics";
                mailItem.Attachments.Add(whereTheIcsIs);

                mailItem.Display(true);

                MessageBox.Show("Your request has been sent successfully.");
                System.Windows.Forms.Application.Exit();
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

        private void calendar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            Object selectedTeacher = teacher.SelectedItem;
            String selectedDate = calendar.Value.ToString("dd/MM");
            Object selectedYearGroup = yearGroup.SelectedItem;
            Object selectedGroup = groups.SelectedItem;
            Object selectedPeriod = period.SelectedItem;
            Object selectedEquipment = equipment.Text;
            Object selectedHazcards = hazcards.Text;
            Boolean selectedRiskAssessment = riskAssessment.Checked;

            if (selectedTeacher != null && selectedYearGroup != null && selectedGroup != null && selectedPeriod.ToString() != null && selectedEquipment.ToString() != null && selectedHazcards.ToString() != null && selectedRiskAssessment)
            {
                bool leave = false;

                while (leave != true)
                {
                    Form2 saveWindow = new Form2();
                    saveWindow.ShowDialog();
                    string requestName = ControlID.TextData;

                    MessageBox.Show("Saved the request.");

                    using (StreamWriter sw = File.AppendText(@"history.txt"))
                    {
                        sw.WriteLine("BEGINREQUEST");
                        sw.WriteLine("BEGINNAME");
                        sw.WriteLine(requestName);
                        sw.WriteLine("ENDNAME");
                        sw.WriteLine("BEGINTAGS");
                        sw.WriteLine("ENDTAGS");
                        sw.WriteLine("BEGINDATA");
                        sw.WriteLine(selectedTeacher);
                        sw.WriteLine(selectedDate);
                        sw.WriteLine(selectedYearGroup);
                        sw.WriteLine(selectedGroup);
                        sw.WriteLine(selectedPeriod);
                        sw.WriteLine(selectedEquipment);
                        sw.WriteLine(selectedHazcards);
                        sw.WriteLine(selectedRiskAssessment);
                        sw.WriteLine("ENDDATA");
                        sw.WriteLine("ENDREQUEST");
                    }

                    string path = @"historyPart.txt";
                    System.IO.File.WriteAllText(path, string.Empty);
                    leave = true;
                }

            } else
            {
                MessageBox.Show("Before you can save, you must complete the form.", "Cannot continue");
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            /* Read the file in, line by line */
            string[] lines = System.IO.File.ReadAllLines(@"history.txt");
            var tagList = new List<string>();
            int counter = 0;
            string experimentName = "";

            while (counter < lines.Length)
            {
                /* Look for "BEGINNAME" */
                if (lines[counter] == "BEGINNAME")
                {
                    experimentName = lines[counter + 1];
                }

                    /* Look for "BEGINTAGS" */
                    if (lines[counter] == "BEGINTAGS")
                {
                    while (lines[counter] != "ENDTAGS")
                    {
                        counter += 1;
                        tagList.Add(lines[counter]);
                    }

                    /* Remove the "ENDTAGS" that appears on the end of the list */
                    tagList.RemoveAt((tagList.Count - 1));
                }

                if (lines[counter] == "BEGINDATA")
                {
                    MessageBox.Show("This");
                }

                /* Prevent IndexOutOfRange Error */
                if (counter < lines.Length)
                {
                    counter += 1;
                }
            }

            Form3 loadWindow = new Form3();
            loadWindow.Show();
        }

        private void versionLabel_Click(object sender, EventArgs e)
        {
        }
    }
}
