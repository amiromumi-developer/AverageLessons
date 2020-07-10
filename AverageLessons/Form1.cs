using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Producer: Amirmohammad Omumi
//Instagram: amirmohammad_omumi
//twitter: amir_omumi
//linkdin: https://www.linkedin.com/in/amirmohammad-omumi-3b1393171

namespace AverageLessons
{
    public partial class AverageForm : Form
    {
        double avg = 0.0;
        double ratio = 0;
        double item;
        
        public AverageForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        bool ValiDateInput()
        {
            if (txtScore.Text == "")
            {
                MessageBox.Show("لطفا نمره درس را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtRatio.Text == "")
            {
                MessageBox.Show("لطفا واحد درس را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(lblResualt.Visible == true && lblAvg.Visible == true)
            {
                MessageBox.Show("لطفا ابتدا روی دکمه بازنشانی کلیک کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValiDateInput())
            {
                nextLssson.Visible = true;
                int Ratio = Convert.ToInt32(txtRatio.Text);
                double Score = Convert.ToDouble(txtScore.Text);
                ratio += Ratio;
                item += (Ratio * Score);
                txtScore.Text = "";
                txtRatio.Text = "";
            }
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {
            avg = item / ratio;
            nextLssson.Visible = false;
            double Avg = Math.Round(avg, 3);
            lblResualt.Text = Avg.ToString();
            lblAvg.Visible = true;
            lblResualt.Visible = true;
        }

        private void lblResualt_Click(object sender, EventArgs e)
        {
            double decimalsAvg = avg % 1;
            string lenAvg = decimalsAvg.ToString();
            MessageBox.Show("معدل : " + avg, "میانگین", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            avg = 0;
            ratio = 0;
            item = 0;
            lblResualt.Visible = false;
            txtScore.Text = "";
            txtRatio.Text = "";
            nextLssson.Visible = false;
            lblAvg.Visible = false;
        }
    }
}
