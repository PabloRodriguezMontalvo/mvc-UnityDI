using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCursosUnityServicios.Models.ViewModels
{
    public class ProfesorVievModel
    {
        public int idProfesor { get; set; }
        public string nombre { get; set; }
        public Nullable<int> experiencia { get; set; }
    }
}