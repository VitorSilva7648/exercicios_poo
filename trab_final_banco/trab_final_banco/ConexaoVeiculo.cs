using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trab_final_banco
{
    class ConexaoVeiculo
    {
        string serverName = "localhost";
        string port = "5432"; //5432 estava ocupada
        string userNmae = "postgres";
        string password = "13ewasz2";
        string dataBaseName = "btVeiculo";

        public string Conectar()
        {
            //var connString = String.Format("Server = {0},; Port {1}; Username = {2}; Password = {3}; Database = {4};", serverName, port, userName, password, dataBaseName);

            var connString = "Server =" + serverName + ";Port= " + port + ";Username = " + userNmae + ";Password = " + password + ";Database = " + dataBaseName + ";";

            return connString;
        }
    }
}
