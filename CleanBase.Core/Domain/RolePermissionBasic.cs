using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Domain
{
	public class RolePermissionBasic
	{
		public string Role { get; set; }
		public List<string> Permissions { get; set; }
	}
}
