namespace UserAccountNamespace
{
    public partial class frmLoginAccount : Form
    {
        private Cashier currentUser;
        public frmLoginAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

           
            currentUser = new Cashier("Christian Lat", "366803");

            if (currentUser.ValidateCredentials(username, password))
            {
                MessageBox.Show("Welcome Christian Lat!");

                
                frmPurchaseDiscountedItem firstForm = new frmPurchaseDiscountedItem();
                
                this.Hide(); 
                firstForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            }
        }
    }  
}

namespace UserAccountNamespace
    {
        public class UserAccount
        {
            public string Username { get; set; }
            public string Password { get; set; }


            public UserAccount(string username, string password)
            {
                Username = username;
                Password = password;
            }

            public bool ValidateCredentials(string username, string password)
            {
                return Username == username && Password == password;
            }
        }

        public class Cashier : UserAccount
        {
            public Cashier(string username, string password)
                : base(username, password)
            {
        }
    }
}


   
