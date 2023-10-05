using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        //MVC Este codigo BL
        //[HttpGet]
        //public ActionResult GetAll()
        //{

        //    ML.Result result = BL.Aseguradora.GetAll();
        //    ML.Aseguradora aseguradora = new ML.Aseguradora();


        //    aseguradora.Aseguradoras = result.Objects;
        //    if (result.Correct)
        //    {

        //        return View(aseguradora);

        //    }

        //    else
        //    {

        //        return View();

        //    }
        //}

        ////Este codigo WCF SOAP
        //[HttpGet]
        //public ActionResult GetAll()
        //{
        //    ML.Aseguradora aseguradora = new ML.Aseguradora();

        //    ServiceReferenceAseguradora.ServiceAseguradoraClient usuarioWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();   
        //    //llamando al servicio
        //    var result = usuarioWCF.GetAll();

        //    if (result.Correct)
        //    {
        //        aseguradora.Aseguradoras = result.Objects.ToList();
        //    }
        //    return View(aseguradora);

        //    }

        //WEB API
        //Este codigo REST

        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.Aseguradoras = new List<Object>();

            //Llamando al servicio
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var responseTask = client.GetAsync("aseguradora/getall");
                responseTask.Wait();

                var resultServicio = responseTask.Result;

                if (resultServicio.IsSuccessStatusCode)
                {
                    var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                    readTask.Wait();

                    foreach (var resultAseguradora in readTask.Result.Objects)
                    {
                        ML.Aseguradora resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Aseguradora>(resultAseguradora.ToString());
                        aseguradora.Aseguradoras.Add(resultItemList);
                    }
                }
            }
            return View(aseguradora);
        }


        // [HttpGet]
        //Este es Codigo BL y tiene lineas de WCF
        //public ActionResult Form(int? IdAseguradora) 
        //{
        //    ML.Aseguradora aseguradora = new ML.Aseguradora();
        //    aseguradora.Usuario = new ML.Usuario();

        //    ML.Result resultUsuario = BL.Usuario.UsuarioDrop();

        //    if(IdAseguradora != null) //UPDATE
        //    {
        //        //WCF
        //        ServiceReferenceAseguradora.ServiceAseguradoraClient usuarioWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();
        //        //WCF
        //        var result = usuarioWCF.GetById(IdAseguradora.Value);
        //        //MVC
        //        //ML.Result result = BL.Aseguradora.GetById(IdAseguradora.Value);
        //        if(result.Correct) 
        //        {

        //            aseguradora = (ML.Aseguradora)result.Object;
        //            aseguradora.Usuario.Usuarios = resultUsuario.Objects;

        //        }
        //    }
        //    else
        //    {
        //        aseguradora.Usuario.Usuarios = resultUsuario.Objects;

        //    }

        //    return View(aseguradora);   
        //}


        //Este codigo WEB API REST
        [HttpGet]//Mostrar la vista
        public ActionResult Form(int? IdAseguradora)
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.Usuario = new ML.Usuario();
            ML.Result resultUsuario = BL.Usuario.UsuarioDrop();

            if (IdAseguradora != null) //Mostrar formulario para actualizar
            {
                //Llamando al servicio

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                    var responseTask = client.GetAsync("aseguradora/" + IdAseguradora);

                    responseTask.Wait();

                    var resultServicio = responseTask.Result;

                    if (resultServicio.IsSuccessStatusCode)
                    {
                        var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                        readTask.Wait();

                        ML.Aseguradora resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Aseguradora>(readTask.Result.Object.ToString());
                        aseguradora = resultItemList;

                    }

                    
                }

                aseguradora.Usuario.Usuarios = resultUsuario.Objects;
            }


            else //Mostrar la vista vacia
            {
             
                aseguradora.Usuario.Usuarios = resultUsuario.Objects;

            }

            return View(aseguradora);
        }



        //Este codigo BL y contiene lineas de WCF
        //[HttpPost]//Insertar Informacion

        //public ActionResult Form(ML.Aseguradora aseguradora)

        //{

        //    if (aseguradora.IdAseguradora == 0)//ADD -> Agregar
        //    {
        //        //WCF
        //        ServiceReferenceAseguradora.ServiceAseguradoraClient usuarioWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();
        //        //WCF
        //        var result = usuarioWCF.Add(aseguradora);
        //        //MVC
        //        //ML.Result result = BL.Aseguradora.Add(aseguradora);

        //        if (result.Correct)
        //        {
        //            ViewBag.Mensaje = "Registro completado con exito";

        //        }
        //        else
        //        {
        //            ViewBag.Mensaje = ":::Error:::" + result.ErrorMessage;


        //        }

        //    }
        //    else //UPDATE - Actualiza
        //    {

        //        ServiceReferenceAseguradora.ServiceAseguradoraClient usuarioWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();
        //        //WCF
        //        var result = usuarioWCF.Update(aseguradora);

        //        //MVC
        //        //ML.Result result = BL.Aseguradora.Update(aseguradora);


        //        if (result.Correct)
        //        {
        //            ViewBag.Mensaje = "Se ha completado la actualizacion";
        //        }
        //        else
        //        {
        //            ViewBag.Mensaje = ":::ERROR::" + result.ErrorMessage;
        //        }
        //    }

        //    return PartialView("Modal");

        //}



        [HttpPost]//Insertar Informacion
        public ActionResult Form(ML.Aseguradora aseguradora)

        {

            if (aseguradora.IdAseguradora == 0)//ADD -> Agregar
            {
                //Llamamos al servicio
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync("aseguradora", aseguradora);
                    postTask.Wait();    

                    var resultServicio = postTask.Result;

                    if (resultServicio.IsSuccessStatusCode)
                    {
                        ViewBag.Mensaje = ":::SE AGREGO CON EXITO:::";

                    }
                    else
                    {
                        ViewBag.Mensaje = ":::NO SE AGREGO LA ASEGURADORA:::";

                    }

                }

            }
            else //UPDATE - Actualiza
            {
                //Llamamos al servicio

                using(var client = new HttpClient()) 
                {
                   int IdAseguradora = aseguradora.IdAseguradora;

                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                    //HTTP PUT
                    var putTask = client.PutAsJsonAsync("aseguradora/" + IdAseguradora, aseguradora);
                    putTask.Wait();


                    var resultServicio = putTask.Result;

                    if (resultServicio.IsSuccessStatusCode)
                    {
                        ViewBag.Mensaje = ":::SE AGREGO CON EXITO:::";

                    }
                    else
                    {
                        ViewBag.Mensaje = ":::NO SE AGREGO LA ASEGURADORA:::";

                    }
                }

                
            }

            return PartialView("Modal");

        }








        //Este codigo WCF SOAP
        //public ActionResult Delete(int IdAseguradora) 

        //{
        //    //WCF
        //    ServiceReferenceAseguradora.ServiceAseguradoraClient usuarioWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();
        //    //WCF
        //    var result = usuarioWCF.Delete(IdAseguradora);

        //    //MVC
        //    //ML.Result result = BL.Aseguradora.Delete(IdAseguradora);

        //    if (result.Correct)
        //    {
        //        ViewBag.Mensaje = "Registro eliminado con exito!!!";

        //    }
        //    else
        //    {
        //        ViewBag.Mensaje = ":::Error, No se elimino el Registro:::" + result.ErrorMessage;

        //    }

        //     return PartialView("Modal");
        //}

        //Este codigo Web Api REST
        public ActionResult Delete(int IdAseguradora)

        {
            //Llamamos al servicio
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                //HTTP POST

                var deleteTask = client.DeleteAsync("aseguradora/" + IdAseguradora);
                deleteTask.Wait();

                var resultServicio = deleteTask.Result;
                if (resultServicio.IsSuccessStatusCode)
                {


                    ViewBag.Mensaje = "Registro eliminado con exito!!!";

                }

                else

                {

                    ViewBag.Mensaje = ":::Error, No se elimino el Registro:::";



                }


                return PartialView("Modal");
            }

                

            }
            
        }
}

