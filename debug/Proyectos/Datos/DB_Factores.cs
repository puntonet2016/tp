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
        /*
        public static IList<factores> getTodos()
        {
            using (DB_ProyectoEntities db = new DB_ProyectoEntities())
            {
                IList<factores> ret= null;

                try
                {
                    //ret= db.factores.s;
                    
                    var datos = from f in db.factores
                                select new
                                {
                                    nombre= f.nombre,
                                    habilitado= f.habilitado,
                                    alto= f.valorAlto,
                                    medio= f.valorMedio,
                                    bajo= f.valorBajo
                                };

                    ret= db.factores.ToList<factores>();
                    //ret = new List<factores>();
                    
                    /*
                    foreach (var d in datos)
                    {

                        ret.Add(new factores() { 
                            nombre= d.nombre,
                            habilitado= d.habilitado,
                            valorAlto= d.alto,
                            valorMedio= d.medio,
                            valorBajo= d.bajo
                        });
                    }
                     

                } catch(Exception e)
                {
                    throw e;
                }

                return ret;
            }
        }
        */
        public static IList<factores> getTodos()
        {
            return new DB_ProyectoEntities().factores.ToList<factores>();
        }

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
                            case 0: model.valorBajo = val.nombre; break;
                            case 1: model.valorMedio = val.nombre; break;
                            case 2: model.valorAlto = val.nombre; break;
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }

                return model;
            }
        }

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
                            case 0: model.valorBajo = val.nombre; break;
                            case 1: model.valorMedio = val.nombre; break;
                            case 2: model.valorAlto = val.nombre; break;
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
                    db.SaveChanges();
                } catch(Exception e){
                    
                    throw e;
                }
            }
        }
    }
}
