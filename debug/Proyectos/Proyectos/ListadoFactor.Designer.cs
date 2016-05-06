namespace Proyectos
{
    partial class ListadoFactor
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
            this.components = new System.ComponentModel.Container();
            this.GrillaFactores = new System.Windows.Forms.DataGridView();
            this.factoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFactores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaFactores
            // 
            this.GrillaFactores.AllowUserToAddRows = false;
            this.GrillaFactores.AllowUserToDeleteRows = false;
            this.GrillaFactores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaFactores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaFactores.Location = new System.Drawing.Point(0, 0);
            this.GrillaFactores.MultiSelect = false;
            this.GrillaFactores.Name = "GrillaFactores";
            this.GrillaFactores.ReadOnly = true;
            this.GrillaFactores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrillaFactores.ShowEditingIcon = false;
            this.GrillaFactores.Size = new System.Drawing.Size(533, 262);
            this.GrillaFactores.TabIndex = 0;
            this.GrillaFactores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaFactores_CellDoubleClick);
            // 
            // factoresBindingSource
            // 
            this.factoresBindingSource.DataSource = typeof(Entidades.factores);
            // 
            // ListadoFactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 262);
            this.Controls.Add(this.GrillaFactores);
            this.Name = "ListadoFactor";
            this.Text = "Listado de factores";
            this.Shown += new System.EventHandler(this.ListadoFactorForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFactores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaFactores;
        private System.Windows.Forms.BindingSource factoresBindingSource;

    }
}