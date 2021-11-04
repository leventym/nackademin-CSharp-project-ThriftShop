using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ThriftShop
{
    class User
    {
        public static int userID { get; set;}
        public static string userName { get; set; }

        //Metod för att skapa konto med antal kontroller.
        public static bool createAccount(string userName, string password, string email, SqlConnection conn)
        {
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
                    /*
                    foreach(DataRow row in table.Rows)
                    {
                        foreach(var element in row.ItemArray)
                        {
                            MessageBox.Show(element.ToString());
                        }
                    }
                    */
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

        
        //Loggar in till konto. Kollar om fälten är tomma, om inte hämtas användaren från db.
        public static bool loginToAccount(string userName, string password, SqlConnection conn)
        {
            if (userName == "" || password == "")
            {
                MessageBox.Show("Användarnamn eller lösenord saknas. Ange användarnamn och lösenord!");
                return false;
            }

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
