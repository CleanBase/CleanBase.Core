using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Settings
{
	public class EmailSettings
	{
		public string Account { get; set; }

		public string Password { get; set; }

		public string ApiKey { get; set; }

		public string Host { get; set; }

		public int Port { get; set; }

		public bool EnableSSL { get; set; }

		public string FromEmailDefault { get; set; }

		public string FromNameDefault { get; set; }
	}
}
