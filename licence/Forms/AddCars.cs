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
    public partial class AddCars : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbConnection connection =
            new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=licence.accdb");
        public AddCars()
        {
            InitializeComponent();
        }
        private void AddCars_Load(object sender, EventArgs e)
        {
            GetAllCars();
            showcarslicenses.BackgroundColor = Color.FromArgb(153, 180, 209);
            showcarslicenses.ForeColor = Color.DarkBlue;
            showcarslicenses.GridColor = Color.Navy;
            showcarslicenses.DefaultCellStyle.Font = new Font("Arial", 14);
            showcarslicenses.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(189, 235, 240);
            showcarslicenses.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            showcarslicenses.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            showcarslicenses.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        void GetAllCars()
        {
            dt = new DataTable();
            string selectCarLicenses = "SELECT Cars.ID AS كود_السيارة, Cars.Number_Car AS رقم_السيارة, car_license.Start_License as الاصدار, car_license.End_License as الانتهاء ,cars.chassis as شاسيه ,cars.motor as موتور " +
                           "FROM Cars " +
                           "INNER JOIN car_license ON Cars.ID = car_license.Id_Car";
            adapter = new OleDbDataAdapter(selectCarLicenses, connection);
            connection.Open();
            adapter.Fill(dt);
            showcarslicenses.DataSource = dt;
            connection.Close();
        }
        private void showcarslicenses_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = showcarslicenses.CurrentRow.Cells[0].Value.ToString();
            NumberCar.Text = showcarslicenses.CurrentRow.Cells[1].Value.ToString();
            Start.Text = showcarslicenses.CurrentRow.Cells[2].Value.ToString();
            End.Text = showcarslicenses.CurrentRow.Cells[3].Value.ToString();
            motor.Text = showcarslicenses.CurrentRow.Cells[4].Value.ToString();
            chassis.Text = showcarslicenses.CurrentRow.Cells[5].Value.ToString();
        }
        private void INSERT_Click(object sender, EventArgs e)
        {
            if (NumberCar.Text != "" && motor.Text != "" && chassis.Text != "")
            {

                string QueryCars = "INSERT INTO Cars" +
                    " (Number_Car ,chassis ,motor) VALUES " +
                    "(@Number_Car,@chassis,@motor) ";
                cmd = new OleDbCommand(QueryCars, connection);
                cmd.Parameters.AddWithValue("@Number_Car", NumberCar.Text);
                cmd.Parameters.AddWithValue("@chassis", chassis.Text);
                cmd.Parameters.AddWithValue("@motor", motor.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                cmd = new OleDbCommand();
                //Car select id
                string QueryLincense = "SELECT ID FROM Cars WHERE Number_Car = @Number_Car";
                cmd = new OleDbCommand(QueryLincense, connection);
                cmd.Parameters.AddWithValue("@Number_Car", NumberCar.Text);
                connection.Open();
                string Id_Car = cmd.ExecuteScalar().ToString();
                connection.Close();

                // insert licenses
                cmd = new OleDbCommand();
                string QueryLicensesCars = "INSERT INTO car_license (Start_License ,End_License,Id_Car) VALUES " +
                    "(@Start_License, @End_License,@Id_Car) ";
                cmd = new OleDbCommand(QueryLicensesCars, connection);
                cmd.Parameters.AddWithValue("@Start_License", Start.Text);
                cmd.Parameters.AddWithValue("@End_License", End.Text);
                cmd.Parameters.AddWithValue("@Id_Car", Id_Car);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("تم تسجيل رخصه");
                GetAllCars();
            }
            else
                MessageBox.Show("قم بادخال جميع البيانات ");
        }
        
        private void UPDATE_Click(object sender, EventArgs e)
        {
            if(ID.Text != "")
            {
                string query = "UPDATE Cars " +
               "SET Number_Car = @Number_Car , chassis=@chassis , motor=@motor  " +
               "WHERE ID=@Id";
                cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@Number_Car", NumberCar.Text);
                cmd.Parameters.AddWithValue("@chassis", chassis.Text);
                cmd.Parameters.AddWithValue("@motor", motor.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID.Text));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                query = "UPDATE car_license " +
               "SET Start_License = @Start_License , End_License=@End_License  " +
               "WHERE Id_Car=@Id";
                cmd = new OleDbCommand(query, connection);
                cmd.Parameters.AddWithValue("@Start_License", Start.Text);
                cmd.Parameters.AddWithValue("@End_License", End.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID.Text));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("تم التعديل");
                GetAllCars();
            }else
                MessageBox.Show("قم بادخال جميع البيانات ");
        }

        private void DELETED_Click(object sender, EventArgs e)
        {
            string query = "delete from Cars where ID = @Id ";
            cmd = new OleDbCommand(query, connection);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(ID.Text));
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("تم حذف رخصه السياره ");
            GetAllCars();
        }
       
    }
}
