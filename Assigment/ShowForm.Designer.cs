namespace Assigment
{
    partial class ShowForm
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
            pricture1 = new Design.Pricture();
            labelDesign1 = new Design.LabelDesign();
            labelDesign2 = new Design.LabelDesign();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pricture1).BeginInit();
            SuspendLayout();
            // 
            // pricture1
            // 
            pricture1.BackColor = Color.LightSlateGray;
            pricture1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            pricture1.BorderColor = Color.RoyalBlue;
            pricture1.BorderColor2 = Color.HotPink;
            pricture1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            pricture1.BorderSize = 2;
            pricture1.GradientAngle = 50F;
            pricture1.Location = new Point(54, 92);
            pricture1.Name = "pricture1";
            pricture1.Size = new Size(275, 275);
            pricture1.SizeMode = PictureBoxSizeMode.StretchImage;
            pricture1.TabIndex = 2;
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
            labelDesign1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelDesign1.ForeColor = Color.Black;
            labelDesign1.Location = new Point(12, 33);
            labelDesign1.Name = "labelDesign1";
            labelDesign1.Size = new Size(404, 42);
            labelDesign1.TabIndex = 4;
            labelDesign1.Text = "Điểm danh thành công ";
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
            labelDesign2.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point);
            labelDesign2.ForeColor = Color.Black;
            labelDesign2.Location = new Point(351, 143);
            labelDesign2.Name = "labelDesign2";
            labelDesign2.Size = new Size(96, 29);
            labelDesign2.TabIndex = 5;
            labelDesign2.Text = "UserID";
            labelDesign2.TextColor = Color.Black;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(378, 200);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 23);
            textBox1.TabIndex = 6;
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(612, 389);
            Controls.Add(textBox1);
            Controls.Add(labelDesign2);
            Controls.Add(labelDesign1);
            Controls.Add(pricture1);
            ForeColor = SystemColors.ControlDark;
            Margin = new Padding(2);
            Name = "ShowForm";
            Text = "ShowForm";
            Load += ShowForm_Load;
            ((System.ComponentModel.ISupportInitialize)pricture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Design.Pricture pricture1;
        private Design.LabelDesign labelDesign1;
        private Design.LabelDesign labelDesign2;
        private TextBox textBox1;
    }
}