using System.Net.Http;
using System.Web.Http;
using WebApiExample.Web.Api.Models;
using WebApiExample.Web.Common.Routing;

namespace WebApiExample.Web.Api.Controllers.V1
{
	[ApiVersion1RoutePrefix("tasks")]
    public class TasksController : ApiController
    {
		[Route("", Name = "AddTaskRouteV1")]
		[HttpPost]
		public Task AddTask(HttpRequestMessage requestMessage, Task newTask)
		{
			return new Task()
			{
				Subject = $"In v1, newTask.Subject = {newTask.Subject}"
			};

		}
	}
}
