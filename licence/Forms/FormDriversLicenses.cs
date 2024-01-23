using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace licence.Forms
{
    public partial class FormDriversLicenses : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbConnection con =
            new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=licence.accdb");
        public FormDriversLicenses()
        {

            InitializeComponent();

        }
        void GetDriLic()
        {
            dt = new DataTable();
            string selectCarLicenses = "SELECT Drivers.ID AS كود_السائق, Drivers.Name_Drivers AS الاسم , Drivers.phone AS رقم_الهاتف,Drivers.rank AS درجه, Drivers_license.License_Start as تاريخ_الاصدار, Drivers_license.License_End_date as تاريخ_الانتهاء " +
                           "FROM Drivers " +
                           "INNER JOIN Drivers_license ON Drivers.ID = Drivers_license.ID_Drivers";
            adapter = new OleDbDataAdapter(selectCarLicenses, con);
            con.Open();
            adapter.Fill(dt);
            DataLicensesDriver.DataSource = dt;
            con.Close();
        }
        void LicensesMonth()
        {
            var endDate = DateTime.Now.AddMonths(1);
            dt = new DataTable();
            string selectCarLicenses = "SELECT Drivers.ID AS كود_السائق, Drivers.Name_Drivers AS الاسم, Drivers.phone AS رقم_الهاتف, Drivers.rank AS درجه, Drivers_license.License_Start as تاريخ_الاصدار, Drivers_license.License_End_date as تاريخ_الانتهاء " +
                                       "FROM Drivers " +
                                       "INNER JOIN Drivers_license ON Drivers.ID = Drivers_license.ID_Drivers " +
                                       "WHERE License_End_date >= #" + DateTime.Now.ToString("MM/dd/yyyy") + "# AND License_End_date <= #" + endDate.ToString("MM/dd/yyyy") + "#";
            adapter = new OleDbDataAdapter(selectCarLicenses, con);
            con.Open();
            adapter.Fill(dt);
            DataLicensesDriver.DataSource = dt;
            con.Close();



        }
        void EndLicenses()
        {
            DataLicensesDriver.DataSource = null;
            var DateNow = DateTime.Now.ToString("MM/dd/yyyy");
            dt = new DataTable();
            adapter = new OleDbDataAdapter($"SELECT " +
                $"(select  ID from Drivers where ID = Drivers_license.ID_Drivers) as كود_السائق ," +
                $"(select  Name_Drivers from Drivers where ID = Drivers_license.ID_Drivers) as الاسم ," +
                $"(select  phone from Drivers where ID = Drivers_license.ID_Drivers) as رقم_الهاتف ," +
                $"(select  rank from Drivers where ID = Drivers_license.ID_Drivers) as الدرجه ," +
                $"License_Start as تاريخ_الاصدار , License_End_date as تاريخ_الانتهاء  FROM Drivers_license " +
                $"Where License_End_date < # {DateNow} # ORDER BY id ASC", con);
            con.Open();
            adapter.Fill(dt);
            DataLicensesDriver.DataSource = dt;
            con.Close();
        }
        private void FormDriversLicenses_Load(object sender, EventArgs e)
        {
            GetDriLic();
            DataLicensesDriver.BackgroundColor = Color.FromArgb(153, 180, 209);
            DataLicensesDriver.ForeColor = Color.DarkBlue;
            DataLicensesDriver.GridColor = Color.Navy;
            DataLicensesDriver.DefaultCellStyle.Font = new Font("Arial", 14);
            DataLicensesDriver.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(189, 235, 240);
            DataLicensesDriver.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            DataLicensesDriver.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataLicensesDriver.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void AllLicence_Click(object sender, EventArgs e)
        {
            GetDriLic();
        }

        private void Licenses_Month_Click(object sender, EventArgs e)
        {
            LicensesMonth();
        }

        private void end_Click(object sender, EventArgs e)
        {
            EndLicenses();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            string filterExpression = string.Format("الاسم LIKE '%{0}%'", search.Text);
            dv.RowFilter = filterExpression;
            DataLicensesDriver.DataSource = dv;
        }
    }
}
