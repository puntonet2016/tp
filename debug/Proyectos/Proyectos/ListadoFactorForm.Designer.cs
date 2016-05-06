namespace Proyectos
{
    partial class ListadoFactorForm
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
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.valoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFactores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaFactores
            // 
            this.GrillaFactores.AutoGenerateColumns = false;
            this.GrillaFactores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaFactores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.habilitadoDataGridViewCheckBoxColumn,
            this.valoresDataGridViewTextBoxColumn});
            this.GrillaFactores.DataSource = this.factoresBindingSource;
            this.GrillaFactores.Location = new System.Drawing.Point(12, 31);
            this.GrillaFactores.Name = "GrillaFactores";
            this.GrillaFactores.Size = new System.Drawing.Size(240, 150);
            this.GrillaFactores.TabIndex = 0;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // habilitadoDataGridViewCheckBoxColumn
            // 
            this.habilitadoDataGridViewCheckBoxColumn.DataPropertyName = "habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.HeaderText = "habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.Name = "habilitadoDataGridViewCheckBoxColumn";
            // 
            // valoresDataGridViewTextBoxColumn
            // 
            this.valoresDataGridViewTextBoxColumn.DataPropertyName = "valores";
            this.valoresDataGridViewTextBoxColumn.HeaderText = "valores";
            this.valoresDataGridViewTextBoxColumn.Name = "valoresDataGridViewTextBoxColumn";
            // 
            // factoresBindingSource
            // 
            this.factoresBindingSource.DataSource = typeof(Entidades.factores);
            // 
            // ListadoFactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.GrillaFactores);
            this.Name = "ListadoFactorForm";
            this.Text = "ListadoFactores";
            this.Shown += new System.EventHandler(this.ListadoFactorForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaFactores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaFactores;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource factoresBindingSource;

    }
}