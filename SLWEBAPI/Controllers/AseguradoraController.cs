using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLWEBAPI.Controllers
{
    [RoutePrefix("aseguradora")]
    public class AseguradoraController : ApiController
    {

        [Route("")]
        [HttpPost]

        public IHttpActionResult Add(ML.Aseguradora aseguradora)
        {
            ML.Result result = BL.Aseguradora.Add(aseguradora);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);    
            }

        }

        [Route("{IdAseguradora}")]
        [HttpPut]

        public IHttpActionResult Update(int IdAseguradora, [FromBody] ML.Aseguradora aseguradora)
        {

            aseguradora.IdAseguradora = IdAseguradora;
            ML.Result result = BL.Aseguradora.Update(aseguradora);  

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);  
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
            
        }

        [Route("{IdAseguradora}")]
        [HttpDelete] 

        public IHttpActionResult Delete(int IdAseguradora)
        {
            ML.Result result = BL.Aseguradora.Delete(IdAseguradora);    

            if(result.Correct)
            {
                return Content(HttpStatusCode.OK, result);  
            }

            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }

        [Route("getall")]
        [HttpGet]
        
        public IHttpActionResult GetAll()
        {
            ML.Result result = BL.Aseguradora.GetAll(); 
            if(result.Correct)
            {
                return Content(HttpStatusCode.OK, result);  
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }

        }

        [Route("{IdAseguradora}")]
        [HttpPost]

        public IHttpActionResult GetById(int IdAseguradora)
        {
            ML.Result result = BL.Aseguradora.GetById(IdAseguradora);

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
