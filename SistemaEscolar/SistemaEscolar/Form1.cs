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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //PROFESOR
        private void btnHorarioProfesor_Click(object sender, EventArgs e)
        {
            Horario h = new Horario();
            h.Show();
        }

        //SESION
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHoraSesion.Text = DateTime.Now.ToShortTimeString();
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            metroCheckBox1.Visible = false;
        }
    }
}
