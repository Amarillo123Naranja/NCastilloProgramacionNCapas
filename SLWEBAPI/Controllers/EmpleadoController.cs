using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLWEBAPI.Controllers
{
    public class EmpleadoController : ApiController
    {
        [Route("api/empleado/add")]
        [HttpPost]
        public IHttpActionResult Add(ML.Empleado empleado)
        {
            ML.Result result = BL.Empleado.Add(empleado);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }

        }

        [Route("api/empleado/update")]
        [HttpPost]  

        public IHttpActionResult Update(ML.Empleado empleado)
        {
            ML.Result result = BL.Empleado.Update(empleado);    
            if (result.Correct) 
            {
                return Content(HttpStatusCode.OK, result);  
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);  
            }

        }

        [Route("api/empleado/delete")]
        [HttpGet]  

        public IHttpActionResult Delete (string NumeroEmpleado)
        {
            ML.Result result = BL.Empleado.Delete(NumeroEmpleado);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }

            else 
            {
                return Content(HttpStatusCode.BadRequest, result);
            
            }
        }

        [Route("api/empleado/getall")]
        [HttpGet]
        public IHttpActionResult GetAll(int IdEmpresa, string Nombre)
        {
            ML.Result result = BL.Empleado.GetAll(IdEmpresa, Nombre);
            if(result.Correct) 
            {
                return Content(HttpStatusCode.OK, result);
            
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }


        [Route("api/empleado/getbyid")]
        [HttpGet]
        public IHttpActionResult GetById(string NumeroEmpleado)
        {
            ML.Result result = BL.Empleado.GetById(NumeroEmpleado);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);  
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        } 
    }
}
