using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CProfesorDBServices
    {
        List<CProfesor> _Profesor = new List<CProfesor>();

        public List<CProfesor> TodosLosProfesores()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Profesor", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CProfesor Prof;
            while (DReader.Read())
            {
                Prof = new CProfesor();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla profesor"
                Prof.intNoControl = int.Parse(DReader["NoControlProfesor"].ToString());
                Prof.strNomProfesor = DReader["Nombre"].ToString();
                Prof.strApellidoPaterno = DReader["ApellidoPaterno"].ToString();
                Prof.strApellidoMaterno = DReader["ApellidoMaterno"].ToString();
                Prof.strCorreo = DReader["Correo"].ToString();
                Prof.strTelefono = DReader["Telefono"].ToString();
                _Profesor.Add(Prof);
            }
            db.CerrarConexion();
            return _Profesor;
        }
    }
}
