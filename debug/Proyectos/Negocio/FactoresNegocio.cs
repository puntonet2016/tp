using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public class FactoresNegocio
    {
        private IList<string> _errores;

        public IList<String> errores
        {
            get { return _errores; }
            set { _errores = value; }
        }

        public IList<factores> getTodos()
        {
            IList<factores> ret = null;

            try
            {
                ret = DB_Factores.getTodos();
            }
            catch (Exception e)
            {
                IList<string> err = new List<string>();
                err.Add(e.Message);
                this.errores = err;
                ret= new List<factores>();
            }

            return ret;
        }

        public factores uno(string nombreFactor)
        {
            factores model = null;

            try
            {
               model = DB_Factores.uno(nombreFactor);
            }
            catch (Exception e)
            {
                IList<string> err = new List<string>();
                err.Add(e.Message);
                model = null;
            }


            return model;
        }

        public bool grabar(string nombreFactor, string nombreValorAlto, string nombreValorMedio, string nombreValorBajo, bool habilitar)
        {
            #region validacion de datos
            IList<string> err = new List<string>();

            if (nombreValorAlto.Equals(nombreValorMedio))
                err.Add("El nombre de valor '" + nombreValorAlto + "' se encuentra repetido.");
            else if (nombreValorAlto.Equals(nombreValorBajo))
                err.Add("El nombre de valor '" + nombreValorAlto + "' se encuentra repetido.");
            else if (nombreValorMedio.Equals(nombreValorBajo))
                err.Add("El nombre de valor '" + nombreValorMedio + "' se encuentra repetido.");

            this.errores = err;

            if (this.errores.Count > 0)
                return false;
            #endregion

            #region creacion del modelo
            
              factores  factor = new factores()
                {
                    nombre = nombreFactor,
                    valorAlto = nombreValorAlto,
                    valorBajo = nombreValorBajo,
                    valorMedio = nombreValorMedio,
                    habilitado= habilitar 
                };
            #endregion

            #region grabacion
            try
            {
                DB_Factores.grabar(factor);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return false;
            }
            
            #endregion

            return true;
        }
    }
}
