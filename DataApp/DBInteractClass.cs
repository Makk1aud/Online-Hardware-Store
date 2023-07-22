using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using MySql.Data.MySqlClient;

namespace Online_hardware_store.DataApp
{
    public static class DBInteractClass
    {
        public static string conString = "SERVER=LOCALHOST;DATABASE=online hardware store;UID=makklaud;PASSWORD=UAZ9233;";
        private static MySqlConnection con = new MySqlConnection(conString);

        public static void CheckConnection()
        {
            try 
            { 
                con.Open(); 
                con.Close();
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void OpenConnection()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public static void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        public static MySqlDataReader DbPullReader(string query)
        {
            OpenConnection();
            var command = new MySqlCommand(query, con);
            var reader = command.ExecuteReader();
            return reader;
        }

        public static string DbPullStringData(string query)
        {
            con.Open();
            try
            {
                var command = new MySqlCommand(query, con);
                return command.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static DataTable DbPullTable(string query)
        {
            
            con.Open();
            try
            {
                var adapter = new MySqlDataAdapter(query, con);
                var table = new DataTable();
                adapter.Fill(table);
                con.Close();
                return table;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                con.Close();
                return null;
            }
        }

        public static void FillingElement(Selector element, string memberPath, string valuePath)
        {
            element.DisplayMemberPath = memberPath;
            element.SelectedValuePath = valuePath;
        }
    }
}
