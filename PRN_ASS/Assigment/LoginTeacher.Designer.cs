namespace Assigment
{
    partial class LoginTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btLogin = new Design.Clickbutton();
            btcancel = new Design.Clickbutton();
            labelDesign1 = new Design.LabelDesign();
            labelDesign2 = new Design.LabelDesign();
            txtemail = new Design.TextBox();
            txtpassword = new Design.TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.DarkCyan;
            btLogin.BackgroundColor = Color.DarkCyan;
            btLogin.BorderColor = Color.PaleVioletRed;
            btLogin.BorderRadius = 20;
            btLogin.BorderSize = 0;
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatStyle = FlatStyle.Flat;
            btLogin.Font = new Font("Segoe UI Variable Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btLogin.ForeColor = Color.Black;
            btLogin.Location = new Point(267, 297);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(121, 40);
            btLogin.TabIndex = 0;
            btLogin.Text = "Login";
            btLogin.TextColor = Color.Black;
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // btcancel
            // 
            btcancel.BackColor = Color.DarkCyan;
            btcancel.BackgroundColor = Color.DarkCyan;
            btcancel.BorderColor = Color.PaleVioletRed;
            btcancel.BorderRadius = 20;
            btcancel.BorderSize = 0;
            btcancel.FlatAppearance.BorderSize = 0;
            btcancel.FlatStyle = FlatStyle.Flat;
            btcancel.Font = new Font("Segoe UI Variable Small", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btcancel.ForeColor = Color.Crimson;
            btcancel.Location = new Point(467, 297);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(130, 40);
            btcancel.TabIndex = 1;
            btcancel.Text = "Exit";
            btcancel.TextColor = Color.Crimson;
            btcancel.UseVisualStyleBackColor = false;
            // 
            // labelDesign1
            // 
            labelDesign1.AutoSize = true;
            labelDesign1.BackColor = Color.DarkSeaGreen;
            labelDesign1.BackgroundColor = Color.DarkSeaGreen;
            labelDesign1.BorderColor = Color.PaleVioletRed;
            labelDesign1.BorderRadius = 5;
            labelDesign1.BorderSize = 0;
            labelDesign1.Font = new Font("Segoe UI Historic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDesign1.ForeColor = Color.Black;
            labelDesign1.Location = new Point(200, 120);
            labelDesign1.Name = "labelDesign1";
            labelDesign1.Size = new Size(58, 25);
            labelDesign1.TabIndex = 2;
            labelDesign1.Text = "Email";
            labelDesign1.TextColor = Color.Black;
            // 
            // labelDesign2
            // 
            labelDesign2.AutoSize = true;
            labelDesign2.BackColor = Color.DarkSeaGreen;
            labelDesign2.BackgroundColor = Color.DarkSeaGreen;
            labelDesign2.BorderColor = Color.PaleVioletRed;
            labelDesign2.BorderRadius = 5;
            labelDesign2.BorderSize = 0;
            labelDesign2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDesign2.ForeColor = Color.Black;
            labelDesign2.Location = new Point(182, 203);
            labelDesign2.Name = "labelDesign2";
            labelDesign2.Size = new Size(92, 26);
            labelDesign2.TabIndex = 3;
            labelDesign2.Text = "Password";
            labelDesign2.TextColor = Color.Black;
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.Honeydew;
            txtemail.BorderColor = Color.DarkTurquoise;
            txtemail.BorderFocusColor = Color.Violet;
            txtemail.BorderRadius = 0;
            txtemail.BorderSize = 2;
            txtemail.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.ForeColor = Color.FromArgb(64, 64, 64);
            txtemail.Location = new Point(304, 114);
            txtemail.Margin = new Padding(4);
            txtemail.Multiline = false;
            txtemail.Name = "txtemail";
            txtemail.Padding = new Padding(10, 7, 10, 7);
            txtemail.PasswordChar = false;
            txtemail.PlaceholderColor = Color.DarkGray;
            txtemail.PlaceholderText = "";
            txtemail.Size = new Size(250, 31);
            txtemail.TabIndex = 4;
            txtemail.Texts = "thayphuong@gmail.com";
            txtemail.UnderlinedStyle = false;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.Honeydew;
            txtpassword.BorderColor = Color.DarkTurquoise;
            txtpassword.BorderFocusColor = Color.HotPink;
            txtpassword.BorderRadius = 0;
            txtpassword.BorderSize = 2;
            txtpassword.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.FromArgb(64, 64, 64);
            txtpassword.Location = new Point(304, 198);
            txtpassword.Margin = new Padding(4);
            txtpassword.Multiline = false;
            txtpassword.Name = "txtpassword";
            txtpassword.Padding = new Padding(10, 7, 10, 7);
            txtpassword.PasswordChar = true;
            txtpassword.PlaceholderColor = Color.DarkGray;
            txtpassword.PlaceholderText = "";
            txtpassword.Size = new Size(250, 31);
            txtpassword.TabIndex = 5;
            txtpassword.Texts = "123";
            txtpassword.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(347, 21);
            label1.Name = "label1";
            label1.Size = new Size(149, 64);
            label1.TabIndex = 6;
            label1.Text = "Login";
            // 
            // LoginTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(labelDesign2);
            Controls.Add(labelDesign1);
            Controls.Add(btcancel);
            Controls.Add(btLogin);
            Name = "LoginTeacher";
            Text = "LoginTeacher";
            Load += LoginTeacher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Design.Clickbutton btLogin;
        private Design.Clickbutton btcancel;
        private Design.LabelDesign labelDesign1;
        private Design.LabelDesign labelDesign2;
        private Design.TextBox txtemail;
        private Design.TextBox txtpassword;
        private Label label1;
    }
}