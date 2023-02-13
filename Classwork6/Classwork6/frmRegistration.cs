using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork6
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Emerald_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbxLastName.Text + ", " + tbxFirstName.Text + " " + tbxMiddleInitial.Text;
            string Yearlevel = "";
            if (rbtn1st.Checked == true)
            {
                Yearlevel = "1st Year";
            }
            else if (rbtn2nd.Checked == true)
            {
                Yearlevel = "2nd Year";
            }
            else if (rbtn3rd.Checked == true)
            {
                Yearlevel = "3rd Year";
            }
            else if (rbtn4th.Checked == true)
            {
                Yearlevel = "4thd Year";
            }
            else
            {

            }
            string course = cbxCourse.SelectedItem.ToString();

            MessageBox.Show("NAME: " + name + Environment.NewLine +
                            "YearLevel: " + Yearlevel + Environment.NewLine +
                            "Course: " + course + Environment.NewLine + 
                            "Section: " + lblSection.Text, "STUDENT REGISTRATION");

            tbxLastName.Text = "";
            tbxFirstName.Text = "";
            tbxMiddleInitial.Text = "";
            lblSection.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void lsbSection_SelectedIndexChanged(object sender, EventArgs e)
        //{
          //  lblSection.Text = lsbSection.SelectedItem.ToString();
        //}

        private void rbtnBSIT_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void listbBox1_Click(object sender, EventArgs e)
        //{
         //   lblSection.Text = lsbSection.SelectedItem.ToString();
       // }

        private void frmRegistration_Load_1(object sender, EventArgs e)
        {

        }

        private void lsbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSection.Text = lsbSection.SelectedItem.ToString();
        }
    }
}
