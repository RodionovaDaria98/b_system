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
    public partial class Form_Magic : Form
    {
        private const string abonentTblName = "Biling_abonent";
        // private const string tarifTblName = "Raschet ";//'это начало ериода
        private const string connectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dasha\Desktop\Billing_system\Billing_system\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        ///private string ConnectionString = global::Billing_system.Properties.Settings.Default.Database1ConnectionString;
        public Form_Magic()
        {
            InitializeComponent();
        }

        private void Filter()
        {
            string periodStr = "month,1";
            if (radioButton1.Checked)
            {
                periodStr = "month,1";
            }
            else if (radioButton2.Checked)
            {
                periodStr = "month,4";
            }
                 else if (radioButton3.Checked)
            {
                periodStr = "month,6";
            }
            else if (radioButton4.Checked)
            {
                periodStr = "month,12";
            }
            var date = calendarDateTimePicker.Value.ToString("MM.dd.yyyy");

            var request = @"SELECT Biling_abonent.Name_Abonent,  Biling_abonent.Surname_Abonent, 
'" + date + "' AS Date_Start,  DATEADD(" + periodStr + ",'" + date + @"') AS Date_End, 
SUM ( 
 CASE WHEN Biling_seans.Type_data=1 
 THEN DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End) / 60 * 1 
 ELSE 
  CASE WHEN Biling_seans.Type_data=2 
  THEN Biling_seans.Size_byte*10 
  ELSE DATEDIFF(second, Biling_seans.Time_Start, Biling_seans.Time_End)/3 
  END 
 END
) AS price
FROM Biling_seans JOIN Biling_abonent ON Biling_abonent.ID_Abonent=Biling_seans.Id_abonent_For_Seans 
WHERE  Surname_abonent LIKE '%" + textBox2.Text + @"%' AND 
 Name_abonent LIKE '%" + textBox1.Text + "%' AND Time_End > '" + date + @"' AND
 Time_End < DATEADD(" + periodStr + ",'" + date + @"') 
GROUP BY Biling_seans.Id_abonent_For_Seans, Biling_abonent.Name_Abonent, Biling_abonent.Surname_Abonent";

            var adapter = new SqlDataAdapter(request, connectionStr);
            var directoryTable = new DataTable();
            adapter.Fill(directoryTable);
            dataGridView1.DataSource = directoryTable;
            dataGridView1.Columns["Name_abonent"].HeaderText = "Имя";
            dataGridView1.Columns["Surname_abonent"].HeaderText = "Фамилия";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) Filter();        
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) Filter();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked) Filter();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked) Filter();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void calendarDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
