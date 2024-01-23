using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace licence.Forms
{
    public partial class FormCarLicenses : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbConnection con =
            new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=licence.accdb");
        public FormCarLicenses()
        {
            InitializeComponent();
        }
        void GetCarLic()
        {
            dt = new DataTable();
            string selectCarLicenses = "SELECT Cars.ID AS كود_السيارة, Cars.Number_Car AS رقم_السيارة, car_license.Start_License as تاريخ_الاصدار, car_license.End_License as تاريخ_الانتهاء " +
            "FROM Cars " +
            "INNER JOIN car_license ON Cars.ID = car_license.Id_Car";
            adapter = new OleDbDataAdapter(selectCarLicenses, con);
            con.Open();
            adapter.Fill(dt);
            DataLicensesCar.DataSource = dt;
            con.Close();
        }
        private void FormCarLicenses_Load(object sender, EventArgs e)
        {
            GetCarLic();
            DataLicensesCar.BackgroundColor = Color.FromArgb(153 ,180 ,209);
            DataLicensesCar.ForeColor = Color.DarkBlue;
            DataLicensesCar.GridColor = Color.Navy;
            DataLicensesCar.DefaultCellStyle.Font = new Font("Arial", 14);
            DataLicensesCar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(189 , 235 , 240);
            DataLicensesCar.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            DataLicensesCar.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataLicensesCar.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DataLicensesCar.DataSource = null;
            var DateNow = DateTime.Now.ToString("MM/dd/yyyy");
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT (select  ID from Cars where ID = car_license.Id_Car) as كود_السيارة ," +
                " (select  Number_Car from Cars where ID = car_license.Id_Car) as رقم_السيارة ," +
                "Start_License as تاريخ_الاصدار ,End_License as تاريخ_الانتهاء " +
                " FROM car_license where End_License < #" + DateNow + "# ORDER BY id ASC", con);
            con.Open();
            adapter.Fill(dt);
            DataLicensesCar.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataLicensesCar.DataSource = null;
            GetCarLic();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var endDate = DateTime.Now.AddMonths(1);
            dt = new DataTable();
            adapter = new OleDbDataAdapter("SELECT (select  ID from Cars where ID = car_license.Id_Car) as كود_السيارة ," +
                "(select  Number_Car from Cars where ID = car_license.Id_Car) as رقم_السيارة ," +
                "Start_License as تاريخ_الاصدار ,End_License as تاريخ_الانتهاء " +
                "FROM car_license WHERE End_License >= #" + DateTime.Now.ToString("MM/dd/yyyy") + "# AND End_License <= #" + endDate.ToString("MM/dd/yyyy") + "#", con);
            con.Open();
            adapter.Fill(dt);
            DataLicensesCar.DataSource = dt;
            con.Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            string filterExpression = string.Format("رقم_السيارة LIKE '%{0}%'", search.Text);
            dv.RowFilter = filterExpression;
            DataLicensesCar.DataSource = dv;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataLicensesCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
