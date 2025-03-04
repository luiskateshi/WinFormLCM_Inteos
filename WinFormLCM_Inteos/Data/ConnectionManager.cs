using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormLCM_Inteos.Data
{
    public static class ConnectionManager
    {
        private static readonly string projectPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
        private static readonly string databasePath = Path.Combine(projectPath, "db", "MaschinenLCM.mdf");
        private static readonly string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True;";

        //private static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\luis_\\source\\repos\\WinFormLCM_Inteos\\WinFormLCM_Inteos\\db\\MaschinenLCM.mdf;Integrated Security=True";
        //"Data Source=luisdesktop\\sqlexpress;initial catalog=MaschinenLCM;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            return con;
        }
    }
}
