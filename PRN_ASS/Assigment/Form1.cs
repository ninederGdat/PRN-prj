using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;
using MjpegProcessor;
using System.Net;
using System.Net.Mail;
using System.Data;
using OfficeOpenXml;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Windows.Compatibility;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using Google.Apis.Sheets.v4.Data;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace Assigment
{
    public partial class Form1 : Form
    {
        MjpegDecoder mjp;
        Bitmap capturedImage;
        VideoCaptureDevice captureDevice;
        FilterInfoCollection collection;
        string studentCode = "";
        public Form1()
        {
            InitializeComponent();

            mjp = new MjpegDecoder();
            mjp.FrameReady += Mjp_FrameReady;
        }


        private void Mjp_FrameReady(object? sender, FrameReadyEventArgs e)
        {
            pricture1.Image = e.Bitmap;
        }
        public SheetsService API()
        {
            string[] Scopes = { SheetsService.Scope.Spreadsheets };
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                {
                    ClientId = "153970597976-i6irhqae0ujshet1sb94aner6ls19dki.apps.googleusercontent.com",
                    ClientSecret = "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"
                }
            , Scopes, "user", CancellationToken.None, new FileDataStore("MyAppsToken")).Result,
                ApplicationName = "Google Sheets API .NET Quickstart",
            });
            return service;
        }




        //private void SendMail(Bitmap image)
        private void SendMail(string email)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan targetTime = new TimeSpan(6, 45, 0); // Mốc thời gian là 7 giờ
            TimeSpan delay = currentTime.TimeOfDay - targetTime;
            string delayFormatted = delay.ToString(@"hh\:mm\:ss");


            string from, to, pass, content;
            from = "thienpmse160345@fpt.edu.vn";
            to = email;
            pass = "vvcpwolgqymgjfeu";
            if (currentTime.TimeOfDay <= targetTime)
            {
                content = "Đúng giờ";
            }
            else
            {
                content = "You lated " + delayFormatted + "Môn Prn211 slot 2, Lớp của thầy Phương ";
            }

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Subject = "Test send email attendance";

            mail.Body = content;
            mail.IsBodyHtml = true;



            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(mail);
                MessageBox.Show("Email sent successfully.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            collection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDevice();
            textBox1.Visible = false;
        }



        private void clickbutton1_Click(object sender, EventArgs e)
        {
            // Ghi lại và xuất số 

            try
            {
                var service = API();
                var values = service.Spreadsheets.Values.Get("1ctiuD4cigTM4-5HLEyioQaoksgHRMKfpOf6omMuPgBE", $"{"record"}!A:G").Execute().Values;
                int i = 0;
                string email = null;
                bool found = false;
                foreach (var Column in values)
                {
                    i++;

                    if (Column[0].ToString().Equals(studentCode))

                    {

                        string name = Column[1].ToString();
                        email = Column[1].ToString(); // Lấy giá trị email tương ứng với studentcode

                        DialogResult result = MessageBox.Show($"Xin chào {name} đã tới lớp học Thầy Phương!");

                        var date = DateTime.Now;
                        var attendanceTime = new DateTime(date.Year, date.Month, date.Day, 1, 43, 0); // Thời gian điểm danh là 6 giờ 45 sáng
                        var endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 45, 0);


                        if (date >= attendanceTime && date <= endTime)
                        {
                            TimeSpan delay = DateTime.Now - attendanceTime;
                            string status;
                            if (delay.TotalMinutes <= 15)
                                status = "Present"; // Đến đúng giờ
                            else
                                status = "Late"; // Đến trễ
                            var rowNumber = i;
                            var range = $"{"record"}!F{rowNumber}:G{rowNumber}";
                            var ValueRange = new ValueRange();
                            ValueRange.Values = new List<IList<object>> { new List<object> { date.ToString("HH:mm:ss"), status } };
                            var updatePlank = service.Spreadsheets.Values.Update(ValueRange, "1ctiuD4cigTM4-5HLEyioQaoksgHRMKfpOf6omMuPgBE", range);
                            updatePlank.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
                            var UpdateResponse = updatePlank.Execute();
                            SpreadsheetsResource.ValuesResource.GetRequest getRequest = service.Spreadsheets.Values.Get("1ctiuD4cigTM4-5HLEyioQaoksgHRMKfpOf6omMuPgBE", "record!A:G");
                            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender2, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; };
                            ValueRange getRespone = getRequest.Execute();
                            ShowForm show = new ShowForm(studentCode);
                            MessageBox.Show($"Email của bạn là :\n{email}", "Bạn đã được điểm danh");

                            show.ShowDialog();
                            SendMail(email);

                            found = true;
                        }
                        else if(date > endTime)
                        {
                            var status = "Absent";
                            var rowNumber = i;
                            var range = $"{"record"}!F{rowNumber}:G{rowNumber}";
                            var ValueRange = new ValueRange();
                            ValueRange.Values = new List<IList<object>> { new List<object> { date.ToString("HH:mm:ss"), status } };
                            var updatePlank = service.Spreadsheets.Values.Update(ValueRange, "1ctiuD4cigTM4-5HLEyioQaoksgHRMKfpOf6omMuPgBE", range);
                            updatePlank.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED;
                            var UpdateResponse = updatePlank.Execute();

                            SpreadsheetsResource.ValuesResource.GetRequest getRequest = service.Spreadsheets.Values.Get("1ctiuD4cigTM4-5HLEyioQaoksgHRMKfpOf6omMuPgBE", "record!A:G");
                            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender2, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; };
                            ValueRange getRespone = getRequest.Execute();
                            ShowForm show = new ShowForm(studentCode);
                            MessageBox.Show($"Đã kết thúc lớp học, Hãy gửi email cho thầy Phương để được điểm danh ");

                            show.ShowDialog();
                            SendMail(email);

                            found = true;
                        }
                        else
                        {
                            MessageBox.Show("Lớp học chưa bắt đầu ");
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm dữ liệu: " + ex.Message);
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pricture1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pricture1.Image);

                if (result != null)
                {
                    textBox1.Text = result.ToString();
                    studentCode = result.ToString();
                    textBox1.Visible = true;
                    timer1.Stop();

                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }

            }
        }

        private void button1_CheckedChanged(object sender, EventArgs e)
        {

            mjp.ParseStream(new Uri(" http://192.168.27.100:4747/video?640x480"));

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clickbutton2_Click_1(object sender, EventArgs e)
        {
            if (!captureDevice.IsRunning)
            {
                mjp.ParseStream(new Uri("http://172.16.1.14:4747/video?640x480"));
            }
            textBox1.Text = string.Empty;
            textBox1.Visible = false;
        }

        private void clickbutton3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            textBox1.Visible = false;
        }

        private void clickbutton4_Click(object sender, EventArgs e)
        {   
            LoginTeacher login = new LoginTeacher();
            login.ShowDialog();
        }
    }
}


