using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClubManager.Models
{
    public class Club
    {       

        public Club()
        {

        }

        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string ImageURL { get; set; }
        public string ContactName { get; set; }     

    }
}