using System.Runtime.InteropServices;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MvcCursosUnityServicios.MisServicios;
using MvcCursosUnityServicios.Models.ViewModels;
using Servicios.Servicios;
using Unity.Mvc4;

namespace MvcCursosUnityServicios
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        container.RegisterType<IServicios<CursoViewModel>, ServicioCursos>(
            new InjectionConstructor("http://localhost:53302/v1/curso")
            );
        container.RegisterType
            <IServicios<ProfesorVievModel>, Servicios<ProfesorVievModel>>
            (new InjectionConstructor("http://localhost:53302/v1/profesor"));
    }
  }
}