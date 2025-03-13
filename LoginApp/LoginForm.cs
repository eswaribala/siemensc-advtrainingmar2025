namespace LoginApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(LoginValidator.ValidateLoginData));
        }

        public static void ValidateLoginData(object userObject)
        {
            User user = (User)userObject;
            if (user.Username == "admin" && user.Password == "admin")
            {
                lblStatus.Text = "Login successful!";
            }
            else
            {
                lblStatus.Text = "Login unsuccessful!";
            }
        }
    }
}
