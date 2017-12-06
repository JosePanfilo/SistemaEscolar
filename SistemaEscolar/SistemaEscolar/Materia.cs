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
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
        }
        CMateriaDBServices LasMaterias = new CMateriaDBServices();
        private void btnGuardarMateria_Click(object sender, EventArgs e)
        {
            CMateria mater = new CMateria();
            mater.strNomMateria = tbNomMateria.Text;
            LasMaterias.GuardarNuevaMateria(mater);
            this.Close();
        }
    }
}
