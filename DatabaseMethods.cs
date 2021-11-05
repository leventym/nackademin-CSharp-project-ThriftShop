using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThriftShop
{
    class DatabaseMethods
    {
        //Ansluter till DB
        private string _sqlConnectinStr = ConfigurationManager.ConnectionStrings["ThriftShop.Properties.Settings.LeventsDBConnectionString"].ConnectionString; //Connection till Databasen
        private SqlConnection conn;
        
        //En dictionary som innehåller nyckel, som är ett namn. Används när man hämtar kategoriID.
        public Dictionary<string, int> categoryDict = new Dictionary<string, int>();
        
        public DatabaseMethods()
        {
            conn = new SqlConnection(_sqlConnectinStr); //Initera kopplingen med angivna connectionsträngen
        }


        
        //funktion som hämtar alla tillgängliga kategorier från DB-tabellen
        public List<string> GetCategories()
        {
            //Initierar lista.
            List<string> listCategories = new List<string>();

            //Skickar SQL kommando för att hämta alla kategorier.
            using (SqlCommand cmdSelect = new SqlCommand("SELECT id,namn FROM Kategori", conn)) //Ange SQL kommando som ska skickas till db
            {
                try
                {

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    //Skapar ny data tabell som sedan fylls med svaret från DB-tabellen
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect);
                    adapter.Fill(table);

                   //Itirerar igenom tabllenn
                    foreach (DataRow row in table.Rows)
                    {
                        var id = (int)row.ItemArray[0];
                        var category = row.ItemArray[1].ToString();

                        //Lägger till innehållet i tabellen till dictionary OCH listan.
                        categoryDict.Add(category, id);
                        listCategories.Add(row.ItemArray[1].ToString());

                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return new List<String>();
                }
            }
            return listCategories;
        }

        
        //Funktion som skapar annons
        public void CreateAd(Ad newAd)
        {
            //Skickar SQL kommando
            using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO Annons (titel, beskrivning, pris, kategoriID, anvandareID) VALUES ('" + newAd.title + "','" + newAd.description + "','" + newAd.price + "','" + newAd.categoryID + "','" + newAd.userID + "')", conn))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    //Skickar SQL kommandot
                    cmdInsert.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

       
        //Metod som hämtar samtliga annonser i tabellen
        public DataTable getAllAds()
        {
            //Skspar ny tabell
            DataTable table = new DataTable();
            
            // Använd select för att hämta alla annonser (alla kolumner)
            using (SqlCommand cmdSelect = new SqlCommand("SELECT Annons.id, titel AS Titel, beskrivning AS Beskrivning, pris AS Pris, Kategori.namn AS Kategori, Annons.Datum AS Datum, Anvandare.anvandarnamn AS Säljare " +
                                                            "FROM Annons " +
                                                            "INNER JOIN Kategori " +
                                                            "ON Annons.KategoriID = Kategori.id " +
                                                            "INNER JOIN Anvandare " +
                                                            "ON Annons.anvandareID = Anvandare.id", conn))
            {
                try
                {

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect);
                    adapter.Fill(table);
                    

                    /*
                    foreach (DataRow row in table.Rows)
                    {
                        var id = row.ItemArray[0];
                        var title = row.ItemArray[1].ToString();
                        var description = row.ItemArray[2].ToString();
                        var price = row.ItemArray[3];

                        return table;
                    }
                    */
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return table;
        }

        
        //Uppdaterar existerande annons
        public void updateAd(Ad newAd)
        {
            
            using (SqlCommand cmdInsert = new SqlCommand("UPDATE Annons " +
                                                         "SET titel = '" + newAd.title + "'" +
                                                         ", beskrivning = '" + newAd.description + "'" +
                                                         ", pris = " + newAd.price + "" + 
                                                         ", kategoriID = " + newAd.categoryID + "" +
                                                         ", anvandareID = " + newAd.userID + "" + 
                                                         " WHERE Annons.id = " + newAd.adID + "", conn))
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmdInsert.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        
        //Metod för att radera annons med Entity Framework
        public void deleteAd(int annonsID)
        {
            
            try
            {
                LeventsDBEntities annonsContext = new LeventsDBEntities();
                annonsContext.DeleteAnnons(annonsID);
                annonsContext.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}