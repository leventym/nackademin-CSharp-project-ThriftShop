using System;
using System.Data;
using System.Windows.Forms;

namespace ThriftShop
{
    public partial class FormMain : Form
    {
        //Definierar medlemsvariabler
        private User user;
        private FormAd AdForm;
        private DatabaseMethods dm;
        private DataTable dt;
        private bool loggedIn = false;
        
        public FormMain()
        {
            InitializeComponent();

            //Skapar objekt
            dm = new DatabaseMethods();
            user = new User();
            
            //tilldelar funktionen getallads till dt OCH visar innehållet i datagridview
            this.dt = dm.getAllAds();
            dataGridView1.DataSource = this.dt;

        }

        public void refreshTable()
        {
            this.dt = dm.getAllAds();
            dataGridView1.DataSource = this.dt;
        }


        //Placerar panelStart i förgrunden
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leventsDBDataSet.Annons' table. You can move, or remove it, as needed.
            //this.annonsTableAdapter.Fill(this.leventsDBDataSet.Annons);
            
            
            panelStart.BringToFront();
            this.dataGridView1.Columns["id"].Visible = false;

           

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
            bool accountCreated = user.createAccount(textBoxNewUsername.Text, textBoxNewPassword.Text, textBoxNewEmail.Text);
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
            loggedIn = user.loginToAccount(textBoxUserName.Text, textBoxPassword.Text);
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
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
        }

        
        //Placerar panelLogin i förgrunden
        private void buttonBackCreateNewAccount_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        
        //Metod för att redigera annons. Bara inloggad användare kan rediegra sin annons. Medan man redigerar kan man även radera.
        private void buttonEditAd_Click(object sender, EventArgs e)
        {
            // Kontrollera att användarnamnet på den som är inloggad matchar med annonsens användarnamn kolumn
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            Ad editAd = new Ad() ;
            string annonsSkapare = row.Cells["Säljare"].Value.ToString();
            if(annonsSkapare == User.userName)
            {
                editAd.adID = (int)row.Cells["id"].Value;
                editAd.title = row.Cells["Titel"].Value.ToString();
                editAd.description = row.Cells["Beskrivning"].Value.ToString();
                editAd.price = (double)row.Cells["Pris"].Value;
                editAd.categoryName = row.Cells["Säljare"].Value.ToString();

                AdForm = new FormAd();
                AdForm.parent = this;
                AdForm.EditAd(editAd);
                AdForm.Show();
            }
            else
            {
                MessageBox.Show("Du har inte behörighet att redigera denna annons.");
            }
        }


        //Läser in input från textfält och utför sökning när man klicka på sök-knappen.
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' AND [{2}] LIKE '%{3}%'", "Titel", textBoxSearchTitle.Text,
                "Kategori", textBoxSearchCategory.Text);
        }

        
        //Rensar sökfälten
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSearchTitle.Text = "";
            textBoxSearchCategory.Text = "";
            dt.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%' AND [{2}] LIKE '%{3}%'", "Titel", textBoxSearchTitle.Text,
                "Kategori", textBoxSearchCategory.Text);
        }

        
        //När man dubbelklickar på beskrivning så dyker ny ruta upp
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string content = row.Cells["Beskrivning"].Value.ToString();
            MessageBox.Show("Beskrivning: " + content);
        }
    }
}