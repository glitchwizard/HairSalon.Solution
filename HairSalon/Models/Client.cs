﻿using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Client
    {
        public string Name { get; set; }
        public int id { get; set; }
        public int stylist_id { get; set; }

        public Client(string clientName, int stylistId, int clientId = 0)
        {
            this.Name = clientName;
            this.id = clientId;
            this.stylist_id = stylistId;
        }

        public override bool Equals(System.Object otherClient)
        {
            if (!(otherClient is Client))
            {
                return false;
            }
            else
            {
                Client newClient = (Client)otherClient;
                bool idEquality = this.id.Equals(newClient.id);
                bool nameEquality = this.Name.Equals(newClient.Name);
                bool stylist_idEquality = this.stylist_id.Equals(newClient.stylist_id);
                return (idEquality && nameEquality && stylist_idEquality);
            }
        }

        public static void ClearAll()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM clients";
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public void Save() // Create
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"INSERT INTO clients (clientname, stylist_id) values (@clientname, @stylist_id);";
            cmd.Parameters.AddWithValue("@clientName", this.Name);
            cmd.Parameters.AddWithValue("@stylist_id", this.stylist_id);
            cmd.ExecuteNonQuery();
            id = (int)cmd.LastInsertedId;
            conn.Close();

            if (conn != null)
            {
                conn.Dispose();
            }
        }

        public static List<Client> GetAll()
        {
            List<Client> allClients = new List<Client> { };

            MySqlConnection conn = DB.Connection();
            conn.Open();
            var cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM clients;";
            var rdr = cmd.ExecuteReader() as MySqlDataReader;
            while (rdr.Read())
            {
                int clientId = rdr.GetInt32(0);
                string clientName = rdr.GetString(1);
                int stylist_id = rdr.GetInt32(2);
                Client newClient = new Client(clientName, stylist_id, clientId);
                allClients.Add(newClient);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allClients;
        }

        public static Client Find(int searchId)
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM clients WHERE id = (@searchId);";
            cmd.Parameters.AddWithValue("@searchId", searchId);
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            int ClientId = 0;
            string ClientName = "";
            int StylistId = 0;

            while (rdr.Read())
            {
                ClientId = rdr.GetInt32(0);
                ClientName = rdr.GetString(1);
                StylistId = rdr.GetInt32(2);
            }
            Client newClient = new Client(ClientName, StylistId, ClientId);
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }

            return newClient;
        }
    }
}