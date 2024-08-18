using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Settings
{
	public class AppSettings<T> : AppSettings where T : AppSettings
	{
		public static T Instance { get; set; }
	}
}
