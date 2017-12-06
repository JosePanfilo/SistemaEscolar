namespace SistemaEscolar
{
    partial class Grupo
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
            this.btnGuardarGrupo = new System.Windows.Forms.Button();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.tbNomGrupo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbLlenarCuatrimestre = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGuardarGrupo
            // 
            this.btnGuardarGrupo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardarGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarGrupo.Location = new System.Drawing.Point(240, 80);
            this.btnGuardarGrupo.Name = "btnGuardarGrupo";
            this.btnGuardarGrupo.Size = new System.Drawing.Size(114, 29);
            this.btnGuardarGrupo.TabIndex = 19;
            this.btnGuardarGrupo.Text = "Guardar";
            this.btnGuardarGrupo.UseVisualStyleBackColor = false;
            this.btnGuardarGrupo.Click += new System.EventHandler(this.btnGuardarGrupo_Click);
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.Location = new System.Drawing.Point(90, 85);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(82, 24);
            this.rbInactivo.TabIndex = 18;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.Location = new System.Drawing.Point(14, 85);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(70, 24);
            this.rbActivo.TabIndex = 17;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // tbNomGrupo
            // 
            this.tbNomGrupo.Location = new System.Drawing.Point(174, 9);
            this.tbNomGrupo.Name = "tbNomGrupo";
            this.tbNomGrupo.Size = new System.Drawing.Size(180, 20);
            this.tbNomGrupo.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Periodo: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Nombre del Grupo:";
            // 
            // cbLlenarCuatrimestre
            // 
            this.cbLlenarCuatrimestre.FormattingEnabled = true;
            this.cbLlenarCuatrimestre.Location = new System.Drawing.Point(118, 47);
            this.cbLlenarCuatrimestre.Name = "cbLlenarCuatrimestre";
            this.cbLlenarCuatrimestre.Size = new System.Drawing.Size(142, 21);
            this.cbLlenarCuatrimestre.TabIndex = 20;
            // 
            // Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(367, 134);
            this.Controls.Add(this.cbLlenarCuatrimestre);
            this.Controls.Add(this.btnGuardarGrupo);
            this.Controls.Add(this.rbInactivo);
            this.Controls.Add(this.rbActivo);
            this.Controls.Add(this.tbNomGrupo);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Name = "Grupo";
            this.Text = "Grupo";
            this.Load += new System.EventHandler(this.Grupo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarGrupo;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
        private System.Windows.Forms.TextBox tbNomGrupo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbLlenarCuatrimestre;
    }
}