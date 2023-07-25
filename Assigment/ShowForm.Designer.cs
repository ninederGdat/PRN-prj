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
            textBox1 = new TextBox();
            pricture1 = new Design.Pricture();
            ((System.ComponentModel.ISupportInitialize)pricture1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 55);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 23);
            textBox1.TabIndex = 1;
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
            pricture1.Location = new Point(12, 12);
            pricture1.Name = "pricture1";
            pricture1.Size = new Size(241, 241);
            pricture1.SizeMode = PictureBoxSizeMode.StretchImage;
            pricture1.TabIndex = 2;
            pricture1.TabStop = false;
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(560, 270);
            Controls.Add(pricture1);
            Controls.Add(textBox1);
            Margin = new Padding(2);
            Name = "ShowForm";
            Text = "ShowForm";
            Load += ShowForm_Load;
            ((System.ComponentModel.ISupportInitialize)pricture1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Design.Pricture pricture1;
    }
}