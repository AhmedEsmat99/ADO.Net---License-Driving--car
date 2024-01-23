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
    public partial class CRUD_Driver : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbConnection connection =
            new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=licence.accdb");
        public CRUD_Driver()
        {
            InitializeComponent();
        }
        private void CRUD_Driver_Load(object sender, EventArgs e)
        {
            GetAllDrivers();
            ShowDriverLicenses.BackgroundColor = Color.FromArgb(153, 180, 209);
            ShowDriverLicenses.ForeColor = Color.DarkBlue;
            ShowDriverLicenses.GridColor = Color.Navy;
            ShowDriverLicenses.DefaultCellStyle.Font = new Font("Arial", 14);
            ShowDriverLicenses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(189, 235, 240);
            ShowDriverLicenses.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            ShowDriverLicenses.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ShowDriverLicenses.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        void GetAllDrivers()
        {
            dt = new DataTable();
            string selectDriverLicenses = "SELECT Drivers.ID AS كود_السائق, Drivers.Name_Drivers AS الاسم ,Drivers.phone as رقم_الهاتف , Drivers.rank as الدرجه  ," +
                " Drivers_license.License_Start as الاصدار, Drivers_license.License_End_date as الانتهاء " +
                "FROM Drivers " +
                "INNER JOIN Drivers_license ON Drivers.ID = Drivers_license.ID_Drivers";
            adapter = new OleDbDataAdapter(selectDriverLicenses, connection);
            connection.Open();
            adapter.Fill(dt);
            ShowDriverLicenses.DataSource = dt;
            connection.Close();
        }
        private void ShowDriverLicenses_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = ShowDriverLicenses.CurrentRow.Cells[0].Value.ToString();
            name.Text = ShowDriverLicenses.CurrentRow.Cells[1].Value.ToString();
            phone.Text = ShowDriverLicenses.CurrentRow.Cells[2].Value.ToString();
            rank.Text = ShowDriverLicenses.CurrentRow.Cells[3].Value.ToString();
            Start.Text = ShowDriverLicenses.CurrentRow.Cells[4].Value.ToString();
            End.Text = ShowDriverLicenses.CurrentRow.Cells[5].Value.ToString();
        }
        private void INSERT_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && phone.Text != "" && rank.Text != "")
            {

                string QueryDriver = "INSERT INTO Drivers" +
                    " (Name_Drivers ,phone ,rank) VALUES " +
                    "(@Name_Drivers,@phone,@rank) ";
                cmd = new OleDbCommand(QueryDriver, connection);
                cmd.Parameters.AddWithValue("@Name_Drivers", name.Text);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@rank", rank.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                cmd = new OleDbCommand();
                //Car select id
                string QueryLincense = "SELECT ID FROM Drivers WHERE phone = @phone";
                cmd = new OleDbCommand(QueryLincense, connection);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                connection.Open();
                string Id_Driver = cmd.ExecuteScalar().ToString();
                connection.Close();
                // insert licenses
                cmd = new OleDbCommand();
                string QueryLicensesCars = "INSERT INTO Drivers_license (License_Start ,License_End_date,ID_Drivers) VALUES " +
                    "(@Start_License, @End_License,@Id_Car) ";
                cmd = new OleDbCommand(QueryLicensesCars, connection);
                cmd.Parameters.AddWithValue("@Start_License", Start.Text);
                cmd.Parameters.AddWithValue("@End_License", End.Text);
                cmd.Parameters.AddWithValue("@ID_Drivers", Id_Driver);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("تم تسجيل رخصه");
                GetAllDrivers();
            }
            else
                MessageBox.Show("قم بادخال جميع البيانات ");
        }
        private void UPDATE_Click(object sender, EventArgs e)
        {
            if (ID.Text != "")
            {
                string query = "UPDATE Drivers " +
               "SET Name_Drivers = @Name_Drivers , phone=@phone , rank=@rank  " +
               "WHERE ID=@Id";
                cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@Name_Drivers", name.Text);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@rank", rank.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID.Text));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                query = "UPDATE Drivers_license " +
               "SET License_Start = @License_Start , License_End_date=@License_End_date  " +
               "WHERE ID_Drivers=@Id";
                cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@License_Start", Start.Text);
                cmd.Parameters.AddWithValue("@License_End_date", End.Text);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(ID.Text));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("تم التعديل");
                GetAllDrivers();
            }
            else
                MessageBox.Show("قم بادخال جميع البيانات ");
        }
        private void DELETED_Click(object sender, EventArgs e)
        {
            string query = "delete from Drivers where ID = @Id ";
            cmd = new OleDbCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID.Text));
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("تم حذف رخصه السياره ");
            GetAllDrivers();
        }

        
    }
}
