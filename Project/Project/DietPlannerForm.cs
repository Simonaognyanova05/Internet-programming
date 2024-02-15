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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class DietPlannerForm : Form
    {
        public DietPlannerForm()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=loginBase.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            string breakfast = (txtBreakfast.Text).ToLower();
            string lunch = (txtLunch.Text).ToLower();
            string dinner = (txtDinner.Text).ToLower();

            // Пример за извеждане на дневния хранителен план в лейбъл
            lblDietPlan.Text = $"Закуска: {breakfast}\nОбяд: {lunch}\nВечеря: {dinner}";

            // Други примери за логика с хранителния план
            if ((breakfast.Contains("яйца") && lunch.Contains("риба") && dinner.Contains("салата")) || (breakfast.Contains("овесени ядки") && lunch.Contains("месо") && dinner.Contains("салата")) || (breakfast.Contains("плодове") && lunch.Contains("супа") && dinner.Contains("риба")))
            {
                MessageBox.Show("Здравословен хранителен план!", "Поздравление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Препоръчително е да включите повече зеленчуци и белтъчини.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtBreakfast.Text == "" || txtLunch.Text == "" || txtDinner.Text == "" || txtPerson.Text == "")
            {
                MessageBox.Show("Невалидни данни");
            }
            else
            {
                con.Open();
                string register = "INSERT INTO Diet VALUES ('" + txtBreakfast.Text + "','" + txtLunch.Text + "','" + txtDinner.Text + "','" + txtPerson.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtBreakfast.Text = "";
                txtLunch.Text = "";
                txtDinner.Text = "";
                txtPerson.Text = "";

                this.Hide();
                GetDataForUsers getData = new GetDataForUsers();
                getData.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void lblDietPlan_Click(object sender, EventArgs e)
        {

        }

        private void txtBreakfast_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLunch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLunch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDinner_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
    
}
