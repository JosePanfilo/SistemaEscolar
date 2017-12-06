namespace SistemaEscolar
{
    partial class Profesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profesor));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.tbCorreoProfesor = new System.Windows.Forms.TextBox();
            this.tbApellidoMaterno = new System.Windows.Forms.TextBox();
            this.tbApellidoPaterno = new System.Windows.Forms.TextBox();
            this.tbNomProfesor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.mtbTelProfesor = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(385, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 240);
            this.groupBox2.TabIndex = 63;
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
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregarProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProfesor.Location = new System.Drawing.Point(14, 186);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(122, 62);
            this.btnAgregarProfesor.TabIndex = 62;
            this.btnAgregarProfesor.Text = "Agregar";
            this.btnAgregarProfesor.UseVisualStyleBackColor = false;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // tbCorreoProfesor
            // 
            this.tbCorreoProfesor.Location = new System.Drawing.Point(168, 122);
            this.tbCorreoProfesor.Name = "tbCorreoProfesor";
            this.tbCorreoProfesor.Size = new System.Drawing.Size(192, 20);
            this.tbCorreoProfesor.TabIndex = 60;
            // 
            // tbApellidoMaterno
            // 
            this.tbApellidoMaterno.Location = new System.Drawing.Point(168, 96);
            this.tbApellidoMaterno.Name = "tbApellidoMaterno";
            this.tbApellidoMaterno.Size = new System.Drawing.Size(192, 20);
            this.tbApellidoMaterno.TabIndex = 59;
            // 
            // tbApellidoPaterno
            // 
            this.tbApellidoPaterno.Location = new System.Drawing.Point(168, 70);
            this.tbApellidoPaterno.Name = "tbApellidoPaterno";
            this.tbApellidoPaterno.Size = new System.Drawing.Size(192, 20);
            this.tbApellidoPaterno.TabIndex = 58;
            // 
            // tbNomProfesor
            // 
            this.tbNomProfesor.Location = new System.Drawing.Point(168, 44);
            this.tbNomProfesor.Name = "tbNomProfesor";
            this.tbNomProfesor.Size = new System.Drawing.Size(192, 20);
            this.tbNomProfesor.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 148);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Telefono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 122);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 54;
            this.label8.Text = "Correo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 96);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(132, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Apellido Materno:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 70);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 52;
            this.label10.Text = "Apellido Paterno:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 44);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 51;
            this.label11.Text = "Nombre:";
            // 
            // mtbTelProfesor
            // 
            this.mtbTelProfesor.Location = new System.Drawing.Point(168, 148);
            this.mtbTelProfesor.Mask = "9999999999";
            this.mtbTelProfesor.Name = "mtbTelProfesor";
            this.mtbTelProfesor.Size = new System.Drawing.Size(192, 20);
            this.mtbTelProfesor.TabIndex = 61;
            this.mtbTelProfesor.ValidatingType = typeof(int);
            // 
            // Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(597, 280);
            this.Controls.Add(this.mtbTelProfesor);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.tbCorreoProfesor);
            this.Controls.Add(this.tbApellidoMaterno);
            this.Controls.Add(this.tbApellidoPaterno);
            this.Controls.Add(this.tbNomProfesor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Name = "Profesor";
            this.Text = "Profesor";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.TextBox tbCorreoProfesor;
        private System.Windows.Forms.TextBox tbApellidoMaterno;
        private System.Windows.Forms.TextBox tbApellidoPaterno;
        private System.Windows.Forms.TextBox tbNomProfesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbTelProfesor;
    }
}