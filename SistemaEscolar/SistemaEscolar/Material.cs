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
    public partial class Material : Form
    {
        public Material()
        {
            InitializeComponent();
        }
        CMaterialDBServices LosMateriales = new CMaterialDBServices();
        private void btnGuardarMaterial_Click(object sender, EventArgs e)
        {
            CMaterial mater = new CMaterial();
            mater.strNomMaterial = tbMaterial.Text;
            LosMateriales.GuardarNuevaMAterial(mater);
            this.Close();
        }
    }
}
