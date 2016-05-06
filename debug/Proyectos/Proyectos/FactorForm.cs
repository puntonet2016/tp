using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Negocio;

namespace Proyectos
{
    public partial class FactorForm : Form
    {
        private string _nombre_factor;
        private bool _nuevo_registro;

        public FactorForm()
        {
            InitializeComponent();
            this.nombreFactor = null;
            this.nuevoRegistro = true;
        }

        public FactorForm(string nombreFactor)
        {
            InitializeComponent();
            this.nombreFactor = nombreFactor;
            this.nuevoRegistro = false;
        }

        private string nombreFactor 
        {
            get { return _nombre_factor; }
            set { _nombre_factor = value; }
        }

        private bool nuevoRegistro
        {
            get { return _nuevo_registro; }
            set { _nuevo_registro = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombreFactor= this.NombreFactor.Text.Trim();
            string valorBajo = this.ValorBajo.Text.Trim();
            string valorMedio = this.ValorMedio.Text.Trim();
            string valorAlto = this.ValorAlto.Text.Trim();
            bool habilitar = this.checkBox1.Checked;

            IList<string> errores= new List<string>();

            if (nombreFactor.Length == 0)
                errores.Add("Ingrese el nombre del factor.");

            if (valorAlto.Length == 0)
                errores.Add("Ingrese el nombre del valor alto.");

            if (valorMedio.Length == 0)
                errores.Add("Ingrese el nombre del valor medio.");

            if (valorBajo.Length == 0)
                errores.Add("Ingrese el nombre del valor bajo.");

            if (errores.Count > 0)
            {
                this.mostrarErrores(errores);
                return;
            }

            FactoresNegocio negocio = new FactoresNegocio();

            try
            {
                if (negocio.grabar(nombreFactor, valorAlto, valorMedio, valorBajo, habilitar))
                {
                    this.NombreFactor.Enabled = false;
                    MessageBox.Show(this, "Datos grabados correctamente.");
                }
                    
                else
                    this.mostrarErrores(negocio.errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FactorForm_Shown(object sender, EventArgs e)
        {
            if (this.nombreFactor != null)
            {
                FactoresNegocio negocio = new FactoresNegocio();
                factores factor = negocio.uno(this.nombreFactor);

                if (factor == null)
                {
                    MessageBox.Show(this, negocio.errores.First());
                    return;
                }

                this.NombreFactor.Text = factor.nombre;
                this.checkBox1.Checked = factor.habilitado;
                //System.Console.WriteLine(factor);
                if (factor.valores != null && factor.valores.Count > 0)
                {
                    foreach (valores valor in factor.valores)
                    {
                        switch (valor.rating)
                        {
                            case 0: this.ValorBajo.Text = valor.nombre; break;
                            case 1: this.ValorMedio.Text = valor.nombre; break;
                            case 2: this.ValorAlto.Text = valor.nombre; break;
                        }
                    }
                }
            }

            if (!this.nuevoRegistro)
                this.NombreFactor.Enabled = false;
        }

        private void mostrarErrores(IList<string> errores)
        {
            if(errores.Count == 0) return;
            
            string texto = "Por favor, corrija los siguientes errores:\n";

            foreach (string error in errores)
                texto += "\t- " + error + "\n";

            MessageBox.Show(this, texto);
        }
    }
}
