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

        public bool GuardarNuevaMateria(CMateria mat)
        {
            try
            {
                CDBConn db = new CDBConn();
                SqlCommand cmd = new SqlCommand("SP_InsertMateria", db.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SE AGREGA EL PARAMETRO SIN VALOR SOLO SE DICE EL TIPO QUE ES
                SqlParameter ParamSalida = cmd.Parameters.Add("@IDMateria", System.Data.SqlDbType.Int);
                //NO SE MANDAN DATOS A LA BASE DE DATOS, SE RECIBE ALGO
                ParamSalida.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@NomMateria", mat.strNomMateria);
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

        public List<CMateria> ObtenerMaterias()
        {
            List<CMateria> _listaUMaterias = new List<CMateria>();
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select IDMateria, NomMateria from Materia", db.Conectar);
            SqlDataReader DReader = cmd.ExecuteReader();
            while (DReader.Read())
            {
                CMateria mater = new CMateria();
                //Toma los valores desde la bd el cual se asiga el indice de la columna (IDCatrimestre = 0 y Periodo = 1)
                mater.intIDMateria = DReader.GetInt32(0);
                mater.strNomMateria = DReader.GetString(1);
                _listaUMaterias.Add(mater);
            }
            return _listaUMaterias;
        }


        public List<CMateria> ObtenerMateriasSesion(int id)
        {
            //Actualizar(id);
            List<CMateria> _listaUMaterias = new List<CMateria>();
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("SELECT IDMateria, NomMateria FROM Materia where IDMateria in " +
                "(select IDMateria FROM ImpartirMateria Where IDGrupo = " + id + ")", db.Conectar);
            SqlDataReader DReader = cmd.ExecuteReader();
            while (DReader.Read())
            {
                CMateria mater = new CMateria();
                //Toma los valores desde la bd el cual se asiga el indice de la columna(IDCatrimestre = 0 y Periodo = 1)
            mater.intIDMateria = DReader.GetInt32(0);
                mater.strNomMateria = DReader.GetString(1);
                _listaUMaterias.Add(mater);
            }
            return _listaUMaterias;
        }

        //public void Actualizar(int id)
        //{
        //    //Accion que se realiza despues que se entera que el CBGrupoSesion se selcciono
        //    List<CMateria> _listaUMaterias = new List<CMateria>();
        //    CDBConn db = new CDBConn();
        //    SqlCommand cmd = new SqlCommand("SELECT IDMateria, NomMateria FROM Materia where IDMateria in " +
        //        "(select IDMateria FROM ImpartirMateria Where IDGrupo = " + id + ")", db.Conectar);
        //    SqlDataReader DReader = cmd.ExecuteReader();
        //    while (DReader.Read())
        //    {
        //        CMateria mater = new CMateria();
        //        //Toma los valores desde la bd el cual se asiga el indice de la columna (IDCatrimestre = 0 y Periodo = 1)
        //        mater.intIDMateria = DReader.GetInt32(0);
        //        mater.strNomMateria = DReader.GetString(1);
        //        _listaUMaterias.Add(mater);
        //    }
        //    //return _listaUMaterias;
        //}
    }
}
