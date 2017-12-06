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
    public partial class Profesor : Form
    {
        CProfesorDBServices LosProfesores = new CProfesorDBServices();
        public Profesor()
        {
            InitializeComponent();
        }
        
        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            CProfesor prof = new CProfesor();
            //prof.intNoControl = int.Parse(tbNoControl.Text);
            prof.strNomProfesor = tbNomProfesor.Text;
            prof.strApellidoPaterno = tbApellidoPaterno.Text;
            prof.strApellidoMaterno = tbApellidoMaterno.Text;
            prof.strCorreo = tbCorreoProfesor.Text;
            prof.strTelefono = mtbTelProfesor.Text;
            LosProfesores.GuardarNuevoProfesor(prof);
            this.Close();
        }
    }
}
