using PI4_Inleveropdracht_Web_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

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
        public string Get(int StudentId)
        {
            return "StudentId";
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

        //public ActionResult Index()
        //{
        //    IEnumerable<Student> students = null;

        //    using (var client = new HttpClient())
         //   {
         //       client.BaseAddress = new Uri("http://localhost:44344/api/");
         //       //HTTP GET
         //       var responseTask = client.GetAsync("student");
         //       responseTask.Wait();

         //       var result = responseTask.Result;
          //      if (result.IsSuccessStatusCode)
         //       {
         //           var readTask = result.Content.ReadAsAsync<IList<Student>>();
         //           readTask.Wait();
         
         //           students = readTask.Result;
         //       }
         //       else //web api sent error response 
         //       {
                    //log response status here..

         //           students = Enumerable.Empty<Student>();

          //          ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
         //      }
         //   }
         //   return View(students);
        //}

        //private ActionResult View(IEnumerable<Student> students)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

