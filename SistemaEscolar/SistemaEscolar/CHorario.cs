using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CHorario
    {
        public int intIDHorario { get; set; }
        public string strHora { get; set; }
        public string strDia { get; set; }
        public CImpartirMateria ImpartirMateria;
    }
}
