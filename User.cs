using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThriftShop
{
    
    class User
    {
        public string _sqlConnectinStr = ConfigurationManager.ConnectionStrings["ThriftShop.Properties.Settings.LeventsDBConnectionString"].ConnectionString; //Connection till Databasen
        SqlConnection conn; //Variabel för kopplingen

        //Medlemsvariabler
        public static int userID { get; set;}
        public static string userName { get; set; }

        public User()
        {
            conn = new SqlConnection(_sqlConnectinStr); //Initera kopplingen med angivna connectionsträngen
        }

        
        //Metod för att skapa konto med antal kontroller och input variabler.
        public bool createAccount(string userName, string password, string email)
        {
            //Kollar om input variablerna är tomma
            if (userName == "" || password == "")
            {
                MessageBox.Show("Användarnamn eller lösenord saknas. Ange användarnamn och lösenord!");
                return false;
            }

            //Kolla om användaren finns redan
            using (SqlCommand cmdSelect = new SqlCommand("SELECT anvandarnamn FROM ANVANDARE where anvandarnamn='" + userName + "'", conn)) //Ange SQL kommando som ska skickas till db
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

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Användare finns redan");
                        return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
            }


            //Skapar ny post med ny användare
            using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO anvandare (anvandarnamn, losenord, email) VALUES ('" + userName + "','" + password + "','" + email + "')", conn))
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
                    return false;
                }
            }
            return true;
        }

        
        //Loggar in till konto. Kollar om fälten är tomma, om inte, hämtas användaren från db.
        public bool loginToAccount(string userName, string password)
        {
            if (userName == "" || password == "")
            {
                MessageBox.Show("Användarnamn eller lösenord saknas. Ange användarnamn och lösenord!");
                return false;
            }

            //SQL kommando för att hämta användaruppgifter som skrivits in
            using (SqlCommand cmdSelect = new SqlCommand("SELECT id,anvandarnamn FROM ANVANDARE where anvandarnamn='" + userName + "' AND losenord='" + password + "'", conn)) //Ange SQL kommando som ska skickas till db
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



                    if (table.Rows.Count == 1)
                    {
                        userID = (int) table.Rows[0].ItemArray[0];
                        User.userName = userName;
                        return true;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return false;
                }
                return false;
            }
        }


    }
}
