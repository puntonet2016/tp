namespace Proyectos
{
    partial class FactorForm
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
            this.NombreFactor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ValorAlto = new System.Windows.Forms.TextBox();
            this.ValorMedio = new System.Windows.Forms.TextBox();
            this.ValorBajo = new System.Windows.Forms.TextBox();
            this.botonGrabar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NombreFactor
            // 
            this.NombreFactor.Location = new System.Drawing.Point(102, 14);
            this.NombreFactor.MaxLength = 50;
            this.NombreFactor.Name = "NombreFactor";
            this.NombreFactor.Size = new System.Drawing.Size(100, 20);
            this.NombreFactor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor alto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor medio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor bajo";
            // 
            // ValorAlto
            // 
            this.ValorAlto.Location = new System.Drawing.Point(102, 51);
            this.ValorAlto.MaxLength = 50;
            this.ValorAlto.Name = "ValorAlto";
            this.ValorAlto.Size = new System.Drawing.Size(100, 20);
            this.ValorAlto.TabIndex = 5;
            // 
            // ValorMedio
            // 
            this.ValorMedio.Location = new System.Drawing.Point(102, 91);
            this.ValorMedio.MaxLength = 50;
            this.ValorMedio.Name = "ValorMedio";
            this.ValorMedio.Size = new System.Drawing.Size(100, 20);
            this.ValorMedio.TabIndex = 6;
            // 
            // ValorBajo
            // 
            this.ValorBajo.Location = new System.Drawing.Point(102, 126);
            this.ValorBajo.MaxLength = 50;
            this.ValorBajo.Name = "ValorBajo";
            this.ValorBajo.Size = new System.Drawing.Size(100, 20);
            this.ValorBajo.TabIndex = 7;
            // 
            // botonGrabar
            // 
            this.botonGrabar.Location = new System.Drawing.Point(12, 189);
            this.botonGrabar.Name = "botonGrabar";
            this.botonGrabar.Size = new System.Drawing.Size(75, 23);
            this.botonGrabar.TabIndex = 8;
            this.botonGrabar.Text = "Guardar";
            this.botonGrabar.UseVisualStyleBackColor = true;
            this.botonGrabar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(15, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Tag = "checkHabilitar";
            this.checkBox1.Text = "Habilitar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 224);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botonGrabar);
            this.Controls.Add(this.ValorBajo);
            this.Controls.Add(this.ValorMedio);
            this.Controls.Add(this.ValorAlto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreFactor);
            this.Name = "FactorForm";
            this.Text = "Factor";
            this.Shown += new System.EventHandler(this.FactorForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreFactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ValorAlto;
        private System.Windows.Forms.TextBox ValorMedio;
        private System.Windows.Forms.TextBox ValorBajo;
        private System.Windows.Forms.Button botonGrabar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}