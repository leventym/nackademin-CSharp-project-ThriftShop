using System;

namespace ThriftShop
{
    public class Ad
    {
        //Klassvariabler
        public string title { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int categoryID { get; set; }
        public int userID { get; set; }
        public int adID { get; set; }
        public string categoryName { get; set; }
        public string errorMessage { get; set; }
        
        
        //Initierar variabelrna i konstruktorn
        public Ad()
        {
            this.title = "";
            this.description = "";
            this.price = 0;
            this.categoryID = 0;
            this.userID = 0;
            this.errorMessage = "";
            this.categoryName = "";
            this.adID = 0;
        }

        //Validerar samtliga fält i skapande av ny annons.
        public bool isValid()
        {

                       
            if(title == "")
            {
                this.errorMessage = "Titel får inte vara tomt";
                return false;
            }
            else if(description == "")
            {
                this.errorMessage = "Beskrivning får inte vara tomt";
                return false;
            }
            else if(price == 0 || price < 0)
            {
                this.errorMessage = "Pris får inte vara 0 eller negativt tal.";
                return false;
            }
            return true;

            // om titel, beskrivning eller pris är tomt, returnera falskt

            
            // titel får inte vara tomt
            //Beskrivning får inte vara tomt
            // Pris får inte vara tomt
            // Får inte vara negativt 


        }


    }
}
