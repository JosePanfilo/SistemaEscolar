using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    class CCuatrimestreDBServices
    {
        List<CCuatrimestre> _Cuatrimestre = new List<CCuatrimestre>();

        public List<CCuatrimestre> TodosLosCuatrimestres()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select IDCuatrimestre, Periodo, Año, Activo from Cuatrimestre", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CCuatrimestre Cuatrim;
            while (DReader.Read())
            {
                Cuatrim = new CCuatrimestre();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla cuatrimestre"
                Cuatrim.intIDCuatrimestre = int.Parse(DReader["IDCuatrimestre"].ToString());
                Cuatrim.strPeriodo = DReader["Periodo"].ToString();
                Cuatrim.intAño = int.Parse(DReader["Año"].ToString());
                Cuatrim.strActivo = DReader["Activo"].ToString();
                _Cuatrimestre.Add(Cuatrim);
            }
            db.CerrarConexion();
            return _Cuatrimestre;
        }

        public bool GuardarNuevoCuatrimestre(CCuatrimestre c)
        {
            try
            {
                CDBConn db = new CDBConn();
                SqlCommand cmd = new SqlCommand("SP_InsertCuatrimestre", db.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SE AGREGA EL PARAMETRO SIN VALOR SOLO SE DICE EL TIPO QUE ES
                SqlParameter ParamSalida = cmd.Parameters.Add("@IDCuatrimestre", System.Data.SqlDbType.Int);
                //NO SE MANDAN DATOS A LA BASE DE DATOS, SE RECIBE ALGO
                ParamSalida.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@Periodo", c.strPeriodo);
                cmd.Parameters.AddWithValue("@Año", c.intAño);
                cmd.Parameters.AddWithValue("@Activo", c.strActivo);
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

        public void LlenarCBCuatrimestre(ComboBox cb)
        {
            try
            {
                CDBConn db = new CDBConn();
                SqlCommand cmd = new SqlCommand("Select IDCuatrimestre, Periodo from Cuatrimestre", db.Conectar);
                SqlDataReader DReader = cmd.ExecuteReader();
                while (DReader.Read())
                {
                    
                    cb.Items.Add(DReader["Periodo"].ToString());
                }
                db.CerrarConexion();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se obtuvo la lista" + ex.ToString());
            }
        }

        public List<CCuatrimestre> ObtenerCuatrimestres()
        {
            List<CCuatrimestre> _listaCuatrimestre = new List<CCuatrimestre>();
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select IDCuatrimestre, Periodo from Cuatrimestre", db.Conectar);
            SqlDataReader DReader = cmd.ExecuteReader();
            while (DReader.Read())
            {
                CCuatrimestre cuat = new CCuatrimestre();
                //Toma los valores desde la bd el cual se asiga el indice de la columna (IDCatrimestre = 0 y Periodo = 1)
                cuat.intIDCuatrimestre = DReader.GetInt32(0);
                cuat.strPeriodo = DReader.GetString(1);
                _listaCuatrimestre.Add(cuat);
            }
            return _listaCuatrimestre;
        }
    }
}
