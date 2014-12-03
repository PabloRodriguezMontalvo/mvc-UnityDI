using System.Web.Mvc;
using MvcCursosUnityServicios.Models.ViewModels;
using Servicios.Servicios;

namespace MvcCursosUnityServicios.Controllers
{
    public class CursosController : Controller
    {
        //private IServicios<CursoViewModel> _servicio;

        //public CursosController(IServicios<CursoViewModel> servicio)
        //{
        //    _servicio = servicio;
        //}

        // GET: Cursos
        public ActionResult Index()
        {

            var _servicio = DependencyResolver.Current.
                GetService<IServicios<CursoViewModel>>();


            return View(_servicio.Get());
        }
    }
}