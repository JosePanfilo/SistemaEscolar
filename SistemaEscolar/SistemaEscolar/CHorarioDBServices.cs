using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CHorarioDBServices
    {
        List<CHorario> _Horario = new List<CHorario>();

        public List<CHorario> TodosLosHorarios()
        {
            CDBConn db = new CDBConn();
            SqlCommand cmd = new SqlCommand("Select * from Horario", db.Conectar);
            cmd.CommandType = System.Data.CommandType.Text;
            SqlDataReader DReader = cmd.ExecuteReader();

            CHorario Horar;
            while (DReader.Read())
            {
                Horar = new CHorario();
                //se debe de anexar el id
                //crear un nuevo objeto y asignarle valores "se toma el nombre de las columnas de la tabla horario"
                Horar.intIDHorario = int.Parse(DReader["IDHorario"].ToString());
                Horar.strHora = DReader["Hora"].ToString();
                Horar.strDia = DReader["Dia"].ToString();
                Horar.ImpartirMateria.intIDImpartirMateria = int.Parse(DReader["IDImpartirMateria"].ToString());
                _Horario.Add(Horar);
            }
            db.CerrarConexion();
            return _Horario;
        }
    }
}
