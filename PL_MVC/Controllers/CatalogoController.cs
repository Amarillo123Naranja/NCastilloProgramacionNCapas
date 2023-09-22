using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class CatalogoController : Controller
    {
        // GET: Catalogo
        [HttpGet]
        public ActionResult Catalogo()
        {
            ML.Empleado empleado = new ML.Empleado();
            empleado.Empresa = new ML.Empresa();
            empleado.Empresa.IdEmpresa = 0;
            empleado.Nombre = "";
            ML.Result result = BL.Empleado.GetAll(empleado.Empresa.IdEmpresa, empleado.Nombre);
            empleado.Empleados = result.Objects;

            ML.Result resultEmpresa = BL.Empresa.GetAll();
            empleado.Empresa.Empresas = resultEmpresa.Objects;

            return View(empleado);

        }
    }
}