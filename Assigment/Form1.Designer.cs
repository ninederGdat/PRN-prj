namespace Assigment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            clickbutton1 = new Design.Clickbutton();
            button1 = new Design.button();
            pricture1 = new Design.Pricture();
            bindingSource1 = new BindingSource(components);
            labelDesign1 = new Design.LabelDesign();
            labelDesign2 = new Design.LabelDesign();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            clickbutton2 = new Design.Clickbutton();
            clickbutton3 = new Design.Clickbutton();
            clickbutton4 = new Design.Clickbutton();
            ((System.ComponentModel.ISupportInitialize)pricture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // clickbutton1
            // 
            clickbutton1.BackColor = Color.SteelBlue;
            clickbutton1.BackgroundColor = Color.SteelBlue;
            clickbutton1.BorderColor = Color.PaleVioletRed;
            clickbutton1.BorderRadius = 25;
            clickbutton1.BorderSize = 0;
            clickbutton1.FlatAppearance.BorderSize = 0;
            clickbutton1.FlatStyle = FlatStyle.Flat;
            clickbutton1.Font = new Font("Segoe UI Variable Small", 18F, FontStyle.Regular, GraphicsUnit.Point);
            clickbutton1.ForeColor = Color.Black;
            clickbutton1.Location = new Point(519, 587);
            clickbutton1.Margin = new Padding(4, 5, 4, 5);
            clickbutton1.Name = "clickbutton1";
            clickbutton1.Size = new Size(230, 107);
            clickbutton1.TabIndex = 4;
            clickbutton1.Text = "Điểm Danh";
            clickbutton1.TextColor = Color.Black;
            clickbutton1.UseVisualStyleBackColor = false;
            clickbutton1.Click += clickbutton1_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(814, 192);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.MinimumSize = new Size(129, 67);
            button1.Name = "button1";
            button1.OffBackColor = Color.DarkSalmon;
            button1.OffToggleColor = Color.DimGray;
            button1.OnBackColor = Color.MediumSlateBlue;
            button1.OnToggleColor = Color.WhiteSmoke;
            button1.Size = new Size(129, 67);
            button1.TabIndex = 5;
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.UseVisualStyleBackColor = true;
            button1.CheckedChanged += button1_CheckedChanged;
            // 
            // pricture1
            // 
            pricture1.BackColor = Color.PeachPuff;
            pricture1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pricture1.BorderColor = Color.RoyalBlue;
            pricture1.BorderColor2 = Color.HotPink;
            pricture1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pricture1.BorderSize = 2;
            pricture1.GradientAngle = 50F;
            pricture1.Location = new Point(17, 165);
            pricture1.Margin = new Padding(4, 5, 4, 5);
            pricture1.Name = "pricture1";
            pricture1.Size = new Size(467, 467);
            pricture1.SizeMode = PictureBoxSizeMode.StretchImage;
            pricture1.TabIndex = 7;
            pricture1.TabStop = false;
            // 
            // labelDesign1
            // 
            labelDesign1.AutoSize = true;
            labelDesign1.BackColor = Color.Beige;
            labelDesign1.BackgroundColor = Color.Beige;
            labelDesign1.BorderColor = Color.PaleVioletRed;
            labelDesign1.BorderRadius = 20;
            labelDesign1.BorderSize = 0;
            labelDesign1.Font = new Font("Microsoft YaHei", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelDesign1.ForeColor = Color.Black;
            labelDesign1.Location = new Point(23, 15);
            labelDesign1.Margin = new Padding(4, 0, 4, 0);
            labelDesign1.Name = "labelDesign1";
            labelDesign1.Size = new Size(771, 75);
            labelDesign1.TabIndex = 8;
            labelDesign1.Text = "Điểm danh lớp thầy Hoàng";
            labelDesign1.TextColor = Color.Black;
            // 
            // labelDesign2
            // 
            labelDesign2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelDesign2.AutoSize = true;
            labelDesign2.BackColor = Color.BurlyWood;
            labelDesign2.BackgroundColor = Color.BurlyWood;
            labelDesign2.BorderColor = Color.PaleVioletRed;
            labelDesign2.BorderRadius = 10;
            labelDesign2.BorderSize = 0;
            labelDesign2.Font = new Font("Meiryo UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point);
            labelDesign2.ForeColor = Color.Black;
            labelDesign2.Location = new Point(546, 192);
            labelDesign2.Margin = new Padding(4, 0, 4, 0);
            labelDesign2.Name = "labelDesign2";
            labelDesign2.Size = new Size(244, 52);
            labelDesign2.TabIndex = 9;
            labelDesign2.Text = "Mở camera";
            labelDesign2.TextColor = Color.Black;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Location = new Point(539, 517);
            textBox1.Margin = new Padding(7, 8, 7, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(208, 31);
            textBox1.TabIndex = 14;
            // 
            // clickbutton2
            // 
            clickbutton2.BackColor = Color.CadetBlue;
            clickbutton2.BackgroundColor = Color.CadetBlue;
            clickbutton2.BorderColor = Color.PaleVioletRed;
            clickbutton2.BorderRadius = 20;
            clickbutton2.BorderSize = 0;
            clickbutton2.FlatAppearance.BorderSize = 0;
            clickbutton2.FlatStyle = FlatStyle.Flat;
            clickbutton2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            clickbutton2.ForeColor = Color.Black;
            clickbutton2.Location = new Point(579, 352);
            clickbutton2.Margin = new Padding(4, 5, 4, 5);
            clickbutton2.Name = "clickbutton2";
            clickbutton2.Size = new Size(154, 100);
            clickbutton2.TabIndex = 15;
            clickbutton2.Text = "Reaload";
            clickbutton2.TextColor = Color.Black;
            clickbutton2.UseVisualStyleBackColor = false;
            clickbutton2.Click += clickbutton2_Click_1;
            // 
            // clickbutton3
            // 
            clickbutton3.BackColor = Color.CadetBlue;
            clickbutton3.BackgroundColor = Color.CadetBlue;
            clickbutton3.BorderColor = Color.PaleVioletRed;
            clickbutton3.BorderRadius = 20;
            clickbutton3.BorderSize = 0;
            clickbutton3.FlatAppearance.BorderSize = 0;
            clickbutton3.FlatStyle = FlatStyle.Flat;
            clickbutton3.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            clickbutton3.ForeColor = Color.Black;
            clickbutton3.Location = new Point(781, 352);
            clickbutton3.Margin = new Padding(4, 5, 4, 5);
            clickbutton3.Name = "clickbutton3";
            clickbutton3.Size = new Size(161, 102);
            clickbutton3.TabIndex = 16;
            clickbutton3.Text = "Scan";
            clickbutton3.TextColor = Color.Black;
            clickbutton3.UseVisualStyleBackColor = false;
            clickbutton3.Click += clickbutton3_Click;
            // 
            // clickbutton4
            // 
            clickbutton4.BackColor = Color.SteelBlue;
            clickbutton4.BackgroundColor = Color.SteelBlue;
            clickbutton4.BorderColor = Color.PaleVioletRed;
            clickbutton4.BorderRadius = 20;
            clickbutton4.BorderSize = 0;
            clickbutton4.FlatAppearance.BorderSize = 0;
            clickbutton4.FlatStyle = FlatStyle.Flat;
            clickbutton4.Font = new Font("Segoe UI Variable Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            clickbutton4.ForeColor = Color.Black;
            clickbutton4.Location = new Point(757, 583);
            clickbutton4.Margin = new Padding(4, 5, 4, 5);
            clickbutton4.Name = "clickbutton4";
            clickbutton4.Size = new Size(229, 110);
            clickbutton4.TabIndex = 17;
            clickbutton4.Text = "Teacher";
            clickbutton4.TextColor = Color.Black;
            clickbutton4.UseVisualStyleBackColor = false;
            clickbutton4.Click += clickbutton4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1003, 782);
            Controls.Add(clickbutton4);
            Controls.Add(clickbutton3);
            Controls.Add(clickbutton2);
            Controls.Add(textBox1);
            Controls.Add(labelDesign2);
            Controls.Add(labelDesign1);
            Controls.Add(pricture1);
            Controls.Add(button1);
            Controls.Add(clickbutton1);
            ForeColor = Color.MintCream;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pricture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Design.Clickbutton clickbutton1;
        private Design.button button1;
        private Design.Pricture pricture1;
        private BindingSource bindingSource1;
        private Design.LabelDesign labelDesign1;
        private Design.LabelDesign labelDesign2;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Design.Clickbutton clickbutton2;
        private Design.Clickbutton clickbutton3;
        private Design.Clickbutton clickbutton4;
    }
}