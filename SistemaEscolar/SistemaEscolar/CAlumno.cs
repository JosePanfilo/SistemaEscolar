using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CAlumno
    {
        int intMatricula { get; set; }
        string strNomAlumno { get; set; }
        string strApellidoPaterno { get; set; }
        string strApellidoMaterno { get; set; }
        string strCorreo { get; set; }
        string strTelefono { get; set; }
        CGrupo grupo;
    }
}
