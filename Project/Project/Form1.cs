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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFitnessTracker_Click(object sender, EventArgs e)
        {
            FitnessTrackerForm fitnessTrackerForm = new FitnessTrackerForm();
            fitnessTrackerForm.ShowDialog();
        }

        private void btnOpenDietPlanner_Click(object sender, EventArgs e)
        {
            DietPlannerForm dietPlannerForm = new DietPlannerForm();
            dietPlannerForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BMICalculatorForm bMICalculatorForm = new BMICalculatorForm();
            bMICalculatorForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HealthyTipsForm healthyTipsForm = new HealthyTipsForm();
            healthyTipsForm.ShowDialog();


        }
    }
}
