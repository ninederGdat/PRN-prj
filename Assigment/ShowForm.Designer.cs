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
            labelDesign1 = new Design.LabelDesign();
            labelDesign2 = new Design.LabelDesign();
            studentcode = new TextBox();
            fullname = new TextBox();
            labelDesign3 = new Design.LabelDesign();
            labelDesign4 = new Design.LabelDesign();
            labelDesign5 = new Design.LabelDesign();
            labelDesign6 = new Design.LabelDesign();
            timeclass = new TextBox();
            checkin = new TextBox();
            timelate = new TextBox();
            labelDesign7 = new Design.LabelDesign();
            status = new TextBox();
            clickbutton1 = new Design.Clickbutton();
            SuspendLayout();
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
            labelDesign1.Location = new Point(95, 9);
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
            labelDesign2.Location = new Point(12, 72);
            labelDesign2.Name = "labelDesign2";
            labelDesign2.Size = new Size(167, 29);
            labelDesign2.TabIndex = 5;
            labelDesign2.Text = "StudentCode";
            labelDesign2.TextColor = Color.Black;
            // 
            // studentcode
            // 
            studentcode.Location = new Point(232, 72);
            studentcode.Name = "studentcode";
            studentcode.Size = new Size(161, 23);
            studentcode.TabIndex = 6;
            // 
            // fullname
            // 
            fullname.Location = new Point(232, 124);
            fullname.Name = "fullname";
            fullname.Size = new Size(161, 23);
            fullname.TabIndex = 7;
            // 
            // labelDesign3
            // 
            labelDesign3.AutoSize = true;
            labelDesign3.BackColor = Color.BurlyWood;
            labelDesign3.BackgroundColor = Color.BurlyWood;
            labelDesign3.BorderColor = Color.PaleVioletRed;
            labelDesign3.BorderRadius = 15;
            labelDesign3.BorderSize = 0;
            labelDesign3.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point);
            labelDesign3.ForeColor = Color.Black;
            labelDesign3.Location = new Point(12, 298);
            labelDesign3.Name = "labelDesign3";
            labelDesign3.Size = new Size(130, 29);
            labelDesign3.TabIndex = 8;
            labelDesign3.Text = "Time Late";
            labelDesign3.TextColor = Color.Black;
            // 
            // labelDesign4
            // 
            labelDesign4.AutoSize = true;
            labelDesign4.BackColor = Color.BurlyWood;
            labelDesign4.BackgroundColor = Color.BurlyWood;
            labelDesign4.BorderColor = Color.PaleVioletRed;
            labelDesign4.BorderRadius = 15;
            labelDesign4.BorderSize = 0;
            labelDesign4.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point);
            labelDesign4.ForeColor = Color.Black;
            labelDesign4.Location = new Point(12, 240);
            labelDesign4.Name = "labelDesign4";
            labelDesign4.Size = new Size(119, 29);
            labelDesign4.TabIndex = 9;
            labelDesign4.Text = "Check In";
            labelDesign4.TextColor = Color.Black;
            // 
            // labelDesign5
            // 
            labelDesign5.AutoSize = true;
            labelDesign5.BackColor = Color.BurlyWood;
            labelDesign5.BackgroundColor = Color.BurlyWood;
            labelDesign5.BorderColor = Color.PaleVioletRed;
            labelDesign5.BorderRadius = 15;
            labelDesign5.BorderSize = 0;
            labelDesign5.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point);
            labelDesign5.ForeColor = Color.Black;
            labelDesign5.Location = new Point(12, 180);
            labelDesign5.Name = "labelDesign5";
            labelDesign5.Size = new Size(144, 29);
            labelDesign5.TabIndex = 10;
            labelDesign5.Text = "Time Class";
            labelDesign5.TextColor = Color.Black;
            // 
            // labelDesign6
            // 
            labelDesign6.AutoSize = true;
            labelDesign6.BackColor = Color.BurlyWood;
            labelDesign6.BackgroundColor = Color.BurlyWood;
            labelDesign6.BorderColor = Color.PaleVioletRed;
            labelDesign6.BorderRadius = 15;
            labelDesign6.BorderSize = 0;
            labelDesign6.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point);
            labelDesign6.ForeColor = Color.Black;
            labelDesign6.Location = new Point(12, 124);
            labelDesign6.Name = "labelDesign6";
            labelDesign6.Size = new Size(125, 29);
            labelDesign6.TabIndex = 11;
            labelDesign6.Text = "FullName";
            labelDesign6.TextColor = Color.Black;
            labelDesign6.Click += labelDesign6_Click;
            // 
            // timeclass
            // 
            timeclass.Location = new Point(232, 180);
            timeclass.Name = "timeclass";
            timeclass.Size = new Size(161, 23);
            timeclass.TabIndex = 12;
            // 
            // checkin
            // 
            checkin.Location = new Point(232, 240);
            checkin.Name = "checkin";
            checkin.Size = new Size(161, 23);
            checkin.TabIndex = 13;
            // 
            // timelate
            // 
            timelate.Location = new Point(232, 298);
            timelate.Name = "timelate";
            timelate.Size = new Size(161, 23);
            timelate.TabIndex = 14;
            timelate.TextChanged += timelate_TextChanged;
            // 
            // labelDesign7
            // 
            labelDesign7.AutoSize = true;
            labelDesign7.BackColor = Color.BurlyWood;
            labelDesign7.BackgroundColor = Color.BurlyWood;
            labelDesign7.BorderColor = Color.PaleVioletRed;
            labelDesign7.BorderRadius = 15;
            labelDesign7.BorderSize = 0;
            labelDesign7.Font = new Font("Verdana", 18F, FontStyle.Italic, GraphicsUnit.Point);
            labelDesign7.ForeColor = Color.Black;
            labelDesign7.Location = new Point(12, 355);
            labelDesign7.Name = "labelDesign7";
            labelDesign7.Size = new Size(89, 29);
            labelDesign7.TabIndex = 15;
            labelDesign7.Text = "Status";
            labelDesign7.TextColor = Color.Black;
            // 
            // status
            // 
            status.Location = new Point(232, 355);
            status.Name = "status";
            status.Size = new Size(161, 23);
            status.TabIndex = 16;
            // 
            // clickbutton1
            // 
            clickbutton1.BackColor = Color.Goldenrod;
            clickbutton1.BackgroundColor = Color.Goldenrod;
            clickbutton1.BorderColor = Color.PaleVioletRed;
            clickbutton1.BorderRadius = 20;
            clickbutton1.BorderSize = 0;
            clickbutton1.FlatAppearance.BorderSize = 0;
            clickbutton1.FlatStyle = FlatStyle.Flat;
            clickbutton1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            clickbutton1.ForeColor = Color.Black;
            clickbutton1.Location = new Point(506, 354);
            clickbutton1.Name = "clickbutton1";
            clickbutton1.Size = new Size(94, 40);
            clickbutton1.TabIndex = 17;
            clickbutton1.Text = "Thoát ";
            clickbutton1.TextColor = Color.Black;
            clickbutton1.UseVisualStyleBackColor = false;
            clickbutton1.Click += clickbutton1_Click;
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(612, 403);
            Controls.Add(clickbutton1);
            Controls.Add(status);
            Controls.Add(labelDesign7);
            Controls.Add(timelate);
            Controls.Add(checkin);
            Controls.Add(timeclass);
            Controls.Add(labelDesign6);
            Controls.Add(labelDesign5);
            Controls.Add(labelDesign4);
            Controls.Add(labelDesign3);
            Controls.Add(fullname);
            Controls.Add(studentcode);
            Controls.Add(labelDesign2);
            Controls.Add(labelDesign1);
            ForeColor = SystemColors.ControlDark;
            Margin = new Padding(2);
            Name = "ShowForm";
            Text = "ShowForm";
            Load += ShowForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Design.LabelDesign labelDesign1;
        private Design.LabelDesign labelDesign2;
        private TextBox studentcode;
        private TextBox fullname;
        private Design.LabelDesign labelDesign3;
        private Design.LabelDesign labelDesign4;
        private Design.LabelDesign labelDesign5;
        private Design.LabelDesign labelDesign6;
        private TextBox timeclass;
        private TextBox checkin;
        private TextBox timelate;
        private Design.LabelDesign labelDesign7;
        private TextBox status;
        private Design.Clickbutton clickbutton1;
    }
}