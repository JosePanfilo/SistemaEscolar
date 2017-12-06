namespace SistemaEscolar
{
    partial class Alumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumno));
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGuardarAlumno = new System.Windows.Forms.Button();
            this.tbCorreoAlumno = new System.Windows.Forms.TextBox();
            this.tbApellidoMaterno = new System.Windows.Forms.TextBox();
            this.tbApellidoPaterno = new System.Windows.Forms.TextBox();
            this.tbNomAlumno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSeleccionarGrupo = new System.Windows.Forms.ComboBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 180);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 48;
            this.label13.Text = "Grupo:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(385, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 240);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fotografia";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(17, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 38);
            this.button3.TabIndex = 16;
            this.button3.Text = "Examinar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAlumno.Location = new System.Drawing.Point(10, 213);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(122, 62);
            this.btnGuardarAlumno.TabIndex = 46;
            this.btnGuardarAlumno.Text = "Modificar";
            this.btnGuardarAlumno.UseVisualStyleBackColor = false;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // tbCorreoAlumno
            // 
            this.tbCorreoAlumno.Location = new System.Drawing.Point(164, 125);
            this.tbCorreoAlumno.Name = "tbCorreoAlumno";
            this.tbCorreoAlumno.Size = new System.Drawing.Size(192, 20);
            this.tbCorreoAlumno.TabIndex = 44;
            // 
            // tbApellidoMaterno
            // 
            this.tbApellidoMaterno.Location = new System.Drawing.Point(164, 99);
            this.tbApellidoMaterno.Name = "tbApellidoMaterno";
            this.tbApellidoMaterno.Size = new System.Drawing.Size(192, 20);
            this.tbApellidoMaterno.TabIndex = 43;
            // 
            // tbApellidoPaterno
            // 
            this.tbApellidoPaterno.Location = new System.Drawing.Point(164, 73);
            this.tbApellidoPaterno.Name = "tbApellidoPaterno";
            this.tbApellidoPaterno.Size = new System.Drawing.Size(192, 20);
            this.tbApellidoPaterno.TabIndex = 42;
            // 
            // tbNomAlumno
            // 
            this.tbNomAlumno.Location = new System.Drawing.Point(164, 47);
            this.tbNomAlumno.Name = "tbNomAlumno";
            this.tbNomAlumno.Size = new System.Drawing.Size(192, 20);
            this.tbNomAlumno.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 151);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 125);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Correo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 99);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Apellido Materno:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 73);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Apellido Paterno:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 47);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Nombre:";
            // 
            // cbSeleccionarGrupo
            // 
            this.cbSeleccionarGrupo.FormattingEnabled = true;
            this.cbSeleccionarGrupo.Location = new System.Drawing.Point(164, 177);
            this.cbSeleccionarGrupo.Name = "cbSeleccionarGrupo";
            this.cbSeleccionarGrupo.Size = new System.Drawing.Size(192, 21);
            this.cbSeleccionarGrupo.TabIndex = 49;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(164, 153);
            this.mtbTelefono.Mask = "9999999999";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(192, 20);
            this.mtbTelefono.TabIndex = 45;
            this.mtbTelefono.ValidatingType = typeof(int);
            // 
            // Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(610, 290);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.cbSeleccionarGrupo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuardarAlumno);
            this.Controls.Add(this.tbCorreoAlumno);
            this.Controls.Add(this.tbApellidoMaterno);
            this.Controls.Add(this.tbApellidoPaterno);
            this.Controls.Add(this.tbNomAlumno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "Alumno";
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Alumno_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGuardarAlumno;
        private System.Windows.Forms.TextBox tbCorreoAlumno;
        private System.Windows.Forms.TextBox tbApellidoMaterno;
        private System.Windows.Forms.TextBox tbApellidoPaterno;
        private System.Windows.Forms.TextBox tbNomAlumno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSeleccionarGrupo;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
    }
}