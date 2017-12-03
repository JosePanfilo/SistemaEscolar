using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CImpartirMateria
    {
        public int intIDImpartirMateria { get; set; }
        public CProfesor Profesor;
        public CMateria Materia;
        public CGrupo Grupo; 
    }
}
