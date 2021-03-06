using System;
using System.Windows.Forms;

namespace ThriftShop
{
    public partial class FormAd : Form
    {
        //Medlemsvariabler
        //Anger FormAds parent
        public FormMain parent { set; get; }
        public int adId{ set; get; }

        //Initierar DatabaseMethods klassen
        private DatabaseMethods db = new DatabaseMethods();
        public FormAd()
        {
            InitializeComponent();
            //Hämtar alla kategorier
            var result = db.GetCategories();
            
            // Lägg in result i i en combobox
            comboBoxCategory.DataSource = result;
            comboBoxCategoryEdit.DataSource = result;
            panelNewAd.BringToFront();
        }

        //Funktion för att redigera eller radera annons
        //Kallas från FormMain.cs, därför public
        public void EditAd(Ad ad)
        {
            panelEditAd.BringToFront();
            textBoxTitleEdit.Text = ad.title;
            textBoxDescriptionEdit.Text = ad.description;
            textBoxPriceEdit.Text = ad.price.ToString();
            comboBoxCategoryEdit.SelectedItem = ad.categoryName;
            this.adId = ad.adID;
        }

        //Funktion för att radera annons
        private void buttonDeleteEdit_Click(object sender, EventArgs e)
        {
            this.db.deleteAd(adId);
            parent.refreshTable();
            this.Close();
        }
        
        //Funktion för att avbryta
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funktion för att spara annons
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Initierar ny Ad
            Ad newAd = new Ad();
            newAd.userID = User.userID;
            
            //Hämtar kategoriID från dictionry
            newAd.categoryID = db.categoryDict[comboBoxCategory.Text];
            newAd.description = textBoxDescription.Text;
            newAd.title = textBoxTitle.Text;
            try
            {
                newAd.price = double.Parse(textBoxPrice.Text);
            }
            catch(Exception)
            {
                newAd.price = 0; 
            }

            if(newAd.isValid())
            {
                // Kalla db.createAd(newAd)
                db.CreateAd(newAd);
                parent.refreshTable();
                this.Close();
            }
            else
            {
                labelErrorMessage.Text = newAd.errorMessage;
                labelErrorMessage.Visible = true;
            }

            // Validera alla fält
            // Skapa annonsobjektet
            // Använd db objektet för att skapa annonsraden i databasen
            // stäng formuläaret
  
        }

        private void buttonCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Som save + en update
        private void buttonSaveEdit_Click(object sender, EventArgs e)
        {
            Ad editAd = new Ad();
            editAd.userID = User.userID;
            editAd.categoryID = db.categoryDict[comboBoxCategoryEdit.Text];
            editAd.description = textBoxDescriptionEdit.Text;
            editAd.title = textBoxTitleEdit.Text;
            editAd.adID = this.adId;
            try
            {
                editAd.price = double.Parse(textBoxPriceEdit.Text);
            }
            catch (Exception)
            {
                editAd.price = 0;
            }

            if (editAd.isValid())
            {
                // Kalla db.createAd(newAd)
                //Utför en update
                db.updateAd(editAd);
                parent.refreshTable();
                this.Close();
            }
            else
            {
                labelErrorMessage.Text = editAd.errorMessage;
                labelErrorMessage.Visible = true;
            }
        }

    }
}
