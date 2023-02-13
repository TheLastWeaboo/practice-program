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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void studentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistration registration = new frmRegistration();
            registration.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayment Payment = new frmPayment();
            Payment.Show();
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
