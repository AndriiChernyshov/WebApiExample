﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.Http.Routing;
using WebApiExample.Web.Common;
using WebApiExample.Web.Common.Routing;

namespace WebApiExample.Web.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
	        var constraintsResolver = new DefaultInlineConstraintResolver();
			constraintsResolver.ConstraintMap.Add("apiVersionConstraint", typeof(ApiVersionConstraint));

			config.MapHttpAttributeRoutes(constraintsResolver);

			config.Services.Replace(typeof(IHttpControllerSelector), new NamespaceHttpControllerSelector(config));

			/*
            // Web API routes
            config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "FindByTaskCode",
				routeTemplate: "api/{controller}/{taskCode}",
				defaults: new { taskCode = RouteParameter.Optional}
				);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
			*/
        }
    }
}
