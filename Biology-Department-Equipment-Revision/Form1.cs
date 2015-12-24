using System;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using Outlook = Microsoft.Office.Interop.Outlook;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            int selectedTeacherIndex = teacher.SelectedIndex;

            List<string> colourList = new List<string>();
            for(int i = 0; i < 10; i++)
            {
                colourList.Add(i.ToString());
            }

            string year1 = calendar.Value.ToString("yyyy");
            string month1 = calendar.Value.ToString("MM");
            string day1 = calendar.Value.ToString("dd");

            int year = int.Parse(year1);
            int month = int.Parse(month1);
            int day = int.Parse(day1);

            Object selectedYearGroup = yearGroup.SelectedItem;
            Object selectedGroup = groups.SelectedItem;

            Object selectedPeriod = period.SelectedItem;

            string hour = "00";
            string minute = "00";
            string finishMinute = "00";
            string finishHour = "00";

            switch (selectedPeriod.ToString())
            {
                case "Period 1":
                    hour = "09";
                    minute = "05";
                    finishMinute = "50";
                    finishHour = "09";
                    break;

                case "Period 2":
                    hour = "09";
                    minute = "55";
                    finishMinute = "45";
                    finishHour = "10";
                    break;

                case "Period 3":
                    hour = "11";
                    minute = "05";
                    finishMinute = "00";
                    finishHour = "12";
                    break;

                case "Period 4":
                    hour = "12";
                    minute = "05";
                    finishMinute = "50";
                    finishHour = "12";
                    break;

                case "Period 5":
                    hour = "14";
                    minute = "10";
                    finishMinute = "00";
                    finishHour = "15";
                    break;

                case "Period 6":
                    hour = "15";
                    minute = "05";
                    finishMinute = "55";
                    finishHour = "16";
                    break;
            }

            Object selectedEquipment = equipment.Text;
            Object selectedHazcards = hazcards.Text;
            Boolean selectedRiskAssessment = riskAssessment.Checked;

            UserCredential credential;

            string[] Scopes = { CalendarService.Scope.Calendar };
            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/calendar-dotnet-quickstart");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Calendar API service.
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "BDER 2015",
            });

            // Define parameters of request.
            EventsResource.ListRequest request = service.Events.List("lmaa730d1os7pj3o0dqdfe920o@group.calendar.google.com");
            request.TimeMin = DateTime.Now;
            request.ShowDeleted = false;
            request.SingleEvents = true;
            request.MaxResults = 10;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            string StartTime = (year.ToString() + "/" + month.ToString() + "/" + day.ToString() + " " + hour.ToString() + ":" + minute.ToString() + ":00");

            Event newEvent = new Event()
            {
                Summary = "Practical Request from " + selectedTeacher,
                Location = "GSAL",
                Description = (@selectedTeacher + " - " + selectedGroup + " - " + selectedPeriod + ".\nEquipment Requested:\n" + selectedEquipment + "\nTeacher has confirmed a risk assessment has been carried out.\nReferenced Hazcards:\n" + selectedHazcards),
                Start = new EventDateTime()
                {
                    DateTime = new DateTime(year, month, day, Int32.Parse(hour), Int32.Parse(minute), 0),
                    TimeZone = "Europe/London",
                },
                End = new EventDateTime()
                {
                    DateTime = new DateTime(year, month, day, Int32.Parse(finishHour), Int32.Parse(finishMinute), 0),
                    TimeZone = "Europe/London",
                },
                /*Attendees = new EventAttendee[]
                {
                    new EventAttendee() { Email = "technicans@gsal.org.uk" },
                },*/
                Reminders = new Event.RemindersData()
                {
                    UseDefault = false,
                    Overrides = new EventReminder[] {
                        new EventReminder() { Method = "popup", Minutes = 15 },
                    }
                },
                ColorId = colourList[selectedTeacherIndex],
            };

            String calendarId = "lmaa730d1os7pj3o0dqdfe920o@group.calendar.google.com";
            EventsResource.InsertRequest newRequest = service.Events.Insert(newEvent, calendarId);
            Event createdEvent = newRequest.Execute();

            string url = createdEvent.HtmlLink;
            Form2 finishedDialogue = new Form2(url);
            finishedDialogue.ShowDialog();
            this.Close();
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

        private void versionLabel_Click(object sender, EventArgs e)
        {
        }

        private void upload_Click(object sender, EventArgs e)
        {
        }

        private void riskAssessment_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
