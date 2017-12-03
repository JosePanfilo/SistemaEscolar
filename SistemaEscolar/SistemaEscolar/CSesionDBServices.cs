using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CSesionDBServices
    {
        List<CSesion> _Sesion = new List<CSesion>();

        public List<CSesion> TodasLasSesiones()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Sesion", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CSesion Ses;
            while (DReader.Read())
            {
                Ses = new CSesion();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla sesion"
                Ses.intIDSecion = int.Parse(DReader["Matricula"].ToString());
                Ses.strFecha = DReader["Nombre"].ToString();
                Ses.strHora = DReader["ApellidoPaterno"].ToString();
                Ses.Grupo.intIDGrupo = int.Parse(DReader["ApellidoMaterno"].ToString());
                Ses.Materia.intIDMateria = int.Parse(DReader["Correo"].ToString());
                Ses.Material.intIDMaterial = int.Parse(DReader["Telefono"].ToString());
                Ses.Ubicacion.intIDUbicacion = int.Parse(DReader["IDGrupo"].ToString());
                Ses.strTipoSesion = DReader["IDGrupo"].ToString();
                _Sesion.Add(Ses);
            }
            db.CerrarConexion();
            return _Sesion;
        } 
    }
}
