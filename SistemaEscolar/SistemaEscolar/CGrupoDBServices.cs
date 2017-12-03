using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CGrupoDBServices
    {
        List<CGrupo> _Grupo = new List<CGrupo>();

        public List<CGrupo> TodosLosAlumnos()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Grupo", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CGrupo Grup;
            while (DReader.Read())
            {
                Grup = new CGrupo();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla grupo"
                Grup.intIDGrupo = int.Parse(DReader["IDGrupo"].ToString());
                Grup.strNomGrupo = DReader["NomGrupo"].ToString();
                Grup.strActivo = DReader["Activo"].ToString();
                Grup.cuatrimestre.intIDCuatrimestre = int.Parse(DReader["IDCuatrimestre"].ToString());
                _Grupo.Add(Grup);
            }
            db.CerrarConexion();
            return _Grupo;
        }
    }
}
