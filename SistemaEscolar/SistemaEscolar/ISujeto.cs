using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    interface ISujeto
    {//CBGrupoSesion
        void notificar(int id); //avisa que se relecciono el CBGrupo y hay que hacer el cambio en CBMateriaSesion
    }
}
