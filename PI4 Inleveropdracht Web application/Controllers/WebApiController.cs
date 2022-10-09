using PI4_Inleveropdracht_Web_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PI4_Inleveropdracht_Web_application.Controllers
{
    public class WebApiController : ApiController
    {
        // GET: api/WebApi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/WebApi/5
        public Student Get(int id, string StudentNaam, string StudetWachtwoord)
        {
            return StudentNaam;
        }

        // POST: api/WebApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WebApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WebApi/5
        public void Delete(int id)
        {
        }
    }
}
