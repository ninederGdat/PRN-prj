namespace Assigment
{
    partial class Form2
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
            dataGridView1 = new DataGridView();
            labelDesign1 = new Design.LabelDesign();
            txtstudent = new Design.TextBox();
            btsearch = new Design.Clickbutton();
            reloadbtn = new Design.Clickbutton();
            tickbtn = new Design.Clickbutton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 165);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1147, 517);
            dataGridView1.TabIndex = 0;
            // 
            // labelDesign1
            // 
            labelDesign1.AutoSize = true;
            labelDesign1.BackColor = Color.OliveDrab;
            labelDesign1.BackgroundColor = Color.OliveDrab;
            labelDesign1.BorderColor = Color.PaleVioletRed;
            labelDesign1.BorderRadius = 5;
            labelDesign1.BorderSize = 0;
            labelDesign1.Font = new Font("Segoe UI Variable Small", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDesign1.ForeColor = Color.Black;
            labelDesign1.Location = new Point(458, 9);
            labelDesign1.Margin = new Padding(4, 0, 4, 0);
            labelDesign1.Name = "labelDesign1";
            labelDesign1.Size = new Size(300, 54);
            labelDesign1.TabIndex = 1;
            labelDesign1.Text = "Danh sách lớp ";
            labelDesign1.TextColor = Color.Black;
            // 
            // txtstudent
            // 
            txtstudent.BackColor = SystemColors.Window;
            txtstudent.BorderColor = Color.MediumSlateBlue;
            txtstudent.BorderFocusColor = Color.HotPink;
            txtstudent.BorderRadius = 0;
            txtstudent.BorderSize = 2;
            txtstudent.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtstudent.ForeColor = Color.FromArgb(64, 64, 64);
            txtstudent.Location = new Point(467, 92);
            txtstudent.Margin = new Padding(6, 7, 6, 7);
            txtstudent.Multiline = false;
            txtstudent.Name = "txtstudent";
            txtstudent.Padding = new Padding(14, 12, 14, 12);
            txtstudent.PasswordChar = false;
            txtstudent.PlaceholderColor = Color.DarkGray;
            txtstudent.PlaceholderText = "Tìm kiếm student";
            txtstudent.Size = new Size(237, 49);
            txtstudent.TabIndex = 2;
            txtstudent.Texts = "";
            txtstudent.UnderlinedStyle = false;
            // 
            // btsearch
            // 
            btsearch.BackColor = Color.SeaGreen;
            btsearch.BackgroundColor = Color.SeaGreen;
            btsearch.BorderColor = Color.PaleVioletRed;
            btsearch.BorderRadius = 20;
            btsearch.BorderSize = 0;
            btsearch.FlatAppearance.BorderSize = 0;
            btsearch.FlatStyle = FlatStyle.Flat;
            btsearch.Font = new Font("Segoe UI Variable Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btsearch.ForeColor = Color.Black;
            btsearch.Location = new Point(263, 74);
            btsearch.Margin = new Padding(4, 5, 4, 5);
            btsearch.Name = "btsearch";
            btsearch.Size = new Size(176, 67);
            btsearch.TabIndex = 3;
            btsearch.Text = "Tìm kiếm";
            btsearch.TextColor = Color.Black;
            btsearch.UseVisualStyleBackColor = false;
            btsearch.Click += btsearch_Click;
            // 
            // reloadbtn
            // 
            reloadbtn.BackColor = Color.SeaGreen;
            reloadbtn.BackgroundColor = Color.SeaGreen;
            reloadbtn.BorderColor = Color.PaleVioletRed;
            reloadbtn.BorderRadius = 20;
            reloadbtn.BorderSize = 0;
            reloadbtn.FlatAppearance.BorderSize = 0;
            reloadbtn.FlatStyle = FlatStyle.Flat;
            reloadbtn.Font = new Font("Segoe UI Variable Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            reloadbtn.ForeColor = Color.Black;
            reloadbtn.Location = new Point(46, 73);
            reloadbtn.Margin = new Padding(4, 5, 4, 5);
            reloadbtn.Name = "reloadbtn";
            reloadbtn.Size = new Size(176, 67);
            reloadbtn.TabIndex = 4;
            reloadbtn.Text = "Hiện DS";
            reloadbtn.TextColor = Color.Black;
            reloadbtn.UseVisualStyleBackColor = false;
            reloadbtn.Click += reloadbtn_Click;
            // 
            // tickbtn
            // 
            tickbtn.BackColor = Color.SeaGreen;
            tickbtn.BackgroundColor = Color.SeaGreen;
            tickbtn.BorderColor = Color.PaleVioletRed;
            tickbtn.BorderRadius = 20;
            tickbtn.BorderSize = 0;
            tickbtn.FlatAppearance.BorderSize = 0;
            tickbtn.FlatStyle = FlatStyle.Flat;
            tickbtn.Font = new Font("Segoe UI Variable Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tickbtn.ForeColor = Color.Black;
            tickbtn.Location = new Point(976, 88);
            tickbtn.Margin = new Padding(4, 5, 4, 5);
            tickbtn.Name = "tickbtn";
            tickbtn.Size = new Size(206, 67);
            tickbtn.TabIndex = 5;
            tickbtn.Text = "Điểm danh";
            tickbtn.TextColor = Color.Black;
            tickbtn.UseVisualStyleBackColor = false;
            tickbtn.Click += tickbtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1274, 750);
            Controls.Add(tickbtn);
            Controls.Add(reloadbtn);
            Controls.Add(btsearch);
            Controls.Add(txtstudent);
            Controls.Add(labelDesign1);
            Controls.Add(dataGridView1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Design.LabelDesign labelDesign1;
        private Design.TextBox txtstudent;
        private Design.Clickbutton btsearch;
        private Design.Clickbutton reloadbtn;
        private Design.Clickbutton tickbtn;
    }
}