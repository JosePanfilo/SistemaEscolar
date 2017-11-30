using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CGrupo
    {
        int intIDGrupo { get; }
        string strNomGrupo { get; set; }
        bool boolActivo { get; set; }
        CCuatrimestre cuatrimestre;
    }
}
