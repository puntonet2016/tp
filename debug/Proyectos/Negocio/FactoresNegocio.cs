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

        /// <summary>
        /// 
        /// </summary>
        public IList<String> errores
        {
            get { return _errores == null ? new List<string>() : _errores; }
        }

        private void agregarError(string error)
        {
            if (this._errores == null)
                this._errores = new List<String>();

            this._errores.Add(error);
        }

        public FactoresNegocio()
        {
            this._errores= new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<factores> getTodos()
        {
            IList<factores> ret = null;

            try
            {
                ret = DB_Factores.getTodos();
            }
            catch (Exception e)
            {
                this.agregarError("Ocurrió un error al intentar realizar la acción.");
                System.Console.WriteLine(e.Message);
                ret= new List<factores>();
            }

            return ret;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreFactor"></param>
        /// <returns></returns>
        public factores uno(string nombreFactor)
        {
            factores model = null;
            this._errores = null;

            try
            {
               model = DB_Factores.uno(nombreFactor);
            }
            catch (Exception e)
            {
                this.agregarError("Ocurrió un error al intentar realizar la acción.");
                System.Console.WriteLine(e.Message);
                model = null;
            }


            return model;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombreFactor"></param>
        /// <param name="nombreValorAlto"></param>
        /// <param name="nombreValorMedio"></param>
        /// <param name="nombreValorBajo"></param>
        /// <param name="habilitar"></param>
        /// <returns></returns>
        public bool grabar(string nombreFactor, string nombreValorAlto, string nombreValorMedio, string nombreValorBajo, bool habilitar)
        {
            #region validacion de datos
            //IList<string> err = new List<string>();
            this._errores = null;

            if (nombreValorAlto.Equals(nombreValorMedio))
                this.agregarError("El nombre de valor '" + nombreValorAlto + "' se encuentra repetido.");
            else if (nombreValorAlto.Equals(nombreValorBajo))
                this.agregarError("El nombre de valor '" + nombreValorAlto + "' se encuentra repetido.");
            else if (nombreValorMedio.Equals(nombreValorBajo))
                this.agregarError("El nombre de valor '" + nombreValorMedio + "' se encuentra repetido.");

            //this.agregarError(err);

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
                this.agregarError("Ocurrió un error al intentar realizar la acción.");
                System.Console.WriteLine(e.Message);
                return false;
            }
            
            #endregion

            return true;
        }
    }
}
