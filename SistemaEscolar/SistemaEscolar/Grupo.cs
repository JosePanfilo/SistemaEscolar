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
    public partial class Grupo : Form
    {
        CCuatrimestreDBServices LosCuatrimestres = new CCuatrimestreDBServices();
        CGrupoDBServices LosGrupos = new CGrupoDBServices();
        public Grupo()
        {
            InitializeComponent();
            //LosCuatrimestres.LlenarCBCuatrimestre(cbLlenarCuatrimestre);
        }

        private void btnGuardarGrupo_Click(object sender, EventArgs e)
        {
            CGrupo grup = new CGrupo();
            grup.strNomGrupo = tbNomGrupo.Text;
            if (rbActivo.Checked == true)
            {
                grup.strActivo = rbActivo.Text;
            }
            else
            {
                grup.strActivo = rbInactivo.Text;
            }

            grup.intIDCuatrimestre = Convert.ToInt32(cbLlenarCuatrimestre.SelectedValue);
            LosGrupos.GuardarNuevoGrupo(grup);
            this.Close();
        }

        private void Grupo_Load(object sender, EventArgs e)
        {
            //Se toma el objeto cuatrimestre y se asignan los valores que va a tener 
            cbLlenarCuatrimestre.DataSource = LosCuatrimestres.ObtenerCuatrimestres();
            //lo que mostrara y el valor que tomara el CB, debe de estar escrito igual como se encuentra en la CCuatrimestre
            cbLlenarCuatrimestre.DisplayMember = "strPeriodo";
            cbLlenarCuatrimestre.ValueMember = "intIDCuatrimestre";
        }
    }
}
