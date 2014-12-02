using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcCursosUnityServicios.Models.ViewModels;
using Servicos.Servicios;

namespace MvcCursosUnityServicios.MisServicios
{
    public class ServicioCursos:Servicios<CursoViewModel>
    {
        public ServicioCursos()
        {
            UrlBase = "http://localhost:53302/v1/curso";
        }
    }
}