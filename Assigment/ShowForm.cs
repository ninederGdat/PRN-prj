using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment
{
    public partial class ShowForm : Form
    {
        DateTime currentTime = DateTime.Now;
        TimeSpan targetTime = new TimeSpan(9, 30, 0); // Mốc thời gian là 7 giờ
        private string studentCode;
        public ShowForm(string studentcode)
        {
            InitializeComponent();
            this.studentCode = studentcode;
        }
        public SheetsService API()
        {
            string[] Scopes = { SheetsService.Scope.Spreadsheets };
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                {
                    ClientId = "36392620786-f8rbcns5pclnnnvbpj7392oi1p9g87pe.apps.googleusercontent.com",
                    ClientSecret = "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"
                }
            , Scopes, "user", CancellationToken.None, new FileDataStore("MyAppsToken")).Result,
                ApplicationName = "Google Sheets API .NET ",
            });
            return service;
        }
        public void ShowTime()
        {
            if (currentTime.TimeOfDay <= targetTime)
            {
                fullname.Text = "Đúng giờ";
            }
            else
            {
                TimeSpan delay = currentTime.TimeOfDay - targetTime;
                string delayFormatted = delay.ToString(@"hh\:mm\:ss");
                fullname.Text = "Bị trễ: " + delayFormatted;
            }
        }



        private void labelDesign6_Click(object sender, EventArgs e)
        {

        }

        private void ShowForm_Load(object sender, EventArgs e)
        {
            try
            {
                var service = API();
                var spreadsheetId = "1Wcg80UudlfC-m_HnTKlfVA7InbNofRCUP9G0BBaVx0M";
                var range = "Object!A:G";
                var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
                var response = request.Execute();
                var values = response.Values;

                if (values != null && values.Count > 0)
                {
                    // Assuming your data starts from row 2 (excluding header row).
                    foreach (var row in values)
                    {
                        string studentCodes = row[0].ToString();
                        string fullName = row[2].ToString();
                        string timeClassColumnA = row[3].ToString();
                        string timeClassColumnB = row[4].ToString();
                        string checkIn = row[5].ToString();
                        string Status = row[6].ToString();
                        if (studentCodes == studentCode)
                        {

                            TimeSpan delay = currentTime.TimeOfDay - targetTime;
                            string delayFormatted = delay.ToString(@"hh\:mm\:ss");
                            
                            // Concatenate timeClassColumnA and timeClassColumnB with a "+" symbol.
                            string timeClass = $"{timeClassColumnA} - {timeClassColumnB}";
                           
                            // Now, you can set the values to the corresponding textboxes.
                            studentcode.Text = studentCodes;
                            fullname.Text = fullName;
                            timeclass.Text = timeClass;
                            checkin.Text = checkIn;
                            if (delay > TimeSpan.Zero)
                            {
                                timelate.Text = "Bị trễ: " + delayFormatted;
                            }
                            else
                            {
                                timelate.Text = "Đúng giờ";
                            }
                            status.Text = Status;
                        }
                    }

                    // Show the necessary textboxes.
                    studentcode.Visible = true;
                    fullname.Visible = true;
                    timeclass.Visible = true;
                    checkin.Visible = true;
                    timelate.Visible = true;

                    // Center the form on the screen.
                    this.CenterToScreen();
                }
            }
            catch
            {
                // Handle any exceptions (e.g., API errors) here.
            }
        }

        private void timelate_TextChanged(object sender, EventArgs e)
        {

        }

        private void clickbutton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
