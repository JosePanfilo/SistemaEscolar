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
    public partial class Cuatrimestre : Form
    {
        public Cuatrimestre()
        {
            InitializeComponent();
        }

        CCuatrimestreDBServices LosCuatrimestres = new CCuatrimestreDBServices();
        private void btnGuardarCuatrimestre_Click(object sender, EventArgs e)
        {
            CCuatrimestre cuatri = new CCuatrimestre();
            cuatri.strPeriodo = tbPeriodo.Text;
            cuatri.intAño = int.Parse(mtbAño.Text);
            if (rbActivo.Checked == true)
            {
                cuatri.strActivo = rbActivo.Text;
            }
            else
            {
                cuatri.strActivo = rbInactivo.Text;
            }
            LosCuatrimestres.GuardarNuevoCuatrimestre(cuatri);
            this.Close();


        }
    }
}
