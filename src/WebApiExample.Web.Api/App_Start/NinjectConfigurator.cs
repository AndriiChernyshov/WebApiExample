using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net.Config;
using Ninject;
using WebApiExample.Common;
using WebApiExample.Common.Logging;

namespace WebApiExample.Web.Api.App_Start
{
	public class NinjectConfigurator
	{
		public void Configure(IKernel container)
		{
			AddBindings(container);
		}

		private void AddBindings(IKernel container)
		{
			ConfigureLog4net(container);

			container.Bind<IDateTime>().To<DateTimeAdapter>().InSingletonScope();
		}

		private void ConfigureLog4net(IKernel container)
		{
			XmlConfigurator.Configure();

			var logManager = new LogManagerAdapter();
			container.Bind<ILogManager>().ToConstant(logManager);
		}
	}
}