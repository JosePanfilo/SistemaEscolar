namespace SistemaEscolar
{
    partial class Materia
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
            this.tbNomMateria = new System.Windows.Forms.TextBox();
            this.btnGuardarMateria = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNomMateria
            // 
            this.tbNomMateria.Location = new System.Drawing.Point(87, 11);
            this.tbNomMateria.Name = "tbNomMateria";
            this.tbNomMateria.Size = new System.Drawing.Size(218, 20);
            this.tbNomMateria.TabIndex = 10;
            // 
            // btnGuardarMateria
            // 
            this.btnGuardarMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMateria.Location = new System.Drawing.Point(12, 37);
            this.btnGuardarMateria.Name = "btnGuardarMateria";
            this.btnGuardarMateria.Size = new System.Drawing.Size(120, 34);
            this.btnGuardarMateria.TabIndex = 9;
            this.btnGuardarMateria.Text = "Guardar";
            this.btnGuardarMateria.UseVisualStyleBackColor = true;
            this.btnGuardarMateria.Click += new System.EventHandler(this.btnGuardarMateria_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 20);
            this.label18.TabIndex = 8;
            this.label18.Text = "Materia:";
            // 
            // Materia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 83);
            this.Controls.Add(this.tbNomMateria);
            this.Controls.Add(this.btnGuardarMateria);
            this.Controls.Add(this.label18);
            this.Name = "Materia";
            this.Text = "Materia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNomMateria;
        private System.Windows.Forms.Button btnGuardarMateria;
        private System.Windows.Forms.Label label18;
    }
}