using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Settings
{
	public class AuthSettingSection
	{
		public string Audience { get; set; }

		public string Authority { get; set; }

		public string Modulus { get; set; }

		public string Exponent { get; set; }

		public bool RequireHttpsMetadata { get; set; }

		public string UserProfileApiUrl { get; set; }
	}
}
