using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SLWEBAPI.Controllers
{
    public class AseguradoraController : ApiController
    {

        [Route("api/aseguradora/add")]
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

        [Route("api/aseguradora/update")]
        [HttpPost]

        public IHttpActionResult Update(ML.Aseguradora Aseguradora)
        {
            ML.Result result = BL.Aseguradora.Update(Aseguradora);  

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);  
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
            
        }

        [Route("api/aseguradora/delete")]
        [HttpGet] 

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

        [Route("api/aseguradora/getall")]
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

        //[Route("api/aseguradora/getbyid")]
        //[HttpPost]   

        //public IHttpActionResult GetById(int IdAseguradora)
        //{
        //    ML.Result result = BL.Aseguradora.GetById(IdAseguradora);   

        //    if(result.Correct)
        //    {
        //        return Content(HttpStatusCode.OK, result);
        //    }
        //    else
        //    {
        //        return Content{HttpStatusCode.BadRequest, result};
        //    }
        //}
    }
}
