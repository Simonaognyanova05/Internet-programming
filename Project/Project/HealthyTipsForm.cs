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
    public partial class HealthyTipsForm : Form
    {
        public HealthyTipsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tips = GetHealthyTips();
            Random random = new Random();
            int randomIndex = random.Next(tips.Length);

            lblHealthyTip.Items.Add(tips[randomIndex]);
        }

        private string[] GetHealthyTips()
        {
            return new string[]
            {
            "Правете редовни физически упражнения.",
            "Контролирайте хранителния си режим и консумацията на калории.",
            "Консумирайте достатъчно вода за правилно функциониране на организма.",
            "Избягвайте никотин и алкохол.",
            "Спите достатъчно - 7-9 часа са препоръчителни за повечето възрастни.",
            "Управлявайте стреса и научете техники за релаксация.",
            "Консумирайте разнообразна и балансирана храна с много плодове и зеленчуци.",
            "Редовно проверявайте кръвното си налягане и кръвния си захар."
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void lblHealthyTip_Click(object sender, EventArgs e)
        {

        }

        private void lblHealthyTip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
