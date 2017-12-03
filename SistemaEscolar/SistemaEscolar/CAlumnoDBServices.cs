using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CAlumnoDBServices
    {
        List<CAlumno> _Alumno = new List<CAlumno>();

        public List<CAlumno> TodosLosAlumnos()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Alumno", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CAlumno Alum;
            while (DReader.Read())
            {
                Alum = new CAlumno();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla alumno"
                Alum.intMatricula = int.Parse(DReader["Matricula"].ToString());
                Alum.strNomAlumno = DReader["Nombre"].ToString();
                Alum.strApellidoPaterno = DReader["ApellidoPaterno"].ToString();
                Alum.strApellidoMaterno = DReader["ApellidoMaterno"].ToString();
                Alum.strCorreo = DReader["Correo"].ToString();
                Alum.strTelefono = DReader["Telefono"].ToString();
                Alum.grupo.intIDGrupo = int.Parse(DReader["IDGrupo"].ToString());
                _Alumno.Add(Alum);
            }
            db.CerrarConexion();
            return _Alumno;
        }
    }
}
