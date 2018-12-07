using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
    public class Stylist
    {
        public string Name { get; set; }
        public int id { get; set; }


        public Stylist(string stylistName, int stylistId = 0)
        {
            //this.Name = stylistName;
            //this.id = stylistId;
        }
    }
}
