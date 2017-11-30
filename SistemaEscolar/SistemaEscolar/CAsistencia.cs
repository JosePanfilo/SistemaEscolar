using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CAsistencia
    {
        int intIDAsistencia { get; set; }
        CSesion Sesion;
        CAlumno Alumno;
        string strTipoAsistencia { get; set; }
    }
}
