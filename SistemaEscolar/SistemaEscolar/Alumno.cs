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
    public partial class Alumno : Form
    {
        public Alumno()
        {
            InitializeComponent();
        }
        CGrupoDBServices LosGrupos = new CGrupoDBServices();
        CAlumnoDBServices LosAlumnos = new CAlumnoDBServices();
        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            CAlumno alum = new CAlumno();
            alum.strNomAlumno = tbNomAlumno.Text;
            alum.strApellidoPaterno = tbApellidoPaterno.Text;
            alum.strApellidoMaterno = tbApellidoMaterno.Text;
            alum.strCorreo = tbCorreoAlumno.Text;
            alum.strTelefono = mtbTelefono.Text;
            alum.intIDGrupo = Convert.ToInt32(cbSeleccionarGrupo.SelectedValue);
            LosAlumnos.GuardarNuevoAlumno(alum);
            this.Close();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            //Se toma el objeto cuatrimestre y se asignan los valores que va a tener 
            cbSeleccionarGrupo.DataSource = LosGrupos.ObtenerGruposActivos();
            //lo que mostrara y el valor que tomara el CB, debe de estar escrito igual como se encuentra en la CCuatrimestre
            cbSeleccionarGrupo.DisplayMember = "strNomGrupo";
            cbSeleccionarGrupo.ValueMember = "intIDGrupo";
        }
    }
}
