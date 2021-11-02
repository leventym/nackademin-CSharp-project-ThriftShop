using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThriftShop
{
    public partial class FormAd : Form
    {
        private DatabaseMethods db = new DatabaseMethods();
        public FormAd()
        {
            InitializeComponent();
            var result = db.GetCategories();
            // Lägg in result in combobox
            comboBoxCategory.DataSource = result;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Ad newAd = new Ad();
            newAd.userID = User.userID;
            newAd.categoryID = db.categoryDict[comboBoxCategory.Text];
            newAd.description = textBoxDescription.Text;
            newAd.title = textBoxTitle.Text;
            newAd.price = double.Parse(textBoxPrice.Text);


            if(newAd.isValid())
            {
                // Kalla db.createAd(newAd)
                db.CreateAd(newAd);
            }

            // Validera alla fält
            // Skapa annonsobjektet
            // Använd db objektet för att skapa annonsraden i databasen
            // stäng formuläaret




            this.Close();
        }
    }
}
