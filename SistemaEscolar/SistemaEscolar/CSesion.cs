using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CSesion
    {
        public int intIDSecion { get; set; }
        public string strFecha { get; set; }
        public string strHora { get; set; }
        public CGrupo Grupo;
        public CMateria Materia;
        public CMaterial Material;
        public CUbicacion Ubicacion;
        public string strTipoSesion { get; set; }
    }
}
