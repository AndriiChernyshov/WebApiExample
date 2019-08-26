using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace WebApiExample.Common.Logging
{
	public interface ILogManager
	{
		ILog GetLog(Type typeAssociatedWithRequestedLog);
	}
}
