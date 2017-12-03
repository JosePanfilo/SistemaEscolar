using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CMaterialDBServices
    {
        List<CMaterial> _Material = new List<CMaterial>();

        public List<CMaterial> TodosLosMateriales()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Material", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CMaterial Material;
            while (DReader.Read())
            {
                Material = new CMaterial();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla material"
                Material.intIDMaterial = int.Parse(DReader["IDMaterial"].ToString());
                Material.strNomMaterial = DReader["NomMaterial"].ToString();
                _Material.Add(Material);
            }
            db.CerrarConexion();
            return _Material;
        }
    }
}
