using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CCuatrimestreDBServices
    {
        List<CCuatrimestre> _Cuatrimestre = new List<CCuatrimestre>();

        public List<CCuatrimestre> TodosLosCuatrimestres()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Cuatrimestre", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CCuatrimestre Cuatrim;
            while (DReader.Read())
            {
                Cuatrim = new CCuatrimestre();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla cuatrimestre"
                Cuatrim.intIDCuatrimestre = int.Parse(DReader["IDCuatrimestre"].ToString());
                Cuatrim.strPeriodo = DReader["Periodo"].ToString();
                Cuatrim.intAño = int.Parse(DReader["Año"].ToString());
                Cuatrim.strActivo = DReader["Activo"].ToString();
                _Cuatrimestre.Add(Cuatrim);
            }
            db.CerrarConexion();
            return _Cuatrimestre;
        }
    }
}
