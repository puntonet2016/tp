using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;


namespace Datos
{
    public class DB_Factores
    {
        /// <summary>
        /// Obtiene todos los factores.
        /// </summary>
        /// <returns>Una lista de los factores encontrados</returns>
        /// <exception cref="System.Exception">Error que se ha producido al intentar obtener todos los factores.</exception>
        public static IList<factores> getTodos()
        {
            return new DB_ProyectoEntities().factores.ToList<factores>();
        }

        /// <summary>
        /// Se obtiene los datos del factor que coincida con el nombre provisto.
        /// </summary>
        /// <param name="nombre">Nombre del factor.</param>
        /// <returns>Un objeto con los datos del factor obtenido.
        /// NULL en el caso de que no se encuentre un factor con el mismo nombre.</returns>
        /// <exception cref="System.Exception">Error que se ha producido al intentar obtener el factor.</exception>
        public static factores uno(string nombre)
        {

            using(DB_ProyectoEntities db = new DB_ProyectoEntities())
            {
                factores model = null;

                try
                {
                    model = db.factores.Find(nombre);

                    if (model == null)
                        return null;

                    IList<valores> listaValores = (from v in db.valores where v.nombreFactor.Equals(nombre) orderby v.rating ascending select v).ToList<valores>();

                    foreach (valores val in listaValores)
                    {
                        switch(val.rating)
                        {
                            case valores.RATING_BAJO: model.valorBajo = val.nombre; break;
                            case valores.RATING_MEDIO: model.valorMedio = val.nombre; break;
                            case valores.RATING_ALTO: model.valorAlto = val.nombre; break;
                        }
                    }
                }
                catch (Exception e)
                {
                    //TODO loggear el error
                    throw e;
                }

                return model;
            }
        }

        /// <summary>
        /// Se persiste un factor.
        /// </summary>
        /// <param name="factor">El factor a persistir.</param>
        /// <exception cref="System.Exception">Error que se ha producido al intentar persistir el factor</exception>
        public static void grabar(factores factor)
        {

            using (DB_ProyectoEntities db = new DB_ProyectoEntities())
            {
                factores model = db.factores.Find(factor.nombre);
                
                if (model != null){

                    model.habilitado = factor.habilitado;

                    IList<valores> valoresGuardados= (from v in db.valores where v.nombreFactor.Equals(model.nombre) select v).ToList<valores>();
                    
                    foreach (valores val in factor.valores)
                    {
                        switch (val.rating)
                        {
                            case valores.RATING_BAJO: model.valorBajo = val.nombre; break;
                            case valores.RATING_MEDIO: model.valorMedio = val.nombre; break;
                            case valores.RATING_ALTO: model.valorAlto = val.nombre; break;
                        }
                    }

                    db.Entry(model).State= System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    model = factor;

                    db.Entry(model).State= System.Data.Entity.EntityState.Added;

                    foreach (valores val in model.valores)
                        db.Entry(val).State = System.Data.Entity.EntityState.Added;

                    db.factores.Add(factor);
                    db.valores.AddRange(factor.valores);
                }

                try
                {
                    //TODO loggear el registro
                    db.SaveChanges();
                } catch(Exception e){
                    //TODO loggear el error
                    throw e;
                }
            }
        }
    }
}
