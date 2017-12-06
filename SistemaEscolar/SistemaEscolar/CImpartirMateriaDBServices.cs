using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CImpartirMateriaDBServices
    {
        List<CImpartirMateria> _ImpartirMateria = new List<CImpartirMateria>();

        public List<CImpartirMateria> TodasLasMaterias()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from ImpartirMateria", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CImpartirMateria ImpMater;
            while (DReader.Read())
            {
                ImpMater = new CImpartirMateria();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla impartir materia"
                ImpMater.intIDImpartirMateria = int.Parse(DReader["IDImpartirMateria"].ToString());
                ImpMater.intNoControlProfesor = int.Parse(DReader["NoControlProfesor"].ToString());
                ImpMater.intIDMateria = int.Parse(DReader["IDMateria"].ToString());
                ImpMater.intIDGrupo = int.Parse(DReader["IDGrupo"].ToString());
                _ImpartirMateria.Add(ImpMater);
            }
            db.CerrarConexion();
            return _ImpartirMateria;
        }

        public bool GuardarNuevoImpartirMateria(CImpartirMateria impMat)
        {
            try
            {
                CDBConn db = new CDBConn();
                SqlCommand cmd = new SqlCommand("SP_InsertImpartirMateria", db.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SE AGREGA EL PARAMETRO SIN VALOR SOLO SE DICE EL TIPO QUE ES
                SqlParameter ParamSalida = cmd.Parameters.Add("@IDImpartirMateria", System.Data.SqlDbType.Int);
                //NO SE MANDAN DATOS A LA BASE DE DATOS, SE RECIBE ALGO
                ParamSalida.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@NoControlProfesor", impMat.intNoControlProfesor);
                cmd.Parameters.AddWithValue("@IDMateria", impMat.intIDMateria);
                cmd.Parameters.AddWithValue("@IDGrupo", impMat.intIDGrupo);
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
