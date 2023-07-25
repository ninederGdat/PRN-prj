using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment
{
    public partial class ShowForm : Form
    {
        DateTime currentTime = DateTime.Now;
        TimeSpan targetTime = new TimeSpan(7, 0, 0); // Mốc thời gian là 7 giờ
        public ShowForm()
        {
            InitializeComponent();
        }
        public void ShowTime()
        {
            if (currentTime.TimeOfDay <= targetTime)
            {
                textBox2.Text = "Đúng giờ";
            }
            else
            {
                TimeSpan delay = currentTime.TimeOfDay - targetTime;
                string delayFormatted = delay.ToString(@"hh\:mm\:ss");
                textBox2.Text = "Bị trễ: " + delayFormatted;
            }
        }

        public void ShowImage(Bitmap image, int randomValue)
        {
            pricture1.Image = image;
            textBox1.Text = randomValue.ToString();
            textBox2.Show();
        }


    }
}
