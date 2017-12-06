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

        public List<CGrupo> TodosLosGrupos()
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
                Grup.intIDCuatrimestre = int.Parse(DReader["IDCuatrimestre"].ToString());
                _Grupo.Add(Grup);
            }
            db.CerrarConexion();
            return _Grupo;
        }

        public bool GuardarNuevoGrupo(CGrupo g)
        {
            try
            {
                CDBConn db = new CDBConn();
                SqlCommand cmd = new SqlCommand("SP_InsertGrupo", db.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SE AGREGA EL PARAMETRO SIN VALOR SOLO SE DICE EL TIPO QUE ES
                SqlParameter ParamSalida = cmd.Parameters.Add("@IDGrupo", System.Data.SqlDbType.Int);
                //NO SE MANDAN DATOS A LA BASE DE DATOS, SE RECIBE ALGO
                ParamSalida.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@NomGrupo", g.strNomGrupo);
                cmd.Parameters.AddWithValue("@Activo", g.strActivo);
                cmd.Parameters.AddWithValue("@IDCuatrimestre", g.intIDCuatrimestre);
                if (cmd.ExecuteNonQuery() == 1)
                {//ACTUALIZAR ID DEL OBJETO
                 //P.idPostre = ParamSalida.Value; dar o mostra el id pero como metodo o constructor
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<CGrupo> ObtenerGruposActivos()
        {
            List<CGrupo> _listaGrupo = new List<CGrupo>();
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select IDGrupo, NomGrupo from Grupo where Activo = 'Activo'", db.Conectar);
            SqlDataReader DReader = cmd.ExecuteReader();
            while (DReader.Read())
            {
                CGrupo grup = new CGrupo();
                //Toma los valores desde la bd el cual se asiga el indice de la columna (IDGrupo = 0 y NomGrupo = 1)
                grup.intIDGrupo = DReader.GetInt32(0);
                grup.strNomGrupo = DReader.GetString(1);
                _listaGrupo.Add(grup);
            }
            return _listaGrupo;
        }

        public List<CGrupo> ObtenerTodosLosGrupos()
        {
            List<CGrupo> _listaGrupo = new List<CGrupo>();
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select IDGrupo, NomGrupo from Grupo", db.Conectar);
            SqlDataReader DReader = cmd.ExecuteReader();
            while (DReader.Read())
            {
                CGrupo grup = new CGrupo();
                //Toma los valores desde la bd el cual se asiga el indice de la columna (IDGrupo = 0 y NomGrupo = 1)
                grup.intIDGrupo = DReader.GetInt32(0);
                grup.strNomGrupo = DReader.GetString(1);
                _listaGrupo.Add(grup);
            }
            return _listaGrupo;
        }
    }
}
