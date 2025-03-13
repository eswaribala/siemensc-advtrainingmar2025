namespace LoginApp
{
    public partial class LoginForm : Form
    {
       // private SynchronizationContext synchronizationContext;
        

        public LoginForm()
        {
            InitializeComponent();
           // synchronizationContext = SynchronizationContext.Current;


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(ValidateLoginData));
            User user = new User();
            user.Username = txtUserName.Text;
            user.Password = txtPassword.Text;
            thread.Start(user);
        }

        public void ValidateLoginData(object userObject)
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
