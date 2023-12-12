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
    public partial class LoginTeacher : Form
    {
        public LoginTeacher()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (txtemail.Texts == null)
            {
                MessageBox.Show("Please input email");
            }
            else if (txtpassword.Texts == null)
            {
                MessageBox.Show("Please input password");
            }
            else
            {
                txtemail.Texts = "thayphuong@gmail.com";
                txtpassword.Texts = "123";
                this.Close();

                Form2 form = new Form2();
                form.Show();
            }
        }

        private void LoginTeacher_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
