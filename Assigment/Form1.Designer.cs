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
            ((System.ComponentModel.ISupportInitialize)pricture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // clickbutton1
            // 
            clickbutton1.BackColor = Color.BurlyWood;
            clickbutton1.BackgroundColor = Color.BurlyWood;
            clickbutton1.BorderColor = Color.PaleVioletRed;
            clickbutton1.BorderRadius = 20;
            clickbutton1.BorderSize = 0;
            clickbutton1.FlatAppearance.BorderSize = 0;
            clickbutton1.FlatStyle = FlatStyle.Flat;
            clickbutton1.Font = new Font("Book Antiqua", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            clickbutton1.ForeColor = Color.Black;
            clickbutton1.Location = new Point(405, 225);
            clickbutton1.Name = "clickbutton1";
            clickbutton1.Size = new Size(138, 53);
            clickbutton1.TabIndex = 4;
            clickbutton1.Text = "Điểm Danh";
            clickbutton1.TextColor = Color.Black;
            clickbutton1.UseVisualStyleBackColor = false;
            clickbutton1.Click += clickbutton1_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(384, 148);
            button1.MinimumSize = new Size(90, 40);
            button1.Name = "button1";
            button1.OffBackColor = Color.DarkSalmon;
            button1.OffToggleColor = Color.DimGray;
            button1.OnBackColor = Color.MediumSlateBlue;
            button1.OnToggleColor = Color.WhiteSmoke;
            button1.Size = new Size(90, 40);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.CheckedChanged += button1_CheckedChanged;
            // 
            // pricture1
            // 
            pricture1.BackColor = Color.Wheat;
            pricture1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pricture1.BorderColor = Color.RoyalBlue;
            pricture1.BorderColor2 = Color.HotPink;
            pricture1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pricture1.BorderSize = 2;
            pricture1.GradientAngle = 50F;
            pricture1.Location = new Point(68, 62);
            pricture1.Name = "pricture1";
            pricture1.Size = new Size(243, 243);
            pricture1.SizeMode = PictureBoxSizeMode.StretchImage;
            pricture1.TabIndex = 7;
            pricture1.TabStop = false;
            // 
            // labelDesign1
            // 
            labelDesign1.AutoSize = true;
            labelDesign1.BackColor = Color.BurlyWood;
            labelDesign1.BackgroundColor = Color.BurlyWood;
            labelDesign1.BorderColor = Color.PaleVioletRed;
            labelDesign1.BorderRadius = 15;
            labelDesign1.BorderSize = 0;
            labelDesign1.Font = new Font("Microsoft YaHei", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelDesign1.ForeColor = Color.Black;
            labelDesign1.Location = new Point(16, 9);
            labelDesign1.Name = "labelDesign1";
            labelDesign1.Size = new Size(376, 48);
            labelDesign1.TabIndex = 8;
            labelDesign1.Text = "Khu vực điểm danh ";
            labelDesign1.TextColor = Color.Black;
            // 
            // labelDesign2
            // 
            labelDesign2.AutoSize = true;
            labelDesign2.BackColor = Color.BurlyWood;
            labelDesign2.BackgroundColor = Color.BurlyWood;
            labelDesign2.BorderColor = Color.PaleVioletRed;
            labelDesign2.BorderRadius = 15;
            labelDesign2.BorderSize = 0;
            labelDesign2.Font = new Font("Book Antiqua", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelDesign2.ForeColor = Color.Black;
            labelDesign2.Location = new Point(320, 80);
            labelDesign2.Name = "labelDesign2";
            labelDesign2.Size = new Size(175, 38);
            labelDesign2.TabIndex = 9;
            labelDesign2.Text = "Mở camera";
            labelDesign2.TextColor = Color.Black;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(574, 302);
            Controls.Add(labelDesign2);
            Controls.Add(labelDesign1);
            Controls.Add(pricture1);
            Controls.Add(button1);
            Controls.Add(clickbutton1);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(2);
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
    }
}