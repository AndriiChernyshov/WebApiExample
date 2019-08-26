using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiExample.Web.Api.Controllers
{
	[RoutePrefix("api/oldtasks2")]
    public class OldTasksController : ApiController
    {
        // GET: api/Tasks
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

		[Route("{id:int:max(100)}")]
		public string GetTaskWithAMaxIdOf100(int id)
		{
			return "In the GetTaskWithAMaxIdOf100(int id) method, id = " + id;
		}

		[HttpGet]
		[Route("{id:int:min(101)}")]
		public string FindTaskWithAMinIdOf101(int id)
		{
			return "In the FindTaskWithAMinIdOf101(int id) method, id = " + id;
		}

		[Route("api/tasks/{taskCode:alpha}")]
		public string Get(string taskCode)
		{
			return $"TaskCode is {taskCode}";
		}


		// POST: api/Tasks
		public void Post([FromBody]string value)
        {
        }

        // PUT: api/Tasks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tasks/5
        public void Delete(int id)
        {
        }
    }
}
