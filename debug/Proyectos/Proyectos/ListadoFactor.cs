using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;
using Entidades;

namespace Proyectos
{
    public partial class ListadoFactor : Form
    {
        public ListadoFactor()
        {
            InitializeComponent();
        }

        private void ListadoFactorForm_Shown(object sender, EventArgs e)
        {
            this.cargarDatos();
        }

        private void GrillaFactores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string nombreFactor = this.GrillaFactores.Rows[e.RowIndex].Cells[0].Value.ToString();

            FactorForm form = new FactorForm(nombreFactor);
            form.ShowDialog(this);

            this.cargarDatos();
        }

        private void cargarDatos()
        {
            DataTable dt = new DataTable();
            FactoresNegocio negocio = new FactoresNegocio();
            IList<factores> listaFactores = negocio.getTodos();

            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Habilitado", typeof(bool));
            dt.Columns.Add("Valor alto", typeof(string));
            dt.Columns.Add("Valor medio", typeof(string));
            dt.Columns.Add("Valor bajo", typeof(string));

            if (listaFactores != null)
            {
                foreach (factores f in listaFactores)
                    dt.Rows.Add(new Object[] { f.nombre, f.habilitado, f.valorAlto, f.valorMedio, f.valorBajo });

                System.Console.WriteLine(listaFactores.Count + " agregados");
            }
            else MessageBox.Show(this, negocio.errores.First());


            this.GrillaFactores.DataSource = dt;
        }
    }
}
