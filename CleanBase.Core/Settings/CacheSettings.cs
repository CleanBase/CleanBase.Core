using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Settings
{
	public class CacheSettings
	{
		public long SlidingExpiration { get; set; } = 60;

		public long AbsoluteExpiration { get; set; } = 300;  
		public bool EnableCaching { get; set; } = true;      
		public string CacheProvider { get; set; }        
	}
}
