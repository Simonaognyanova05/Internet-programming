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
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(txtWeight.Text);
            double height = Convert.ToDouble(txtHeight.Text);

            double bmi = CalculateBMI(weight, height);

            lblBMIResult.Text = $"Вашият БМИ е: {bmi:F2}";

            string bmiCategory = GetBMICategory(bmi);
            lblBMICategory.Text = $"Категория: {bmiCategory}";
        }

        private double CalculateBMI(double weight, double height)
        {
            return weight / (height * height);
        }

        private string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
                return "Поднормено тегло";
            else if (bmi < 24.9)
                return "Нормално тегло";
            else if (bmi < 29.9)
                return "Наднормено тегло";
            else
                return "Затлъстяване";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
    
}
