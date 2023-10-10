using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Npgsql;
using System.Threading.Tasks;

namespace WinFormsBanco
{
    class ConexaoString
    {
        string serverName = "localhost";
        string port = "5432";
        string userNmae = "postgres";
        string password = "13ewasz2";
        string dataBaseName = "btCliente";

        public string ConnString()
        {
            //var connString = String.Format("Server = {0},; Port {1}; Username = {2}; Password = {3}; Database = {4};", serverName, port, userName, password, dataBaseName);

            var connString = "Server =" + serverName+ ";Port= " +port+ ";Username = " +userNmae + ";Password = " +password +";Database = " + dataBaseName + ";";

            return connString;
        }
    }
}
