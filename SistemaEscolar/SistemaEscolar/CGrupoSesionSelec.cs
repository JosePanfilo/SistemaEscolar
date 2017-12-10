using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CGrupoSesionSelec : ISujeto
    {
        private List<IObservador> Observadores;
        public CGrupoSesionSelec()
        {
            Observadores = new List<IObservador>();
        }

        public void GrupoSeleccionado(int id)
        {
            notificar(id);
        }

        public void enlasarObservador(IObservador o)
        {
            Observadores.Add(o);
        }
        public void notificar(int id)
        {
            foreach (IObservador item in Observadores)
            {
                item.Actualizar();
            }
        }
    }
}
