using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace negocio
{
     public class Coficial
    {
         transitoEntities te = new transitoEntities();
         public void guardar(string nom, string dir, string ran, string ap, int tel, int cedula)
         {
             oficial o = new oficial();
             o.nombreO = nom;
             o.direccionO = dir;
             o.rango = ran;
             o.apellidoO = ap;
             o.telefono = tel;
             o.ci = cedula;
             te.oficial.AddObject(o);
             te.SaveChanges();
         }
    }
}
