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
                Alum.intIDGrupo = int.Parse(DReader["IDGrupo"].ToString());
                _Alumno.Add(Alum);
            }
            db.CerrarConexion();
            return _Alumno;
        }

        public bool GuardarNuevoAlumno(CAlumno a)
        {
            try
            {
                CDBConn db = new CDBConn();
                SqlCommand cmd = new SqlCommand("SP_InsertAlumno", db.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SE AGREGA EL PARAMETRO SIN VALOR SOLO SE DICE EL TIPO QUE ES
                SqlParameter ParamSalida = cmd.Parameters.Add("@Matricula", System.Data.SqlDbType.Int);
                //NO SE MANDAN DATOS A LA BASE DE DATOS, SE RECIBE ALGO
                ParamSalida.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@Nombre", a.strNomAlumno);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", a.strApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", a.strApellidoMaterno);
                cmd.Parameters.AddWithValue("@Correo", a.strCorreo);
                cmd.Parameters.AddWithValue("@Telefono", a.strTelefono);
                cmd.Parameters.AddWithValue("@IDGrupo", a.intIDGrupo);
                //cmd.Parameters.AddWithValue("@NomGrupo", g.strNomGrupo);
                //cmd.Parameters.AddWithValue("@Activo", g.strActivo);
                //cmd.Parameters.AddWithValue("@IDCuatrimestre", g.intIDCuatrimestre);
                if (cmd.ExecuteNonQuery() == 1)
                {//ACTUALIZAR ID DEL OBJETO
                 //P.idPostre = ParamSalida.Value; dar o mostra el id pero como metodo o constructor
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
