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

        public void ClearAll()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM stylists";
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public void Save()
        {

        }

        public static List<Stylist> GetAll()
        {
            List<Stylist> dummyList = new List<Stylist> { };
            return dummyList;
        }
    }

}
