using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Domain
{
	public class UserProfileBasic
	{
		public Guid Id { get; set; }
		public string FullName { get; set; }
		public string UserName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public bool Active { get; set; }
		public string ImageProfile { get; set; }
		public IEnumerable<RolePermissionBasic> Roles { get; set; }	
	}
}
