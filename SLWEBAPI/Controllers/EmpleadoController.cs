using Microsoft.Ajax.Utilities;
using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace SLWEBAPI.Controllers
{

    [RoutePrefix("api/empleado")]
    public class EmpleadoController : ApiController
    {
        [Route("")]
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

        [Route("{NumeroEmpleado}")]
        [HttpPut]  

        public IHttpActionResult Update(string NumeroEmpleado, [FromBody] ML.Empleado empleado)
        {

            empleado.NumeroEmpleado = NumeroEmpleado;   
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

        [Route("{NumeroEmpleado}")]
        [HttpDelete]  

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

        [Route("getall/{IdEmpresa}/{Nombre}")]
        [HttpGet]
        public IHttpActionResult GetAll(int? IdEmpresa, string Nombre, [FromBody] ML.Empleado empleado)
        {
            if (IdEmpresa == 0)
            {
                IdEmpresa = 0;

            }
            if (Nombre == null)
            {
                empleado.Nombre = "";

            }
            ML.Result result = BL.Empleado.GetAll(IdEmpresa.Value, Nombre);
            if(result.Correct) 
            {
                return Content(HttpStatusCode.OK, result);
            
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }


        [Route("{NumeroEmpleado}")]
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
