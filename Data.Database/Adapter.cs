using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        

        //private SqlConnection sqlConnection = new SqlConnection("ConnectionString;");
        //Clave por defecto a utlizar para la cadena de conexion
        const string consKeyDefaultCnnString = "ConnStringExpress";
        protected SqlConnection sqlConn;

        protected void OpenConnection()
        {
            var valorconn = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
            sqlConn = new SqlConnection(valorconn);
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            
            sqlConn.Close();
            sqlConn = null;
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }

}
