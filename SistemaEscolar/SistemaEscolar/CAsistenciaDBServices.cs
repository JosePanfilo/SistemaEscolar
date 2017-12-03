using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CAsistenciaDBServices
    {
        List<CAsistencia> _Asistencia = new List<CAsistencia>();

        public List<CAsistencia> TodasLasAsistencias()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Asistencia", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CAsistencia Asist;
            while (DReader.Read())
            {
                Asist = new CAsistencia();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla asistencia"
                Asist.intIDAsistencia = int.Parse(DReader["IDAsistencia"].ToString());
                Asist.Sesion.intIDSecion = int.Parse(DReader["IDSesion"].ToString());
                Asist.Alumno.intMatricula = int.Parse(DReader["MatriculaAlumno"].ToString());
                Asist.strTipoAsistencia = DReader["TipoAsistencia"].ToString();
                _Asistencia.Add(Asist);
            }
            db.CerrarConexion();
            return _Asistencia;
        }
    }
}
