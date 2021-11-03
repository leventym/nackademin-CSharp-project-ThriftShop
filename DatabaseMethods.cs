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
        private string _sqlConnectinStr = ConfigurationManager.ConnectionStrings["ThriftShop.Properties.Settings.LeventsDBConnectionString"].ConnectionString; //Connection till Databasen
        private SqlConnection conn;
        public Dictionary<string, int> categoryDict = new Dictionary<string, int>();
        
        public DatabaseMethods()
        {
            conn = new SqlConnection(_sqlConnectinStr); //Initera kopplingen med angivna connectionsträngen
        }


        //funktion som hämtar alla tillgängliga kategorier från db tabellen
        public List<string> GetCategories()
        {
            List<string> listCategories = new List<string>();

            using (SqlCommand cmdSelect = new SqlCommand("SELECT id,namn FROM Kategori", conn)) //Ange SQL kommando som ska skickas till db
            {
                try
                {

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmdSelect);
                    adapter.Fill(table);

                    foreach (DataRow row in table.Rows)
                    {
                        var id = (int)row.ItemArray[0];
                        var category = row.ItemArray[1].ToString();


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

        public void CreateAd(Ad newAd)
        {
            using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO Annons (titel, beskrivning, pris, kategoriID, anvandareID) VALUES ('" + newAd.title + "','" + newAd.description + "','" + newAd.price + "','" + newAd.categoryID + "','" + newAd.userID + "')", conn))
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

        public DataTable getAllAds()
        {
            DataTable table = new DataTable();
            // Använd select för att hämta alla annonser (alla kolumner)
            using (SqlCommand cmdSelect = new SqlCommand("SELECT Annons.id, titel, beskrivning, pris, Kategori.namn, Anvandare.anvandarnamn " +
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


    }
}
