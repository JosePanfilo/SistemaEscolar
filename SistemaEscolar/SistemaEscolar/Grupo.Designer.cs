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
            this.button5 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(240, 80);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 29);
            this.button5.TabIndex = 19;
            this.button5.Text = "Guardar";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(90, 85);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 24);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inactivo";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(14, 85);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 24);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Activo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(174, 9);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(180, 20);
            this.textBox14.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Cuatrimestre";
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
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(174, 46);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(180, 20);
            this.textBox15.TabIndex = 16;
            // 
            // Grupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(367, 134);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Name = "Grupo";
            this.Text = "Grupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox15;
    }
}