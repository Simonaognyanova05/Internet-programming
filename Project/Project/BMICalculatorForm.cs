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
            double weight = double.Parse(txtWeight.Text);
            double height = double.Parse(txtHeight.Text);

            double result = Math.Round(weight / (height * height), 2);

            if (result < 18.5)
            {
                lblBMICategory.Text = "Поднормено тегло";
            }
       
            else if (result <= 24.9 && result >= 18.5)
            {
                lblBMICategory.Text = "Нормално тегло";
            }
            else if (result <= 29.9 && result >= 25)
            {
                lblBMICategory.Text = "Наднормено тегло";
            }
            else
            {
                lblBMICategory.Text = "Затлъстяване";
            }

            string stringResult = result.ToString();
            lblBMIResult.Text = stringResult;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
