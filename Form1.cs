namespace Lab2DotNetAss
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //make hiding pass
            textpass.UseSystemPasswordChar = true;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //check if values are not empty
            if (string.IsNullOrWhiteSpace(textuser.Text) || string.IsNullOrWhiteSpace(textpass.Text))
            {
                MessageBox.Show("Please enter your username and password.");
                return;
            }

            //check if user and pass are correct
            if (textuser.Text.Trim().Equals("moise") //StringComparison.OrdinalIgnoreCase)
                && textpass.Text == "123@Mo45")
            {
                MessageBox.Show("Login successful!");

                //open menu form and close the login form
                Lab2DotNetAss.Menu menu = new Lab2DotNetAss.Menu();
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                textpass.Clear();
                textuser.Focus();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //make the window close
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}