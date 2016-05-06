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
    public partial class ListadoFactorForm : Form
    {
        public ListadoFactorForm()
        {
            InitializeComponent();
        }

        private void ListadoFactorForm_Shown(object sender, EventArgs e)
        {
            DataSource ds= new DataSource();
            IList<factores> listaFactores = FactoresNegocio.getTodos();

            //foreach(factores f in listaFactores)
            //    this.GrillaFactores.Rows.Add(f.nombre, f.habilitado);

            this.GrillaFactores.DataSource = ds;
        }
    }
}
