using System.Web.Http;

namespace WebApiExample.Web.Common.Routing
{
	public class ApiVersion1RoutePrefixAttribute : RoutePrefixAttribute
	{
		private const string RouteBase = "api/{apiVersion:apiVersionConstraint(v1)}";
		private const string PrefixRouteBase = RouteBase + "/";

		public ApiVersion1RoutePrefixAttribute(string routePrefix) : base(string.IsNullOrEmpty(routePrefix) ? RouteBase : PrefixRouteBase + routePrefix)
		{

		}

	}
}
