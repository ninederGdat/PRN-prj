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
            label1 = new Label();
            clickbutton1 = new Design.Clickbutton();
            button1 = new Design.button();
            label2 = new Label();
            pricture1 = new Design.Pricture();
            ((System.ComponentModel.ISupportInitialize)pricture1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Bisque;
            label1.Font = new Font("Sitka Heading", 26.2499962F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(323, 50);
            label1.TabIndex = 3;
            label1.Text = "Khu Vực Điểm Danh ";
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
            clickbutton1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            clickbutton1.ForeColor = Color.Black;
            clickbutton1.Location = new Point(357, 206);
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
            button1.Location = new Point(395, 126);
            button1.MinimumSize = new Size(80, 35);
            button1.Name = "button1";
            button1.OffBackColor = Color.DarkSalmon;
            button1.OffToggleColor = Color.DimGray;
            button1.OnBackColor = Color.MediumSlateBlue;
            button1.OnToggleColor = Color.WhiteSmoke;
            button1.Size = new Size(80, 35);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.CheckedChanged += button1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.BurlyWood;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(378, 73);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(108, 40);
            label2.TabIndex = 6;
            label2.Text = "Mở Camera";
            label2.Click += label2_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(574, 302);
            Controls.Add(pricture1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(clickbutton1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLight;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pricture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Design.Clickbutton clickbutton1;
        private Design.button button1;
        protected Label label2;
        private Design.Pricture pricture1;
    }
}