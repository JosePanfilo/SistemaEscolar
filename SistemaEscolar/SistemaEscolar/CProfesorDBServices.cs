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

        public bool GuardarNuevoProfesor(CProfesor p)
        {
            try
            {
                CDBConn db = new CDBConn();
                SqlCommand cmd = new SqlCommand("P_InsertProfesor", db.Conectar);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //SE AGREGA EL PARAMETRO SIN VALOR SOLO SE DICE EL TIPO QUE ES
                SqlParameter ParamSalida = cmd.Parameters.Add("@NoControl", System.Data.SqlDbType.Int);
                //NO SE MANDAN DATOS A LA BASE DE DATOS, SE RECIBE ALGO
                ParamSalida.Direction = System.Data.ParameterDirection.Output;

                cmd.Parameters.AddWithValue("@Nombre", p.strNomProfesor);
                cmd.Parameters.AddWithValue("@ApellidoPaterno", p.strApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoMaterno", p.strApellidoMaterno);
                cmd.Parameters.AddWithValue("@Correo", p.strCorreo);
                cmd.Parameters.AddWithValue("@Telefono", p.strTelefono);
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

        public List<CProfesor> ObtenerProfesores()
        {
            List<CProfesor> _listaProfesores = new List<CProfesor>();
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select NoControlProfesor from Profesor", db.Conectar);//, Nombre, ApellidoPaterno, ApellidoMaterno from Profesor", db.Conectar);
            SqlDataReader DReader = cmd.ExecuteReader();
            while (DReader.Read())
            {
                CProfesor prof = new CProfesor();
                //Toma los valores desde la bd el cual se asiga el indice de la columna (IDCatrimestre = 0 y Periodo = 1)
                prof.intNoControl = DReader.GetInt32(0);
                //prof.strNomProfesor = DReader.GetString(1);
                _listaProfesores.Add(prof);
            }
            return _listaProfesores;
        }
    }
}
