using ML;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Web.Mvc;
//using System.Web.Http;


namespace PL_MVC.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado


        //Este codigo es MVC BL
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



        //Este codigo es para consumir SOAP
        //[HttpGet]// Mostrar la vista
        //public ActionResult GetAll()
        //{
        //    ML.Empleado empleado = new ML.Empleado();
        //    empleado.Empresa = new ML.Empresa();
        //    empleado.Empresa.IdEmpresa = 0;
        //    empleado.Nombre = "";
        //    ML.Result resultEmpresa = BL.Empresa.GetAll();
        //    empleado.Empresa.Empresas = resultEmpresa.Objects;

        //    //WCF
        //    ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
        //    //WCF
        //    var result = empleadoWCF.GetAll(empleado.Empresa.IdEmpresa, empleado.Nombre);
        //    //WCF
        //    if (result.Correct)
        //    {
        //        empleado.Empleados = result.Objects.ToList();
        //    }
        //    return View(empleado);
        //}



        //Este codigo es para consumir REST
        [HttpGet]// Mostrar la vista
        public ActionResult GetAll()
        {
            ML.Empleado empleado = new ML.Empleado();
            empleado.Empleados = new List<Object>();
            empleado.Empresa = new ML.Empresa();
            empleado.Empresa.IdEmpresa = 0;
            empleado.Nombre = "";

            //Llamando al servicio
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var responseTask = client.GetAsync($"getall?IdEmpresa=&Nombre=");
                responseTask.Wait();

                var resultServicio = responseTask.Result;

                if (resultServicio.IsSuccessStatusCode)
                {
                    var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                    readTask.Wait();

                    foreach (var resultEmpleado in readTask.Result.Objects)
                    {
                        ML.Empleado resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Empleado>(resultEmpleado.ToString());
                        empleado.Empleados.Add(resultItemList);
                    }
                }
            }
            return View(empleado);
        }






        //Este codigo se consume con SOAP//MVC
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
        //    //WCF
        //    ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
        //    //WCF
        //    var result = empleadoWCF.GetAll(IdEmpresa, Nombre);
        //    //WCF

        //    ML.Result resultEmpresa = BL.Empresa.GetAll();
        //    empleado.Empresa.Empresas = resultEmpresa.Objects;

        //    //WCF
        //    if (result.Correct)
        //    {
        //        empleado.Empleados = result.Objects.ToList();
        //    }
        //    return View(empleado);


        //Este codigo es para consumir REST

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


            empleado = new ML.Empleado();
            empleado.Empleados = new List<Object>();
            ML.Result resultEmpresa = BL.Empresa.GetAll();
            empleado.Empresa.Empresas = resultEmpresa.Objects;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var responseTask = client.GetAsync($"getall?IdEmpresa=&Nombre=");
                responseTask.Wait();

                var resultServicio = responseTask.Result;

                if (resultServicio.IsSuccessStatusCode)
                {
                    var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                    readTask.Wait();

                    foreach (var resultEmpleado in readTask.Result.Objects)
                    {
                        ML.Empleado resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Empleado>(resultEmpleado.ToString());
                        empleado.Empleados.Add(resultItemList);
                    }
                }
            }

            return View(empleado);





        }



        //Este codigo se consume con SOAP y MVC
        //[HttpGet]
        //public ActionResult Form(string NumeroEmpleado)//Muestra la vista
        //{
        //    ML.Empleado empleado = new ML.Empleado();
        //    empleado.Empresa = new Empresa();
        //    ML.Result resultEmpresa = BL.Empresa.GetAll();

        //    if(NumeroEmpleado != null)//Actualiza
        //    {
        //        //WCF
        //        ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
        //        //WCF
        //        var result = empleadoWCF.GetById(NumeroEmpleado);


        //        //MVC
        //        //ML.Result result = BL.Empleado.GetById(NumeroEmpleado);
        //        if (result.Correct)
        //        {
        //            empleado = (ML.Empleado)result.Object;
        //            empleado.Empresa.Empresas = resultEmpresa.Objects;
        //            empleado.Accion = "Update";
        //        }
        //    }
        //    else//Agregar
        //    {
        //        empleado.Empresa.Empresas = resultEmpresa.Objects;
        //        empleado.Accion = "Add";
        //    }

        //    return View(empleado);  

        //}



        //Este codigo WEB API, se consume con REST
        [HttpGet]
        public ActionResult Form(string NumeroEmpleado)//Muestra la vista
        {
            ML.Empleado empleado = new ML.Empleado();
            empleado.Empresa = new Empresa();
            ML.Result resultEmpresa = BL.Empresa.GetAll();

            if (NumeroEmpleado != null)//Actualiza
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                    var responseTask = client.GetAsync("empleado/" + NumeroEmpleado);

                    responseTask.Wait();

                    var resultServicio = responseTask.Result;


                    if (resultServicio.IsSuccessStatusCode)
                    {

                        var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                        readTask.Wait();

                        ML.Empleado resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Empleado>(readTask.Result.Object.ToString());
                        empleado = resultItemList;
                    }
                }
                empleado.Empresa.Empresas = resultEmpresa.Objects;
                empleado.Accion = "Update";
            }
            else//Agregar
            {

                empleado.Empresa.Empresas = resultEmpresa.Objects;
                empleado.Accion = "Add";

          
            }

            return View(empleado);

        }

        ////Este codigo WCF Y MVC
        //[HttpPost]  
        //public ActionResult Form(ML.Empleado empleado) //Informacion
        //{ 
        //    if(empleado.Accion == "Add")//Agregar
        //    {

        //        //WCF
        //        ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
        //        //WCF
        //        var result = empleadoWCF.Add(empleado);

        //        //MVC
        //        // ML.Result result = BL.Empleado.Add(empleado);
        //        if (result.Correct)
        //        {
        //            ViewBag.Mensaje = "Empleado agregado con EXITO";
        //        }
        //        else
        //        {
        //            ViewBag.Mensaje = "Ocurrio un ERROR" + result.ErrorMessage;
        //        }

        //    }
        //    else//Actualiza
        //    {
        //        //WCF
        //        ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
        //        //WCF
        //        var result = empleadoWCF.Update(empleado);

        //        //MVC
        //        //ML.Result result = BL.Empleado.Update(empleado);    
        //        if (result.Correct) 
        //        {
        //            ViewBag.Mensaje = "Empleado Actualizado con EXITO!!";
        //        }
        //        else
        //        {
        //            ViewBag.Mensaje = "Ocurrio un ERROR" + result.ErrorMessage;

        //        }

        //    }

        //    return PartialView("Modal");   

        //}


        //Este codigo WEBAPI REST
        [HttpPost]
        public ActionResult Form(ML.Empleado empleado) //Informacion
        {
            if (empleado.Accion == "Add")//Agregar
            {
                //Llamamos al servicio
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync("empleado", empleado);
                    postTask.Wait();

                    var resultServicio = postTask.Result;

                    if (resultServicio.IsSuccessStatusCode)

                    {
                        ViewBag.Mensaje = "Empleado agregado con EXITO";
                    }
                    else
                    {

                        ViewBag.Mensaje = "Ocurrio un ERROR";
                    }

                }

            }
            else//Actualiza
            {

                //Llamamos al servicio
                using (var client = new HttpClient())
                {
                    string NumeroEmpleado = empleado.NumeroEmpleado;

                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                    //HTTP PUT
                    var putTask = client.PutAsJsonAsync("empleado/" + NumeroEmpleado, empleado);
                    putTask.Wait();

                    var resultServicio = putTask.Result;

                    if (resultServicio.IsSuccessStatusCode)
                    {
                        ViewBag.Mensaje = "Empleado Actualizado con EXITO!!";
                    }
                    else
                    {
                        ViewBag.Mensaje = "Ocurrio un ERROR";

                    }

                }

            }

            return PartialView("Modal");

        }

            
        
        
        
        
        
        
        ///Este codigo WCF SOAP Y MVC
        
        //public ActionResult Delete(string NumeroEmpleado)
        //{
        //    //WCF
        //    ServiceReferenceEmpleado.ServiceEmpleadoClient empleadoWCF = new ServiceReferenceEmpleado.ServiceEmpleadoClient();
        //    //WCF
        //    var result = empleadoWCF.Delete(NumeroEmpleado);

        //    //MVC
        //    // ML.Result result = BL.Empleado.Delete(NumeroEmpleado);

        //    if (result.Correct)
        //    {
        //        ViewBag.Mensaje = "Empleado Eliminado con EXITO";
        //    }
        //    else
        //    {
        //        ViewBag.Mensaje = "Ocurrio un ERROR" + result.ErrorMessage;
        //    }

        //    return PartialView("Modal");

        //}


        //Este Codigo WEBAPI REST
        public ActionResult Delete(string NumeroEmpleado)
        {

            //Llamamos al servicio
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                //HTTP POST
                var deleteTask = client.DeleteAsync("aseguradora/" + NumeroEmpleado);
                deleteTask.Wait();

                var resultServicio = deleteTask.Result;

                if (resultServicio.IsSuccessStatusCode)
                {

                    ViewBag.Mensaje = "Empleado Eliminado con EXITO";

                }
                else
                {

                    ViewBag.Mensaje = "Ocurrio un ERROR";

                }

            }

            return PartialView("Modal");

        }
    }
}