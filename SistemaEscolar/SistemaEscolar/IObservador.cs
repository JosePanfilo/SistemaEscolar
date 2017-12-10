using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    interface IObservador
    {//mi CBMateriaSesion
        void Actualizar();//actualizar cuando el sujeto o CBGrupoSesion lo notifique o dispare un evento
    }
}
