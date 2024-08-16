using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Settings
{
	public class AzureStorageSetting
	{
		public string BlobConnectionString { get; set; }

		public string ContainerName { get; set; }
		public string AccountName { get; set; }        
		public string AccountKey { get; set; }          
		public string EndpointSuffix { get; set; }       
		public bool UseHttps { get; set; } = true;
	}
}
