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

        public bool GuardarNuevaMAterial(CMaterial m)
        {
            try
            {
                CDBConn db = new CDBConn();
                SqlCommand cmd = new SqlCommand("SP_InsertMaterial", db.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SE AGREGA EL PARAMETRO SIN VALOR SOLO SE DICE EL TIPO QUE ES
                SqlParameter ParamSalida = cmd.Parameters.Add("@IDMaterial", System.Data.SqlDbType.Int);
                //NO SE MANDAN DATOS A LA BASE DE DATOS, SE RECIBE ALGO
                ParamSalida.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@NomMaterial", m.strNomMaterial);
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

        public List<CMaterial> ObtenerMateriales()
        {
            List<CMaterial> _listaUMateriales = new List<CMaterial>();
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select IDMaterial, NomMaterial from Material", db.Conectar);
            SqlDataReader DReader = cmd.ExecuteReader();
            while (DReader.Read())
            {
                CMaterial mater = new CMaterial();
                //Toma los valores desde la bd el cual se asiga el indice de la columna (IDCatrimestre = 0 y Periodo = 1)
                mater.intIDMaterial = DReader.GetInt32(0);
                mater.strNomMaterial = DReader.GetString(1);
                _listaUMateriales.Add(mater);
            }
            return _listaUMateriales;
        }
    }
}
