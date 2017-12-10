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
    public partial class Form1 : Form
    {
        CAlumnoDBServices LosAlumnos = new CAlumnoDBServices();
        CCuatrimestreDBServices LosCuatrimestres = new CCuatrimestreDBServices();
        CUbicacionDBServices LasUbicaciones = new CUbicacionDBServices();
        CMaterialDBServices LosMateriales = new CMaterialDBServices();
        CMateriaDBServices LasMaterias = new CMateriaDBServices();
        CProfesorDBServices LosProfesores = new CProfesorDBServices();
        CGrupoDBServices LosGrupos = new CGrupoDBServices();
        CImpartirMateriaDBServices ImpartirMaterias = new CImpartirMateriaDBServices();

        CGrupoSesionSelec sensor = new CGrupoSesionSelec();
        public Form1()
        {
            InitializeComponent();
            dgvCuatrimestre.DataSource = null;
            dgvCuatrimestre.DataSource = LosCuatrimestres.TodosLosCuatrimestres();
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
            btnDejarTarea.Visible = true;

        }

        //Abrir ventana o forma para agregar el cuatrimestre
        private void button10_Click(object sender, EventArgs e)
        {
            Cuatrimestre c = new Cuatrimestre();
            c.Show();
        }

        private void btnNuevoGrupo_Click(object sender, EventArgs e)
        {
            Grupo g = new Grupo();
            g.Show();
        }

        private void btnNuevaMateria_Click(object sender, EventArgs e)
        {
            Materia m = new Materia();
            m.Show();
        }

        private void btnNuevoProfesor_Click(object sender, EventArgs e)
        {
            Profesor p = new Profesor();
            p.Show();
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.Show();
        }

        private void btnNuevoMaterial_Click(object sender, EventArgs e)
        {
            Material m = new Material();
            m.Show();
        }

        private void btnNuevaUbicacion_Click(object sender, EventArgs e)
        {
            Ubicacion u = new Ubicacion();
            u.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se toma el objeto Ubicaciones y se asignan los valores que va a tener 
            cbUbicacion.DataSource = LasUbicaciones.ObtenerUbicaciones();
            //lo que mostrara y el valor que tomara el CB, debe de estar escrito igual como se encuentra en la CUbicacion
            cbUbicacion.DisplayMember = "strNomUbicacion";
            cbUbicacion.ValueMember = "intIDUbicacion";

            //Se toma el objeto Materiales y se asignan los valores que va a tener 
            cbMaterial.DataSource = LosMateriales.ObtenerMateriales();
            //lo que mostrara y el valor que tomara el CB, debe de estar escrito igual como se encuentra en la CMaterial
            cbMaterial.DisplayMember = "strNomMaterial";
            cbMaterial.ValueMember = "intIDMaterial";

            //Se toma el objeto Materias y se asignan los valores que va a tener 
            cbMateriaAsignar.DataSource = LasMaterias.ObtenerMaterias();
            //lo que mostrara y el valor que tomara el CB, debe de estar escrito igual como se encuentra en la CMateria
            cbMateriaAsignar.DisplayMember = "strNomMateria";
            cbMateriaAsignar.ValueMember = "intIDMateria";

            //Se toma el objeto Profesores y se asignan los valores que va a tener 
            cbProfesorAsigMater.DataSource = LosProfesores.ObtenerProfesores();
            //lo que mostrara y el valor que tomara el CB, debe de estar escrito igual como se encuentra en la CProfesor
            cbProfesorAsigMater.DisplayMember = "intNoControl";// + "strApellidoPaterno" + "strApellidoMaterno";
            cbProfesorAsigMater.ValueMember = "intNoControl";

            //Se toma el objeto Profesores y se asignan los valores que va a tener 
            cbGrupoAsigMater.DataSource = LosGrupos.ObtenerTodosLosGrupos();
            //lo que mostrara y el valor que tomara el CB, debe de estar escrito igual como se encuentra en la CProfesor
            cbGrupoAsigMater.DisplayMember = "strNomGrupo";// + "strApellidoPaterno" + "strApellidoMaterno";
            cbGrupoAsigMater.ValueMember = "intIDGrupo";

            //Se toma el objeto Profesores y se asignan los valores que va a tener 
            cbGrupoSesion.DataSource = LosGrupos.ObtenerGruposActivos();
            //lo que mostrara y el valor que tomara el CB, debe de estar escrito igual como se encuentra en la CProfesor
            cbGrupoSesion.DisplayMember = "strNomGrupo";// + "strApellidoPaterno" + "strApellidoMaterno";
            cbGrupoSesion.ValueMember = "intIDGrupo";


            //Se toma el objeto Profesores y se asignan los valores que va a tener 
            cbMateriaSesion.DataSource = LasMaterias.ObtenerMateriasSesion(Convert.ToInt32(cbGrupoSesion.SelectedValue));
            //lo que mostrara y el valor que tomara el CB, debe de estar escrito igual como se encuentra en la CProfesor
            cbMateriaSesion.DisplayMember = "strNomMateria";// + "strApellidoPaterno" + "strApellidoMaterno";
            cbMateriaSesion.ValueMember = "intIDMateria";
        }

        private void btnGuardarAsigMateria_Click(object sender, EventArgs e)
        {
            CImpartirMateria impMat = new CImpartirMateria();
            impMat.intNoControlProfesor = Convert.ToInt32(cbProfesorAsigMater.SelectedValue);
            impMat.intIDMateria = Convert.ToInt32(cbMateriaAsignar.SelectedValue);
            impMat.intIDGrupo = Convert.ToInt32(cbGrupoAsigMater.SelectedValue);
            ImpartirMaterias.GuardarNuevoImpartirMateria(impMat);
        }

        CTarea tarea;
        IRecogerTarea recogertarea;
        private void btnDejarTarea_Click(object sender, EventArgs e)
        {
            recogertarea = (IRecogerTarea)tarea;
            

            if(btnDejarTarea.Text == "Dejar Tarea")
            {
                btnDejarTarea.Visible = true;
                lbNombreTarea.Visible = true;
                tbNombreTarea.Visible = true;
                lbFechaEntrega.Visible = true;
                mdtFechaEntrega.Visible = true;
                btnDejarTarea.Text = "Guardar";
            }
            else if (btnDejarTarea.Text == "Guardar")
            {
                metroCheckBox1.Visible = true;
                lbNombreTarea.Visible = false;
                tbNombreTarea.Visible = false;
                lbFechaEntrega.Visible = false;
                mdtFechaEntrega.Visible = false;

                metroCheckBox1.Text = tbNombreTarea.Text+" " + mdtFechaEntrega.Text;

                btnDejarTarea.Text = "Dejar Tarea";
            }
        }

        private void metroDateTime2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbGrupoSesion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ////Se toma el objeto Profesores y se asignan los valores que va a tener 
            //cbMateriaSesion.DataSource = LasMaterias.ObtenerMateriasSesion(Convert.ToInt32(cbGrupoSesion.SelectedValue));
            ////lo que mostrara y el valor que tomara el CB, debe de estar escrito igual como se encuentra en la CProfesor
            //cbMateriaSesion.DisplayMember = "strNomMateria";// + "strApellidoPaterno" + "strApellidoMaterno";
            //cbMateriaSesion.ValueMember = "intIDMateria";
        }

        private void cbGrupoSesion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sensor.GrupoSeleccionado(Convert.ToInt32(cbGrupoSesion.SelectedValue));
            dgvListaAlumnosSesion.DataSource = LosAlumnos.TodosLosAlumnos(1);
        }
    }
}
