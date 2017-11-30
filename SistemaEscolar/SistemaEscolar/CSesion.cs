using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    class CSesion
    {
        int intIDSecion { get; }
        string strFecha { get; set; }
        string strHora { get; set; }
        CGrupo Grupo;
        CMateria Materia;
        CMaterial Material;
        CUbicacion Ubicacion;
        string strTipoSesion { get; set; }
        //bool boolClase { get; set; }
        //bool boolPractica { get; set; }
        //bool boolConferencia { get; set; }
        //string strOtraSucecion { get; set; }
    }
}
