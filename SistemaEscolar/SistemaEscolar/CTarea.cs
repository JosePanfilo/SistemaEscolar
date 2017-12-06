using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CTarea : IRecogerTarea
    {
        public int intID { get; set; }
        public int intGrupoID { get; set; }
        public int intMateriaID { get; set; }
        public string strFechaEntrega { get; set; }

        public string RecogerTatra()
        {
            throw new NotImplementedException();
        }
    }
}
