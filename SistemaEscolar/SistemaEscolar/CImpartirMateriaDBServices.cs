using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CImpartirMateriaDBServices
    {
        List<CImpartirMateria> _ImpartirMateria = new List<CImpartirMateria>();

        public List<CImpartirMateria> TodasLasMaterias()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from ImpartirMateria", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CImpartirMateria ImpMater;
            while (DReader.Read())
            {
                ImpMater = new CImpartirMateria();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla impartir materia"
                ImpMater.intIDImpartirMateria = int.Parse(DReader["IDImpartirMateria"].ToString());
                ImpMater.Profesor.intNoControl = int.Parse(DReader["NoControlProfesor"].ToString());
                ImpMater.Materia.intIDMateria = int.Parse(DReader["IDMateria"].ToString());
                ImpMater.Grupo.intIDGrupo = int.Parse(DReader["IDGrupo"].ToString());
                _ImpartirMateria.Add(ImpMater);
            }
            db.CerrarConexion();
            return _ImpartirMateria;
        }
    }
}
