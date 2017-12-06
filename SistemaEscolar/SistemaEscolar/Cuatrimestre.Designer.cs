namespace SistemaEscolar
{
    partial class Cuatrimestre
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
            this.tbPeriodo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbAño = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardarCuatrimestre = new System.Windows.Forms.Button();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbPeriodo
            // 
            this.tbPeriodo.Location = new System.Drawing.Point(89, 9);
            this.tbPeriodo.Name = "tbPeriodo";
            this.tbPeriodo.Size = new System.Drawing.Size(180, 20);
            this.tbPeriodo.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Periodo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Año: ";
            // 
            // mtbAño
            // 
            this.mtbAño.Location = new System.Drawing.Point(89, 43);
            this.mtbAño.Mask = "9999";
            this.mtbAño.Name = "mtbAño";
            this.mtbAño.Size = new System.Drawing.Size(67, 20);
            this.mtbAño.TabIndex = 19;
            this.mtbAño.ValidatingType = typeof(int);
            // 
            // btnGuardarCuatrimestre
            // 
            this.btnGuardarCuatrimestre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardarCuatrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCuatrimestre.Location = new System.Drawing.Point(239, 74);
            this.btnGuardarCuatrimestre.Name = "btnGuardarCuatrimestre";
            this.btnGuardarCuatrimestre.Size = new System.Drawing.Size(114, 29);
            this.btnGuardarCuatrimestre.TabIndex = 22;
            this.btnGuardarCuatrimestre.Text = "Guardar";
            this.btnGuardarCuatrimestre.UseVisualStyleBackColor = false;
            this.btnGuardarCuatrimestre.Click += new System.EventHandler(this.btnGuardarCuatrimestre_Click);
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInactivo.Location = new System.Drawing.Point(89, 79);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(82, 24);
            this.rbInactivo.TabIndex = 21;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "Inactivo";
            this.rbInactivo.UseVisualStyleBackColor = true;
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActivo.Location = new System.Drawing.Point(13, 79);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(70, 24);
            this.rbActivo.TabIndex = 20;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "Activo";
            this.rbActivo.UseVisualStyleBackColor = true;
            // 
            // Cuatrimestre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 134);
            this.Controls.Add(this.btnGuardarCuatrimestre);
            this.Controls.Add(this.rbInactivo);
            this.Controls.Add(this.rbActivo);
            this.Controls.Add(this.mtbAño);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPeriodo);
            this.Controls.Add(this.label14);
            this.Name = "Cuatrimestre";
            this.Text = "Cuatrimestre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPeriodo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbAño;
        private System.Windows.Forms.Button btnGuardarCuatrimestre;
        private System.Windows.Forms.RadioButton rbInactivo;
        private System.Windows.Forms.RadioButton rbActivo;
    }
}