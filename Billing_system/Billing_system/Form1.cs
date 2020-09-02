using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Billing_system
{
    
public partial class Form1 : Form
    {
         public Form1()
        {
            InitializeComponent();
        }
        // строка подключения
        private const string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dasha\Desktop\Billing_system\Billing_system\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        private void Main_Form_Load(object sender, EventArgs e)
        {
            UpdateAbonentDgv();
        }
        private void UpdateAbonentDgv()
        {
            int kolvoabonent = 0;
            var request = "SELECT *FROM Biling_abonent";
            var adapter = new SqlDataAdapter(request, connectionStr);
            var abonentTable = new DataTable();
            adapter.Fill(abonentTable);
            DATA_Abonent.DataSource = abonentTable;
            DATA_Abonent.Columns["Id_Abonent"].Visible = false;
            DATA_Abonent.Columns["Name_Abonent"].HeaderText = "Имя";
            DATA_Abonent.Columns["Surname_Abonent"].HeaderText = "Фамилия";
            DATA_Abonent.Columns["Tarif"].HeaderText = "Тариф";
            DATA_Abonent.Columns["Date_Registration"].HeaderText = "Начало обслуживания";
            DATA_Abonent.Columns["Period_Dogovor"].HeaderText = "Период действия договора";

            Random rnd = new Random();
            string Query5 = "SELECT * FROM Biling_abonent;";
            SqlConnection conDataBase1 = new SqlConnection(connectionStr);
            conDataBase1.Open();
            SqlCommand cmdDataBase1 = new SqlCommand(Query5, conDataBase1);
            SqlDataReader myReader1;
             try
            {
                myReader1 = cmdDataBase1.ExecuteReader();
                while (myReader1.Read())
                {
                    kolvoabonent++;
                }
            }
             catch { }
             conDataBase1.Close();
           var connection = new SqlConnection(connectionStr);
          connection.Open();

           var req = "INSERT INTO Biling_seans (Time_Start, Time_End, Tarif, Type_data, Size_byte,Id_Abonent_For_Seans) VALUES ('" + 11 + "." + rnd.Next(1, 15).ToString() + "." + 2019 + "', '" + 11 + "." + rnd.Next(15, 28).ToString() + "." + 2019 + "', '" + rnd.Next(1, 12).ToString() + "', '" + rnd.Next(1, 4) + "', '" + rnd.Next(1, 128) + "', '" + rnd.Next(1, kolvoabonent++) + "');";
            var command = new SqlCommand(req, connection);
           command.ExecuteNonQuery();
          }
        private void Add_abonent_Click(object sender, EventArgs e)
        {
            Add_abonent form = new Add_abonent();   
            if (form.ShowDialog() == DialogResult.OK)
            {
                var connection = new SqlConnection(connectionStr);
                connection.Open();
                var req = "INSERT INTO Biling_abonent (Name_Abonent, Surname_Abonent, Biling_abonent.Tarif, Date_Registration, Period_dogovor) VALUES ('" + form.textBox_name.Text + "', '" + form.textBox_surname.Text + "', '" + form.textBox_tarif.Text + "', '" + form.textBox_start.Text + "', '" + form.textBox_period.Text + "');";
               
                var command = new SqlCommand(req, connection);
                command.ExecuteNonQuery();

                UpdateAbonentDgv();
            }
        }
       

        private void Edit_abonent_Click_1(object sender, EventArgs e)
        {
var row = DATA_Abonent.SelectedRows.Count > 0 ? DATA_Abonent.SelectedRows[0] : null;

            if (row != null)
            {
                Add_abonent form = new Add_abonent();
                form.textBox_name.Text = row.Cells["Name_Abonent"].Value.ToString();
                form.textBox_surname.Text = row.Cells["Surname_Abonent"].Value.ToString();
                form.textBox_tarif.Text = row.Cells["Tarif"].Value.ToString();
                form.textBox_start.Text = row.Cells["Date_Registration"].Value.ToString();
                form.textBox_period.Text = row.Cells["Period_Dogovor"].Value.ToString();
                


                if (form.ShowDialog() == DialogResult.OK)
                {
                    var connection = new SqlConnection(connectionStr);
                    connection.Open();
                    var req = "UPDATE Biling_abonent SET Name_Abonent = '" + form.textBox_name.Text + "', Surname_Abonent = '" + form.textBox_surname.Text + "', Tarif = '" + form.textBox_tarif.Text + "', Date_Registration = '" + form.textBox_start.Text + "', Period_Dogovor = ' " + form.textBox_period.Text + "'WHERE Id_Abonent = '" + row.Cells["Id_Abonent"].Value.ToString() + "'";
                    var command = new SqlCommand(req, connection);
                    command.ExecuteNonQuery();

                    UpdateAbonentDgv();
                    
                }

            }
        }

       
        private void Delete_abonent_Click(object sender, EventArgs e)
        {

            var row = DATA_Abonent.SelectedRows.Count > 0 ? DATA_Abonent.SelectedRows[0] : null;

            // if (form.ShowDialog() == DialogResult.OK)
            // {
            if (row != null)
            {
                var connection = new SqlConnection(connectionStr);
                connection.Open();
                var req = "DELETE Biling_abonent  WHERE Id_Abonent = '" + row.Cells["Id_Abonent"].Value.ToString() + "' ";
                var command = new SqlCommand(req, connection);
                command.ExecuteNonQuery();

                UpdateAbonentDgv();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Magic form = new Form_Magic();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void DATA_Abonent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
