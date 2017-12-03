using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CAlumno
    {
        public int intMatricula { get; set; }
        public string strNomAlumno { get; set; }
        public string strApellidoPaterno { get; set; }
        public string strApellidoMaterno { get; set; }
        public string strCorreo { get; set; }
        public string strTelefono { get; set; }
        public CGrupo grupo;
    }
}
