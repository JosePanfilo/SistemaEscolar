using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CMateriaDBServices
    {
        List<CMateria> _Materia = new List<CMateria>();

        public List<CMateria> TodasLasMaterias()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Materia", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CMateria Mater;
            while (DReader.Read())
            {
                Mater = new CMateria();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla materia"
                Mater.intIDMateria = int.Parse(DReader["IDMateria"].ToString());
                Mater.strNomMateria = DReader["NomMateria"].ToString();
                _Materia.Add(Mater);
            }
            db.CerrarConexion();
            return _Materia;
        }
    }
}
