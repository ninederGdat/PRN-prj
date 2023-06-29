using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;
using MjpegProcessor;

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
            mjp.ParseStream(new Uri(" http://192.168.27.100:4747/video?640x480"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ghi lại và xuất số 
            capturedImage = (Bitmap)pictureBox1.Image.Clone();
            int randomValue = new Random().Next();
            ShowCapturedImage(capturedImage, randomValue);
            

            //Save picture
            //if (pictureBox1.Image != null)
            //{
            //    // Lưu ảnh từ PictureBox vào tệp tin
            //    SaveFileDialog saveFileDialog = new SaveFileDialog();
            //    saveFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        pictureBox1.Image.Save(saveFileDialog.FileName);

                  
            //        MessageBox.Show("Đã chụp ảnh thành công!");

            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Không có khung hình để chụp!");
            //}
        }

        //Hàm xuất số ngẫu nhiên đi kèm hình
        private void ShowCapturedImage(Bitmap image, int randomValue)
        {
            // Tạo một instance của ShowForm
            ShowForm showForm = new ShowForm();

            // Hiển thị ảnh đã chụp và giá trị ngẫu nhiên trên ShowForm
            showForm.ShowImage(image, randomValue);

            // Hiển thị form ShowForm
            showForm.Show();
        }

    }
}


