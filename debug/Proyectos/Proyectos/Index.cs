﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectos
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FactorForm form = new FactorForm();
            form.Show();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoFactor form = new ListadoFactor();
            form.Show();
        }
    }
}
