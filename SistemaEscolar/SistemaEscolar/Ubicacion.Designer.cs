namespace SistemaEscolar
{
    partial class Ubicacion
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
            this.tbNomUbicacion = new System.Windows.Forms.TextBox();
            this.btnGuardarUbicacion = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNomUbicacion
            // 
            this.tbNomUbicacion.Location = new System.Drawing.Point(101, 11);
            this.tbNomUbicacion.Name = "tbNomUbicacion";
            this.tbNomUbicacion.Size = new System.Drawing.Size(218, 20);
            this.tbNomUbicacion.TabIndex = 10;
            // 
            // btnGuardarUbicacion
            // 
            this.btnGuardarUbicacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardarUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUbicacion.Location = new System.Drawing.Point(12, 37);
            this.btnGuardarUbicacion.Name = "btnGuardarUbicacion";
            this.btnGuardarUbicacion.Size = new System.Drawing.Size(120, 34);
            this.btnGuardarUbicacion.TabIndex = 9;
            this.btnGuardarUbicacion.Text = "Guardar";
            this.btnGuardarUbicacion.UseVisualStyleBackColor = false;
            this.btnGuardarUbicacion.Click += new System.EventHandler(this.btnGuardarUbicacion_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 20);
            this.label17.TabIndex = 8;
            this.label17.Text = "Ubicacion:";
            // 
            // Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 83);
            this.Controls.Add(this.tbNomUbicacion);
            this.Controls.Add(this.btnGuardarUbicacion);
            this.Controls.Add(this.label17);
            this.Name = "Ubicacion";
            this.Text = "Ubicacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomUbicacion;
        private System.Windows.Forms.Button btnGuardarUbicacion;
        private System.Windows.Forms.Label label17;
    }
}