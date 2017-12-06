using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CUbicacionDBServices
    {
        List<CUbicacion> _Ubicacion = new List<CUbicacion>();

        public List<CUbicacion> TodasLasUbicaciones()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Ubicacion", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CUbicacion Ubic;
            while (DReader.Read())
            {
                Ubic = new CUbicacion();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla ubicacion"
                Ubic.intIDUbicacion = int.Parse(DReader["IDUbicacion"].ToString());
                Ubic.strNomUbicacion = DReader["NomUbicacion"].ToString();
                _Ubicacion.Add(Ubic);
            }
            db.CerrarConexion();
            return _Ubicacion;
        }

        public bool GuardarNuevaUbicacion(CUbicacion u)
        {
            try
            {
                CDBConn db = new CDBConn();
                SqlCommand cmd = new SqlCommand("SP_InsertUbicacion", db.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SE AGREGA EL PARAMETRO SIN VALOR SOLO SE DICE EL TIPO QUE ES
                SqlParameter ParamSalida = cmd.Parameters.Add("@IDUbicacion", System.Data.SqlDbType.Int);
                //NO SE MANDAN DATOS A LA BASE DE DATOS, SE RECIBE ALGO
                ParamSalida.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@NomUbicacion", u.strNomUbicacion);
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

        public List<CUbicacion> ObtenerUbicaciones()
        {
            List<CUbicacion> _listaUbicaciones = new List<CUbicacion>();
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select IDUbicacion, NomUbicacion from Ubicacion", db.Conectar);
            SqlDataReader DReader = cmd.ExecuteReader();
            while (DReader.Read())
            {
                CUbicacion ubic = new CUbicacion();
                //Toma los valores desde la bd el cual se asiga el indice de la columna (IDCatrimestre = 0 y Periodo = 1)
                ubic.intIDUbicacion = DReader.GetInt32(0);
                ubic.strNomUbicacion = DReader.GetString(1);
                _listaUbicaciones.Add(ubic);
            }
            return _listaUbicaciones;
        }
    }
}
