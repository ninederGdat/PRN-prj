using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;
using MjpegProcessor;
using System.Net;
using System.Net.Mail;
namespace Assigment
{
    public partial class Form1 : Form
    {
        MjpegDecoder mjp;
        Bitmap capturedImage;


        public Form1()
        {
            InitializeComponent();
            mjp = new MjpegDecoder();
            mjp.FrameReady += Mjp_FrameReady;
        }

        private void Mjp_FrameReady(object? sender, FrameReadyEventArgs e)
        {
            pictureBox1.Image = e.Bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mjp.ParseStream(new Uri(" http://192.168.1.56:4747/video?640x480"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ghi lại và xuất số 
            capturedImage = (Bitmap)pictureBox1.Image.Clone();
            int randomValue = new Random().Next();
            ShowCapturedImage(capturedImage, randomValue);
            SendMail(capturedImage);


        }


        private void ShowCapturedImage(Bitmap image, int randomValue)
        {
            // Tạo một instance của ShowForm
            ShowForm showForm = new ShowForm();

            // Hiển thị ảnh đã chụp và giá trị ngẫu nhiên trên ShowForm
            showForm.ShowImage(image, randomValue);

            // Hiển thị form ShowForm
            showForm.Show();
        }

        private void SendMail(Bitmap image)
        {
            string from, to, pass, content;
            from = "thienpmse160345@fpt.edu.vn";
            to = "thaohien1372002@gmail.com";
            pass = "vvcpwolgqymgjfeu";
            content = "You were 10 minutes late.";

            MailMessage mail = new MailMessage();
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Subject = "Test send email attendance";
            mail.Body = "<html><body><h1>" + content + "</h1><br><img src='cid:Image'></body></html>";
            mail.IsBodyHtml = true;

            // Đính kèm hình ảnh
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                stream.Position = 0;

                // Tạo phần tử đính kèm từ MemoryStream chứa hình ảnh
                Attachment attachment = new Attachment(stream, "image.jpg");
                attachment.ContentId = "Image";
                mail.Attachments.Add(attachment);

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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


