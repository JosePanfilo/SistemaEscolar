using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CAsistencia
    {
        public int intIDAsistencia { get; set; }
        public CSesion Sesion;
        public CAlumno Alumno;
        public string strTipoAsistencia { get; set; }
    }
}
