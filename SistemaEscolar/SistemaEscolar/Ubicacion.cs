using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolar
{
    public partial class Ubicacion : Form
    {
        public Ubicacion()
        {
            InitializeComponent();
        }
        CUbicacionDBServices LasUbicaciones = new CUbicacionDBServices();
        private void btnGuardarUbicacion_Click(object sender, EventArgs e)
        {
            CUbicacion ubic = new CUbicacion();
            ubic.strNomUbicacion = tbNomUbicacion.Text;
            LasUbicaciones.GuardarNuevaUbicacion(ubic);
            this.Close();
        }
    }
}
