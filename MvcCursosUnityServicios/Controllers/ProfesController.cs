using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCursosUnityServicios.Models.ViewModels;
using Servicios.Servicios;

namespace MvcCursosUnityServicios.Controllers
{
    public class ProfesController : Controller
    {
        // GET: Profes
        public ActionResult Index()
        {
            var servicio = DependencyResolver.Current.
                GetService<IServicios<ProfesorVievModel>>();
            return View(servicio.Get());
        }
    }
}