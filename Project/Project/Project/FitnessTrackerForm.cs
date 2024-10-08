﻿using System;
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
    public partial class FitnessTrackerForm : Form
    {
        public FitnessTrackerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int steps = Convert.ToInt32(txtSteps.Text);
            double distance = Convert.ToDouble(txtDistance.Text);
            TimeSpan time = TimeSpan.Parse(txtTime.Text);

            // Пример за извеждане на данните в лейбъл
            lblResult.Text = $"Брой стъпки: {steps}\nРазстояние: {distance} км\nВреме: {time}";

            // Други примери за логика с данните
            if (steps > 10000)
            {
                MessageBox.Show("Добре направено! Превишили сте 10 000 стъпки.", "Поздравление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не сте достигнали 10 000 стъпки. Продължавайте!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
