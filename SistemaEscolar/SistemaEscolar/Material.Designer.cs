namespace SistemaEscolar
{
    partial class Material
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
            this.tbMaterial = new System.Windows.Forms.TextBox();
            this.btnGuardarMaterial = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMaterial
            // 
            this.tbMaterial.Location = new System.Drawing.Point(87, 11);
            this.tbMaterial.Name = "tbMaterial";
            this.tbMaterial.Size = new System.Drawing.Size(218, 20);
            this.tbMaterial.TabIndex = 7;
            // 
            // btnGuardarMaterial
            // 
            this.btnGuardarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMaterial.Location = new System.Drawing.Point(12, 43);
            this.btnGuardarMaterial.Name = "btnGuardarMaterial";
            this.btnGuardarMaterial.Size = new System.Drawing.Size(120, 34);
            this.btnGuardarMaterial.TabIndex = 6;
            this.btnGuardarMaterial.Text = "Guardar";
            this.btnGuardarMaterial.UseVisualStyleBackColor = true;
            this.btnGuardarMaterial.Click += new System.EventHandler(this.btnGuardarMaterial_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Material:";
            // 
            // Material
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 89);
            this.Controls.Add(this.tbMaterial);
            this.Controls.Add(this.btnGuardarMaterial);
            this.Controls.Add(this.label15);
            this.Name = "Material";
            this.Text = "Material";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMaterial;
        private System.Windows.Forms.Button btnGuardarMaterial;
        private System.Windows.Forms.Label label15;
    }
}