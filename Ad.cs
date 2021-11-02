using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThriftShop
{
    class Ad
    {
        public string title { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public int categoryID { get; set; }
        public int userID { get; set; }


        public bool isValid()
        {

            return (title == null || description == null || price == 0) ? true : false;

            // Pris får inte vara tomt
            // Får inte vara negativt 


        }

    }
}
