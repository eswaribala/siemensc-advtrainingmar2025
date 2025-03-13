namespace LoginApp
{
    public partial class LoginForm : Form
    {
       private SynchronizationContext synchronizationContext;
        

        public LoginForm()
        {
            InitializeComponent();
           synchronizationContext = SynchronizationContext.Current;


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login button clicked");

            //Thread thread = new Thread(new ParameterizedThreadStart(ValidateLoginData));
            //User user = new User();
            //user.Username = txtUserName.Text;
            //user.Password = txtPassword.Text;
            //thread.Start(user);

            Task.Run(() =>
            {
                // Simulate background work
                //Thread.Sleep(2000);
                // Update UI safely using SynchronizationContext

                if (txtUserName.Text == "admin" && txtPassword.Text == "admin")
                {
                    synchronizationContext.Post(_ => lblStatus.Text = "Status: Suceessful", null);
                }              
                 
                else
                    synchronizationContext.Post(_ => lblStatus.Text = "Status: Failed", null);
            });
        }

        
    }
}
