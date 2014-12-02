using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCursosUnityServicios.MisServicios
{
    public class ServiciosSingleton
    {
        private static ServicioCursos _servicio;


        public static ServicioCursos Servicio
        {
            get
            {
                if(_servicio==null)
                    _servicio=new ServicioCursos();
                
                return _servicio;
            }
            
        }
    }
}