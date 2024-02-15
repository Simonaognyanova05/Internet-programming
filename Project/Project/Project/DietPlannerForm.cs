using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class DietPlannerForm : Form
    {
        public DietPlannerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string breakfast = txtBreakfast.Text;
            string lunch = txtLunch.Text;
            string dinner = txtDinner.Text;

            // Пример за извеждане на дневния хранителен план в лейбъл
            lblDietPlan.Text = $"Закуска: {breakfast}\nОбяд: {lunch}\nВечеря: {dinner}";

            // Други примери за логика с хранителния план
            if (breakfast.Contains("яйца") && lunch.Contains("салата"))
            {
                MessageBox.Show("Здравословен хранителен план!", "Поздравление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Препоръчително е да включите повече зеленчуци и белтъчини.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
    
}
