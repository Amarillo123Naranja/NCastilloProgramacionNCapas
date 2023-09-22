using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PL_MVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        //Checar Imagen - Validacion
        //Checar Status - Validacion
        //Checar tabla con Javascript

        [HttpGet] //Mostrar la vista 
        public ActionResult GetAll()
        {
            
            ML.Usuario usuario = new ML.Usuario();
            usuario.Nombre = "";
            usuario.ApellidoPaterno = "";
            ML.Result result = BL.Usuario.GetAllEF(usuario.Nombre, usuario.ApellidoPaterno);
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

            usuario.Usuarios = result.Objects;
            if (result.Correct)
            {

                return View(usuario);

            }

            else
            {

                return View();

            }
        }


        [HttpPost]
        public ActionResult GetAll(string Nombre, string ApellidoPaterno)
        {
            ML.Usuario usuario = new ML.Usuario();
            
                if (usuario.Nombre == null)
                {
                    usuario.Nombre = "";
                }
                if (usuario.ApellidoPaterno == null)
                {
                    usuario.ApellidoPaterno = "";
                }

                ML.Result result = BL.Usuario.GetAllEF(Nombre, ApellidoPaterno);
                usuario = new ML.Usuario();
                usuario.Usuarios = result.Objects;
                return View(usuario);
            


        }


        [HttpGet] //Mostrar la vista
        public ActionResult Form(int? IdUsuario)
        {

            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();
            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

            ML.Result resultRol = BL.Rol.GetAll();
            ML.Result resultPais = BL.Pais.GetAll();
            //ML.Result resultEstado = BL.Estado.GetByIdPais(IdPais);
            //ML.Result resultMunicipio = BL.Municipio.GetByIdEstado(IdEstado);
            //ML.Result resultColonia = BL.Colonia.GetByIdMunicipio(IdMunicipio);

            if (IdUsuario != null)//UPDATE -> Actualiza
            {
                ML.Result result = BL.Usuario.GetByIdEF(IdUsuario.Value);
                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;
                    usuario.Rol.Roles = resultRol.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                    usuario.Direccion.Colonia.Municipio.Estado.Estados = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais).Objects;
                    usuario.Direccion.Colonia.Municipio.Municipios = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado).Objects;
                    usuario.Direccion.Colonia.Colonias = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio).Objects;

                }




            }
            else //Add -> Agregar
            {

                usuario.Rol.Roles = resultRol.Objects;//Pase Lista de Roles
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;//Pase lista de Paises
                                                                                            //usuario.Direccion.Estado.Estados = resultEstado.Objects;//Pase Lista de Estados
                                                                                            //usuario.Direccion.Estado.Municipio.Municipios = resultMunicipio.Objects;//Lista Municipios
                                                                                            //usuario.Direccion.Estado.Municipio.Colonia.Colonias = resultColonia.Objects;   //Lista Colonias

            }



            return View(usuario);



        }


        [HttpPost]//Cuando queremos insertar informacion

        //GET BY ID
        public ActionResult Form(ML.Usuario usuario)

        {


            if (ModelState.IsValid)
            { //Este if valida los decoradores de ML

                HttpPostedFileBase file = Request.Files["Imagen"];
                if (file.ContentLength > 0)
                {
                    usuario.Imagen = ConvertirABase64(file);
                }
                

                if (usuario.IdUsuario == 0)//ADD -> Agregar
                {
                    ML.Result result = BL.Usuario.AddEF(usuario);

                    if (result.Correct)
                    {
                        ViewBag.Mensaje = "Registro completado con exito";
                        ViewBag.Correo = true;
                    }
                    else
                    {

                        ViewBag.Mensaje = ":::El registro no se guardo:::" + result.ErrorMessage;

                        return View();

                    }
                }

                else //UPDATE - Actualiza
                {
                    ML.Result result = BL.Usuario.UpdateEF(usuario);


                    if (result.Correct)
                    {
                        ViewBag.Mensaje = "Se ha completado la actualizacion";
                        ViewBag.Correo = true;
                    }
                    else
                    {

                        ViewBag.Mensaje = ":::ERROR:: Actualizacion no Completada" + result.ErrorMessage;
                        return View();
                    }

                }
            }
            else
            {
                //Hay que llamar a nuestros metodos para devolver las listas
                ML.Result resultRol = BL.Rol.GetAll();
                ML.Result resultPais = BL.Pais.GetAll();
                //Se mandan a llamar las listas que el usuario selecciona
                usuario.Rol.Roles = resultRol.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Estados = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais).Objects;
                usuario.Direccion.Colonia.Municipio.Municipios = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado).Objects;
                usuario.Direccion.Colonia.Colonias = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio).Objects;
                return View(usuario);
            }

            return PartialView("Modal");
        }
    

        [HttpGet]//Mostrar la vista
        public ActionResult Delete(int IdUsuario)
        {
            ML.Result result = BL.Usuario.DeleteEF(IdUsuario);

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

        public JsonResult EstadoGetByIdPais(int IdPais) 
        
        {
            ML.Result result = BL.Estado.GetByIdPais(IdPais);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);    

        }

        public JsonResult MunicipioGetByIdEstado(int IdEstado)

        {
            ML.Result result = BL.Municipio.GetByIdEstado(IdEstado);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);

        }

        public JsonResult ColoniaGetByIdMunicipio(int IdMunicipio)

        {
            ML.Result result = BL.Colonia.GetByIdMunicipio(IdMunicipio);
            return Json(result.Objects, JsonRequestBehavior.AllowGet);

        }

        public string ConvertirABase64(HttpPostedFileBase Foto)
        {
            System.IO.BinaryReader reader = new System.IO.BinaryReader(Foto.InputStream);
            byte[] data = reader.ReadBytes((int)Foto.ContentLength);
            string imagen = Convert.ToBase64String(data);
            return imagen;
        }

        public JsonResult ChangeStatus(int IdUsuario, bool Status)
        {
            ML.Result result = BL.Usuario.ChangeStatus(IdUsuario,Status);
            return Json(null);
        }

        [HttpGet]
        public ActionResult Login() 
        {
        return View();  
        }


        [HttpPost]
        public ActionResult Login(string correo, string contraseña) 
        {

            
            ML.Result result = BL.Usuario.GetByEmail(correo);
          
     

            if (result.Correct)//Se valida si existe la cuenta

            {
                ML.Usuario usuario = (ML.Usuario)result.Object;

                if (contraseña == usuario.Contraseña)//Se valida la contraseña
                {

                    return RedirectToAction("Index", "Home");


                }
                else
                {
                    ViewBag.Mensaje = "Contraseña Incorrecta";
                    ViewBag.Correo = false;
                    return RedirectToAction("Login", "Usuario");

                   
                }

               
            }
            else//No existe la cuenta
            {
                ViewBag.Mensaje = "No existe la cuenta";
                ViewBag.Correo = false;
                return PartialView("Modal");
                

            }


        }


    }
}