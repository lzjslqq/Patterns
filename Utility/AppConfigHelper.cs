using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
	public class AppConfigHelper
	{
		public static object CreateInstance(string appKey)
		{
			if (string.IsNullOrEmpty(appKey)) return null;

			string assemblyName = null;
			try
			{
				assemblyName = System.Configuration.ConfigurationManager.AppSettings[appKey];
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Type type = Type.GetType(assemblyName);

			var instance = Activator.CreateInstance(type);
			return instance;
		}
	}
}