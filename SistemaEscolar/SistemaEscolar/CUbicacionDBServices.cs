using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CUbicacionDBServices
    {
        List<CUbicacion> _Ubicacion = new List<CUbicacion>();

        public List<CUbicacion> TodasLasUbicaciones()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Ubicacion", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CUbicacion Ubic;
            while (DReader.Read())
            {
                Ubic = new CUbicacion();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla ubicacion"
                Ubic.intIDUbicacion = int.Parse(DReader["IDUbicacion"].ToString());
                Ubic.strNomUbicacion = DReader["NomUbicacion"].ToString();
                _Ubicacion.Add(Ubic);
            }
            db.CerrarConexion();
            return _Ubicacion;
        }
    }
}
