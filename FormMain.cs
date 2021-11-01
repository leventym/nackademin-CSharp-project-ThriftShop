using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThriftShop
{
    public partial class FormMain : Form
    {
        public string _sqlConnectinStr = ConfigurationManager.ConnectionStrings["ThriftShop.Properties.Settings.LeventsDBConnectionString"].ConnectionString; //Connection till Databasen
        SqlConnection conn; //Variabel för kopplingen
        FormLogin loginForm;
        string currentUsername = "";
        bool loggedIn = false;
        

        public FormMain()
        {
            string userName = "1234anvandare1234";
            conn = new SqlConnection(_sqlConnectinStr); //Initera kopplingen med angivna connectionsträngen
            InitializeComponent();
            //string result = User.createAccount(userName, "losen123", "test@test.se", conn);
            //MessageBox.Show(result);

            if (User.loginToAccount(userName, "losen123", conn))
            {
                currentUsername = userName;
                MessageBox.Show("Inloggning lyckades.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelStart.BringToFront();

        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelStart.BringToFront();
        }

        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            panelCreateNewAccount.BringToFront();
        }

        private void buttonNewAccount_Click_1(object sender, EventArgs e)
        {
            panelCreateNewAccount.BringToFront();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            bool accountCreated = User.createAccount(textBoxNewUsername.Text, textBoxNewPassword.Text, textBoxNewEmail.Text, conn);
            if (accountCreated)
            {
                MessageBox.Show("Kontot skapat");
                panelLogin.BringToFront();
            }
        }

        private void buttonLoginLogin_Click(object sender, EventArgs e)
        {
            bool loggedIn = User.loginToAccount(textBoxUserName.Text, textBoxPassword.Text, conn);
            if(loggedIn == true)
            {
                MessageBox.Show("Inloggad!");
                currentUsername = textBoxUserName.Text;
                panelStart.BringToFront();
                buttonLogin.Visible = false;
                buttonAddAd.Visible = true;
                buttonEditAd.Visible = true;
            }
        }

        private void buttonAddAd_Click(object sender, EventArgs e)
        {
            if (loggedIn == true)
            {
                MessageBox.Show("Inloggad!");
                currentUsername = textBoxUserName.Text;
            }
        }
    }
}
