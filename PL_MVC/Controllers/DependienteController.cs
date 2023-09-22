using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class DependienteController : Controller
    {
        // GET: Dependiente
        [HttpGet]
        public ActionResult DependienteGetById(string NumeroEmpleado)
        {
            //Instanciar dependiente
            ML.Dependiente dependiente = new ML.Dependiente();
            //LLamar al metodo dependiente
            ML.Result resultEmpleado = BL.Dependiente.GetByIdEmpleado(NumeroEmpleado);
            //Llamar a la vista los dependientes
            dependiente.Dependientes = resultEmpleado.Objects;
            //Instanciar empleado
            dependiente.Empleado = new ML.Empleado();
            //Traer el numero de empleado para que no se pierda
            dependiente.Empleado.NumeroEmpleado = NumeroEmpleado;

            return View(dependiente);   


        }


        [HttpGet]   

        public ActionResult Form(int? IdDependiente)
        {
            ML.Dependiente dependiente = new ML.Dependiente();
            dependiente.Empleado = new ML.Empleado();
           
            if (IdDependiente != null)//Actualiza
            {
                ML.Result result = BL.Dependiente.GetById(IdDependiente.Value);

                if (result.Correct)
                {
                    dependiente = (ML.Dependiente)result.Object;

                }
            }
            else
            {
                return View();

            }

            return View(dependiente);
        }

        [HttpPost]  

        public ActionResult Form(ML.Dependiente dependiente)
        {
            //Linea agregada para instancia numero de empleado
            dependiente.Empleado = new ML.Empleado();
            
            if (dependiente.IdDependiente == 0)
            {
                ML.Result result = BL.Dependiente.Add(dependiente);

                if (result.Correct)
                {
                    ViewBag.IdEmpleado = dependiente.Empleado.NumeroEmpleado;
                    ViewBag.Mensaje = "Dependiente agregado con EXITO";
                    

                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un ERROR" + result.ErrorMessage;
                }
            }

            else
            {

                ML.Result result = BL.Dependiente.Update(dependiente);


                if (result.Correct)
                {
                    //ViewBag.IdEmpleado = dependiente.Empleado.NumeroEmpleado;
                    ViewBag.Mensaje = "Se ha completado la actualizacion";
                    
                    
                }
                else
                {

                    ViewBag.Mensaje = ":::ERROR:: Actualizacion no Completada" + result.ErrorMessage;
                    return View(dependiente);
                }


            }

            return PartialView("Modal");
        }



        public ActionResult Delete (int IdDependiente)
        {
            ML.Result result = BL.Dependiente.Delete(IdDependiente);

            if (result.Correct)
            {
                ViewBag.Mensaje = "Dependiente Eliminado con EXITO";
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un ERROR" + result.ErrorMessage;
            }

            return PartialView("Modal");
        }
    }
}