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
        FormAd AdForm;

        DatabaseMethods dm;

        private int userID = -1;
        private bool loggedIn = false;
        
        public FormMain()
        {
            string userName = "1234anvandare1234";
            conn = new SqlConnection(_sqlConnectinStr); //Initera kopplingen med angivna connectionsträngen
            InitializeComponent();
            //string result = User.createAccount(userName, "losen123", "test@test.se", conn);
            //MessageBox.Show(result);

            if (User.loginToAccount(userName, "losen123", conn))
            {
 
                MessageBox.Show("Inloggning lyckades.");
            }

            dm = new DatabaseMethods();
            dataGridView1.DataSource = dm.getAllAds();


        }

        public void refreshTable()
        {
            dataGridView1.DataSource = dm.getAllAds();
        }

        //Placerar panelStart i förgrunden
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leventsDBDataSet.Annons' table. You can move, or remove it, as needed.
            this.annonsTableAdapter.Fill(this.leventsDBDataSet.Annons);
            panelStart.BringToFront();

        }

        //Placerar panelLogin i förgrunden
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        //Placerar panelStart i förgrunden
        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelStart.BringToFront();
        }

        //Placerar panelCreateNewAccount i förgrunden
        private void buttonNewAccount_Click(object sender, EventArgs e)
        {
            panelCreateNewAccount.BringToFront();
        }

        //Placerar panelCreateNewAccount i förgrunden
        private void buttonNewAccount_Click_1(object sender, EventArgs e)
        {
            panelCreateNewAccount.BringToFront();
        }

        //Kollar om användaren är inloggad & Placerar panelLogin i förgrunden
        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            bool accountCreated = User.createAccount(textBoxNewUsername.Text, textBoxNewPassword.Text, textBoxNewEmail.Text, conn);
            if (accountCreated)
            {
                MessageBox.Show("Kontot skapat");
                panelLogin.BringToFront();
            }
        }

        //Kollar om användaren är inloggad & Placerar panelLogin i förgrunden
        //Visar och döljer knappar.
        private void buttonLoginLogin_Click(object sender, EventArgs e)
        {
            loggedIn = User.loginToAccount(textBoxUserName.Text, textBoxPassword.Text, conn);
            if (loggedIn == true)
            {
                MessageBox.Show("Inloggad!");
                panelStart.BringToFront();
                buttonLogin.Visible = false;
                buttonAddAd.Visible = true;
                buttonEditAd.Visible = true;
                buttonLogout.Visible = true;
            }
        }

        //Om inloggad och knappen skapa ny annons klockas initieras FormAd
        private void buttonAddAd_Click(object sender, EventArgs e)
        {
            if (loggedIn == true)
            {
                AdForm = new FormAd();
                AdForm.parent = this;
                AdForm.Show();
            }
        }

        //Om logga ut knappen klickas döljs och visas knappar och sttaus för inloggad blir false.
        //Panelen panelStart placeras i förgrunden.
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            buttonLogout.Visible = false;
            buttonLogin.Visible = true;
            buttonAddAd.Visible = false;
            buttonEditAd.Visible = false;
            loggedIn = false;
            User.userID = -1;
            panelStart.BringToFront();
        }

        //Placerar panelLogin i förgrunden
        private void buttonBackCreateNewAccount_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void buttonEditAd_Click(object sender, EventArgs e)
        {
            // Kontrollera att användarnamnet på den som är inloggad matchar med annonsens användarnamn kolumn
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Ad editAd = new Ad() ;
            editAd.adID =(int) row.Cells["id"].Value;
            editAd.title = row.Cells["titel"].Value.ToString();
            editAd.description = row.Cells["beskrivning"].Value.ToString();
            editAd.price = (double) row.Cells["pris"].Value;
            editAd.categoryName = row.Cells["namn"].Value.ToString();

            AdForm = new FormAd();
            AdForm.parent = this;
            AdForm.EditAd(editAd);
            AdForm.Show();



        }
    }
}
