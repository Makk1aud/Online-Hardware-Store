using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Online_hardware_store.DataApp
{
    public static class DBInteractClass
    {
        public static string conString = "SERVER=LOCALHOST;DATABASE=online hardware store;UID=makklaud;PASSWORD=UAZ9233;";
        private static MySqlConnection con = new MySqlConnection(conString);

    }
}
