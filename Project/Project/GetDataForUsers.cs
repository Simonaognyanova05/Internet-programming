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

namespace Project
{
    public partial class GetDataForUsers : Form
    {
        public GetDataForUsers()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=loginBase.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Diet";
            da = new OleDbDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Изчистване на съдържанието на listbox1
            listBox1.Items.Clear();

            // Проверка дали има поне един ред в таблицата
            if (dt.Rows.Count > 0)
            {
                // Прохождане през всички редове и добавяне на "name" в ListBox
                foreach (DataRow row in dt.Rows)
                {
                    // Предполага се, че има колона "name" в таблицата "Diet"
                    string day = row["Day"].ToString();
                    string breakfast = row["Breakfast"].ToString();
                    string lunch = row["Lunch"].ToString();
                    string dinner = row["Dinner"].ToString();


                    listBox1.Items.Add("Ден: " + day + ": " + "Закуска - " + breakfast + "; Обяд - " + lunch + "; Вечеря - " + dinner);
                }
            }
            else
            {
                listBox1.Items.Add("Няма данни");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
