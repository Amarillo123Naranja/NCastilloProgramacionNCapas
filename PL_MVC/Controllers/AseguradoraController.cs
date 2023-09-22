using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        //MVC
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

        [HttpGet]
        //WCF
        public ActionResult GetAll()
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            ServiceReferenceAseguradora.ServiceAseguradoraClient usuarioWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();   
            //llamando al servicio
            var result = usuarioWCF.GetAll();

            if (result.Correct)
            {
                aseguradora.Aseguradoras = result.Objects.ToList();
            }
            return View(aseguradora);

            }

        [HttpGet]

        public ActionResult Form(int? IdAseguradora) 
        {
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.Usuario = new ML.Usuario();

            ML.Result resultUsuario = BL.Usuario.UsuarioDrop();

            if(IdAseguradora != null) //UPDATE
            {
                //WCF
                ServiceReferenceAseguradora.ServiceAseguradoraClient usuarioWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();
                //WCF
                var result = usuarioWCF.GetById(IdAseguradora.Value);
                //MVC
                //ML.Result result = BL.Aseguradora.GetById(IdAseguradora.Value);
                if(result.Correct) 
                {

                    aseguradora = (ML.Aseguradora)result.Object;
                    aseguradora.Usuario.Usuarios = resultUsuario.Objects;

                }
            }
            else
            {
                aseguradora.Usuario.Usuarios = resultUsuario.Objects;

            }

            return View(aseguradora);   
        }


        [HttpPost]//Insertar Informacion

        public ActionResult Form(ML.Aseguradora aseguradora)

        {

         if(aseguradora.IdAseguradora == 0)//ADD -> Agregar
            {
                //WCF
                ServiceReferenceAseguradora.ServiceAseguradoraClient usuarioWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();
                //WCF
                var result = usuarioWCF.Add(aseguradora);
                //MVC
                //ML.Result result = BL.Aseguradora.Add(aseguradora);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Registro completado con exito";

                }
                else
                {
                    ViewBag.Mensaje = ":::Error:::" + result.ErrorMessage;


                }

            }
            else //UPDATE - Actualiza
            {

                ServiceReferenceAseguradora.ServiceAseguradoraClient usuarioWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();
                //WCF
                var result = usuarioWCF.Update(aseguradora);

                //MVC
                //ML.Result result = BL.Aseguradora.Update(aseguradora);


                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se ha completado la actualizacion";
                }
                else
                {
                    ViewBag.Mensaje = ":::ERROR::" + result.ErrorMessage;  
                }
            }

            return PartialView("Modal");

        }

    

        public ActionResult Delete(int IdAseguradora) 
        
        {
            //WCF
            ServiceReferenceAseguradora.ServiceAseguradoraClient usuarioWCF = new ServiceReferenceAseguradora.ServiceAseguradoraClient();
            //WCF
            var result = usuarioWCF.Delete(IdAseguradora);

            //MVC
            //ML.Result result = BL.Aseguradora.Delete(IdAseguradora);

            if (result.Correct)
            {
                ViewBag.Mensaje = "Registro eliminado con exito!!!";
                
            }
            else
            {
                ViewBag.Mensaje = ":::Error, No se elimino el Registro:::" + result.ErrorMessage;
            
            }

             return PartialView("Modal");
        }

    }
}