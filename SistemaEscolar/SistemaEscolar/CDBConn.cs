using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CDBConn
    {
        SqlConnection _conexion = new SqlConnection("Data Source=LAPTOP-4FBRAGGH\\SQLEXPRESS;Initial Catalog=SistemaEscolar;Integrated Security=True");

        public SqlConnection Conectar
        {
            get
            {
                if (_conexion.State == System.Data.ConnectionState.Closed)
                    _conexion.Open();
                return _conexion;

            }
        }

        public void CerrarConexion()
        {
            if (_conexion.State == System.Data.ConnectionState.Open)
            {
                _conexion.Close();
            }
        }
    }
}
