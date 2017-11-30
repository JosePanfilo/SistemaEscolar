using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CHorario
    {
        int intIDHorario { get; }
        string strHora { get; set; }
        string strDia { get; set; }
        CImpartirMateria ImpartirMateria;
    }
}
