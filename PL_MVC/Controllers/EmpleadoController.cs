using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado

        // [HttpGet] Mostrar la vista
        //    public ActionResult GetAll()
        //{
        //    ML.Empleado empleado = new ML.Empleado();
        //    empleado.Empresa = new ML.Empresa();
        //    empleado.Empresa.IdEmpresa = 0;
        //    empleado.Nombre = "";
        //    ML.Result result = BL.Empleado.GetAll(empleado.Empresa.IdEmpresa, empleado.Nombre);
        //    empleado.Empleados = result.Objects;
        //    //lo que falta es que llames al getall pero de empresas y eso lo pasas en la linea de abajo
        //    //aca, antes de la linea donde asignas
        //    ML.Result resultEmpresa = BL.Empresa.GetAll();
        //    empleado.Empresa.Empresas = resultEmpresa.Objects;



        //    if (result.Correct)
        //    {
        //        return View(empleado);

        //    }
        //    else
        //    {
        //        return View();
        //    }


        //}


        [HttpGet]// Mostrar la vista
        public ActionResult GetAll()
        {
            ML.Empleado empleado = new ML.Empleado();
            empleado.Empresa = new ML.Empresa();
            empleado.Empresa.IdEmpresa = 0;
            empleado.Nombre = "";
            ML.Result resultEmpresa = BL.Empresa.GetAll();
            empleado.Empresa.Empresas = resultEmpresa.Objects;

            //WCF
            ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
            //WCF
            var result = empleadoWCF.GetAll(empleado.Empresa.IdEmpresa, empleado.Nombre);
            //WCF
            if (result.Correct)
            {
                empleado.Empleados = result.Objects.ToList();
            }
            return View(empleado);
        }


        //[HttpPost]

        //public ActionResult GetAll(int IdEmpresa, string Nombre)
        //{

        //    ML.Empleado empleado = new ML.Empleado();

        //    if (empleado.Empresa.IdEmpresa == 0)
        //    {
        //        empleado.Empresa.IdEmpresa = 0;

        //    }
        //    if (empleado.Nombre == null)
        //    {
        //        empleado.Nombre = "";
        //    }

        //    ML.Result result = BL.Empleado.GetAll(IdEmpresa, Nombre);
        //    empleado = new ML.Empleado();
        //    empleado.Empleados = result.Objects;
        //    ML.Result resultEmpresa = BL.Empresa.GetAll();
        //    empleado.Empresa.Empresas = resultEmpresa.Objects;

        //    return View(empleado);





        //}


        [HttpPost]

        public ActionResult GetAll(int IdEmpresa, string Nombre)
        {

            ML.Empleado empleado = new ML.Empleado();
       

            if (empleado.Empresa.IdEmpresa == 0)
            {
                empleado.Empresa.IdEmpresa = 0;

            }
            if (empleado.Nombre == null)
            {
                empleado.Nombre = "";
            }
            //WCF
            ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
            //WCF
            var result = empleadoWCF.GetAll(IdEmpresa, Nombre);
            //WCF
            empleado = new ML.Empleado();
            ML.Result resultEmpresa = BL.Empresa.GetAll();
            empleado.Empresa.Empresas = resultEmpresa.Objects;

            //WCF
            if (result.Correct)
            {
                empleado.Empleados = result.Objects.ToList();
            }
            return View(empleado);

            
         

        }


        [HttpGet]
        public ActionResult Form(string NumeroEmpleado)//Muestra la vista
        {
            ML.Empleado empleado = new ML.Empleado();
            empleado.Empresa = new Empresa();
            ML.Result resultEmpresa = BL.Empresa.GetAll();

            if(NumeroEmpleado != null)//Actualiza
            {
                //WCF
                ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
                //WCF
                var result = empleadoWCF.GetById(NumeroEmpleado);


                //MVC
                //ML.Result result = BL.Empleado.GetById(NumeroEmpleado);
                if (result.Correct)
                {
                    empleado = (ML.Empleado)result.Object;
                    empleado.Empresa.Empresas = resultEmpresa.Objects;
                    empleado.Accion = "Update";
                }
            }
            else//Agregar
            {
                empleado.Empresa.Empresas = resultEmpresa.Objects;
                empleado.Accion = "Add";
            }

            return View(empleado);  
           
        }

        [HttpPost]  
        public ActionResult Form(ML.Empleado empleado) //Informacion
        { 
            if(empleado.Accion == "Add")//Agregar
            {

                //WCF
                ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
                //WCF
                var result = empleadoWCF.Add(empleado);

                //MVC
                // ML.Result result = BL.Empleado.Add(empleado);
                if (result.Correct)
                {
                    ViewBag.Mensaje = "Empleado agregado con EXITO";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un ERROR" + result.ErrorMessage;
                }

            }
            else//Actualiza
            {
                //WCF
                ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
                //WCF
                var result = empleadoWCF.Update(empleado);

                //MVC
                //ML.Result result = BL.Empleado.Update(empleado);    
                if (result.Correct) 
                {
                    ViewBag.Mensaje = "Empleado Actualizado con EXITO!!";
                }
                else
                {
                    ViewBag.Mensaje = "Ocurrio un ERROR" + result.ErrorMessage;

                }

            }

            return PartialView("Modal");   

        }

        public ActionResult Delete(string NumeroEmpleado)
        {
            //WCF
            ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
            //WCF
            var result = empleadoWCF.Delete(NumeroEmpleado);

            //MVC
            // ML.Result result = BL.Empleado.Delete(NumeroEmpleado);

            if (result.Correct)
            {
                ViewBag.Mensaje = "Empleado Eliminado con EXITO";
            }
            else
            {
                ViewBag.Mensaje = "Ocurrio un ERROR" + result.ErrorMessage;
            }

            return PartialView("Modal");

        }
    }
}