using ML;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL_MVC.Controllers
{
    public class CargaMasivaController : Controller
    {
        // GET: CargaMasiva
        public ActionResult Cargar()
        {

            ML.Result result = new ML.Result();
            result.Objects = new List<Object>();
            return View(result);
        }

        [HttpPost]


        public ActionResult Cargar (ML.Result result)
        {
            HttpPostedFileBase file = Request.Files["Excel"];
            if(Session["pathExcel"] == null) 
            {
                if(file != null)
                {
                    string extensionArchivo = Path.GetExtension(file.FileName).ToLower();
                    string extensionValida = ConfigurationManager.AppSettings ["TipoExcel"];

                    if(extensionArchivo == extensionValida)
                    {

                        string rutaProyecto = Server.MapPath("~/CargaMasiva/");
                        string filePath = rutaProyecto + Path.GetFileNameWithoutExtension(file.FileName) + '_' + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx"; ;

                        if(!System.IO.File.Exists(filePath)) 
                        {
                            file.SaveAs(filePath);

                            string connectionString = ConfigurationManager.ConnectionStrings["OleDbConnection"] + filePath;
                            ML.Result resultUsuarios = BL.Usuario.LeerExcel(connectionString);
                           
                            if(resultUsuarios.Correct)
                            {
                                ML.Result resultValidacion = BL.Usuario.ValidarExcel(resultUsuarios.Objects);
                                if(resultValidacion.Objects.Count == 0)
                                {
                                    resultValidacion.Correct = true;
                                    Session["pathExcel"] = filePath;
                                }

                                return View(resultValidacion);
                            }
                            else
                            {
                                ViewBag.Mensaje = "El Excel No tiene registros";
                            }

                        }

                    }

                    else
                    {
                        ViewBag.Mensaje = "Favor de de seleccionar un archivo .xlsx, Verifique su archivo";
                    }
                }
                else
                {
                    ViewBag.Mensaje = "No selecciono ningun archivo, Seleccione uno correctamente";
                }
                return View (result);

            }
            else
            {
                string filepath = Session["pathExcel"].ToString();

                if(filepath != null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["OleDbConnection"] + filepath;
                    ML.Result resultUsuarios = BL.Usuario.LeerExcel(connectionString);

                    if(resultUsuarios.Correct) 
                    {
                        foreach(ML.Usuario usuario in resultUsuarios.Objects) 
                        { 
                            ML.Result result1 = BL.Usuario.AddEF(usuario);
                            if (!result1.Correct)
                            {
                                //Crear un txt con los errores
                            }

                            Session["pathExcel"] = null;

                        }
                    }
                }
                else
                {

                }

            }
            return View(result);
        }

          

    }
  
}