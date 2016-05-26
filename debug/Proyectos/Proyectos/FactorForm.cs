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

        private const string TITULO_NUEVO_REGISTRO = "Nuevo factor";
        private const string TITULO_MODIFICANDO_REGISTRO = "Modificar factor";

        /// <summary>
        /// Se inicializa el formulario para crear un nuevo factor.
        /// </summary>
        public FactorForm()
        {
            InitializeComponent();
            this.nombreFactor = null;
            this.nuevoRegistro = true;
        }

        /// <summary>
        /// Se inicializa el formulario con los datos del factor dado y listo para modificarse.
        /// </summary>
        /// <param name="nombreFactor">Nombre del factor a modificar</param>
        public FactorForm(string nombreFactor)
        {
            InitializeComponent();
            this.nombreFactor = nombreFactor;
            this.nuevoRegistro = true;
        }

        /// <summary>
        /// Nombre del factor con el que se creó el formulario
        /// </summary>
        private string nombreFactor 
        {
            get { return _nombre_factor; }
            set { _nombre_factor = value; }
        }

        /// <summary>
        /// Indica si se esta creando un registro o modificando.
        /// </summary>
        private bool nuevoRegistro
        {
            get { return _nuevo_registro; }
            set
            {

                if (!value)
                {
                    this.NombreFactor.Enabled = false;
                    this.Text = TITULO_MODIFICANDO_REGISTRO;
                }
                else
                {
                    this.NombreFactor.Enabled = true;
                    this.Text = TITULO_NUEVO_REGISTRO;
                }

                _nuevo_registro = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Inicializacion de variables
            string nombre= this.NombreFactor.Text.Trim();
            string valorBajo = this.ValorBajo.Text.Trim();
            string valorMedio = this.ValorMedio.Text.Trim();
            string valorAlto = this.ValorAlto.Text.Trim();
            bool habilitar = this.checkBox1.Checked;

            FactoresNegocio negocio = new FactoresNegocio();
            IList<string> errores= new List<string>();
            #endregion

            #region Validación de datos obligatorios
            if (nombre.Length == 0)
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
            #endregion

            #region Grabacion
            try
            {
                if (negocio.grabar(nombre, valorAlto, valorMedio, valorBajo, habilitar))
                {
                    this.nuevoRegistro = false;
                    MessageBox.Show(this, "Datos grabados correctamente.");
                }
                    
                else
                    this.mostrarErrores(negocio.errores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FactorForm_Shown(object sender, EventArgs e)
        {
            this.NombreFactor.MaxLength = factores.MAXIMO_NOMBRE;
            this.ValorBajo.MaxLength = factores.MAXIMO_NOMBRE;
            this.ValorMedio.MaxLength = factores.MAXIMO_NOMBRE;
            this.ValorAlto.MaxLength = factores.MAXIMO_NOMBRE;


            if (this.nombreFactor != null)
            {
                FactoresNegocio negocio = new FactoresNegocio();
                factores factor = negocio.uno(this.nombreFactor);

                if (factor == null)
                {
                    MessageBox.Show(this, negocio.errores.First());
                    return;
                }

                this.nuevoRegistro = false;
                this.NombreFactor.Text = factor.nombre;
                this.checkBox1.Checked = factor.habilitado;
                
                this.ValorBajo.Text = factor.valorBajo;
                this.ValorMedio.Text = factor.valorMedio;
                this.ValorAlto.Text = factor.valorAlto;
            }                
        }

        /// <summary>
        /// Muestra un dialogo con los errores de la lista
        /// </summary>
        /// <param name="errores">Errores a mostrar.</param>
        private void mostrarErrores(IList<string> errores)
        {
            if(errores.Count == 0) return;

            string texto = "";

            foreach (string error in errores)
                texto += "- " + error + "\n";

            MessageBox.Show(texto, "Errores", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
