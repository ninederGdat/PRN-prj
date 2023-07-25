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
        public ShowForm()
        {
            InitializeComponent();
        }

        public void ShowImage(Bitmap image, int randomValue)
        {
            pricture1.Image = image;
            textBox1.Text = randomValue.ToString();
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {

        }
    }
}
