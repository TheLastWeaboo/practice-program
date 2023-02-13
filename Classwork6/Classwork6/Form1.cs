namespace Classwork6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordlbl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            if ((txtUsername.Text == "admin") && (txtPassword.Text == "123"))
            {
                frmMain mainMenu = new frmMain();
                mainMenu.Show();
                this.Hide();
            }
            else if ((txtUsername.Text == "administrator") && (txtPassword.Text == "1234"))
            {
                frmMain mainMenu = new frmMain();
                mainMenu.Show();
                this.Hide();
            }
            else if ((txtUsername.Text == "user") && (txtPassword.Text == "pogiako123"))
            {
                frmMain mainMenu = new frmMain();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password, please try again");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
;            }
;
        }
    }
}