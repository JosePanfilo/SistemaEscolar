﻿using System;
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
    public partial class Horario : Form
    {
        public Horario()
        {
            InitializeComponent();
        }

        private void btnCerrarHorario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
