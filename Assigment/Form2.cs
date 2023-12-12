using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment
{
    public partial class Form2 : Form
    {
        private DataTable dataTable = new DataTable();

        public Form2()
        {
            InitializeComponent();

        }
        public SheetsService API()
        {
            string[] Scopes = { SheetsService.Scope.Spreadsheets };
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = GoogleWebAuthorizationBroker.AuthorizeAsync(new ClientSecrets
                {
                    ClientId = "36392620786-f8rbcns5pclnnnvbpj7392oi1p9g87pe.apps.googleusercontent.com",
                    ClientSecret = "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"
                }
            , Scopes, "user", CancellationToken.None, new FileDataStore("MyAppsToken")).Result,
                ApplicationName = "Google Sheets API .NET ",
            });
            return service;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                var service = API();
                var values = service.Spreadsheets.Values.Get("1Wcg80UudlfC-m_HnTKlfVA7InbNofRCUP9G0BBaVx0M", $"{"Object"}!A:G").Execute().Values;
                var listvalues = values.ToList();
                if (listvalues != null && values.Count > 0)
                {
                    // label2.Visible = true;
                    dataGridView1.Visible = true;
                    //this.Width = 1303;
                    this.CenterToScreen();
                }
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Student Code");
                dataTable.Columns.Add("Email");
                dataTable.Columns.Add("Fullname");
                dataTable.Columns.Add("Time in");
                dataTable.Columns.Add("Time out");
                dataTable.Columns.Add("Check in");
                dataTable.Columns.Add("Status");

                dataGridView1.DataSource = dataTable;

                foreach (var row in listvalues)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["Student Code"] = row[0].ToString();
                    dataRow["Email"] = row[1].ToString();
                    dataRow["Fullname"] = row[2].ToString();
                    dataRow["Time in"] = row[3].ToString();
                    dataRow["Time out"] = row[4].ToString();
                    dataRow["Check in"] = row.Count > 5 ? row[5].ToString() : null;
                    dataRow["Status"] = row.Count > 6 ? row[6].ToString() : null;
                    dataTable.Rows.Add(dataRow);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Visible = true;
                dataGridView1.Refresh();
                // Center the form on the screen.
                this.CenterToScreen();
            }

            catch { }
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            var service = API();
            var spreadsheetId = "1Wcg80UudlfC-m_HnTKlfVA7InbNofRCUP9G0BBaVx0M";
            var range = "Object!A:G";
            var request = service.Spreadsheets.Values.Get(spreadsheetId, range);
            var response = request.Execute();
            var values = response.Values;

            string Idstd = txtstudent.Texts.ToString();

            List<string[]> data = new List<string[]>();


            // Loop through the values to find the search text
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    if (row.Count > 0 && row[0].ToString().Equals(Idstd))
                    {
                        dataGridView1.DataSource = null;
                        if (dataTable.Rows.Count > 0)
                        {
                            dataTable.Rows.Clear();
                            dataTable.Columns.Clear();
                        }
                        dataTable.Columns.Add("Student Code");
                        dataTable.Columns.Add("Email");
                        dataTable.Columns.Add("Fullname");
                        dataTable.Columns.Add("Time in");
                        dataTable.Columns.Add("Time out");
                        dataTable.Columns.Add("Check in");
                        dataTable.Columns.Add("Status");
                        // Found the search text, add the row to the data list
                        DataRow dataRow = dataTable.NewRow();

                        // Set values for each column in the DataTable row
                        dataRow["Student Code"] = row.Count > 0 ? row[0].ToString() : null;
                        dataRow["Email"] = row.Count > 1 ? row[1].ToString() : null;
                        dataRow["Fullname"] = row.Count > 2 ? row[2].ToString() : null;
                        dataRow["Time in"] = row.Count > 3 ? row[3].ToString() : null;
                        dataRow["Time out"] = row.Count > 4 ? row[4].ToString() : null;
                        dataRow["Check in"] = row.Count > 5 ? row[5].ToString() : null;
                        dataRow["Status"] = row.Count > 6 ? row[6].ToString() : null;

                        // Add the row to the DataTable
                        dataTable.Rows.Add(dataRow);
                        dataGridView1.DataSource = dataTable;
                        break; // Exit the loop after finding the first match
                    }
                }
            }

            // Xóa dữ liệu hiện có của DataGridView trước khi thêm dữ liệu mới

            // Hiển thị kết quả tìm kiếm lên DataGridView
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin học sinh với mã số: " + Idstd);
            }
        }

        private void reloadbtn_Click(object sender, EventArgs e)
        {
            Form2_Load(sender, e);
        }

        private void tickbtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có sinh viên nào được chọn trong DataGridView hay không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                // Hiển thị thông báo nếu không có sinh viên nào được chọn
                MessageBox.Show("Vui lòng chọn một sinh viên trong danh sách.");
                return;
            }

            // Lấy chỉ số hàng của sinh viên được chọn
            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

            // Lấy giá trị của ô "Status" của sinh viên được chọn
            string selectedStatus = dataGridView1.Rows[selectedRowIndex].Cells["Status"].Value.ToString();

            // Lấy giá trị của ô "Check in" của sinh viên được chọn
            string selectedCheckIn = dataGridView1.Rows[selectedRowIndex].Cells["Check in"].Value.ToString();

            // Thay đổi giá trị của ô "Status" của sinh viên dựa trên giá trị hiện tại
            if (selectedStatus == "Present")
            {
                // Hiển thị thông báo hỏi người dùng nếu giá trị của ô "Status" là "Present"
                var confirmResult = MessageBox.Show("Đã điểm danh sinh viên này, có chắc muốn tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // Thay đổi giá trị của ô "Status" từ "Present" thành "Absent"
                    dataGridView1.Rows[selectedRowIndex].Cells["Status"].Value = "Absent";

                    // Cập nhật giá trị của ô "Check in" thành thời điểm nhấn nút
                }
            }
            else
            {
                // Nếu giá trị của ô "Status" không phải là "Present", thì thay đổi thành "Present"
                dataGridView1.Rows[selectedRowIndex].Cells["Status"].Value = "Present";

                // Cập nhật giá trị của ô "Check in" thành thời điểm nhấn nút
                dataGridView1.Rows[selectedRowIndex].Cells["Check in"].Value = DateTime.Now.ToString("HH:mm:ss");
            }
        }

    }
}
