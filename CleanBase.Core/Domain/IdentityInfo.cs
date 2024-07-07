using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Domain
{
	public class IdentityInfo
	{
		protected virtual string UserNameClaimName { get; set; } = "PREFERRED_USERNAME";
		protected virtual string SubClaimName { get; set; } = "SUB";
		protected virtual string RoleClaimName => "ROLE";
		protected virtual string PermissionClaimName => "PERMISSION ";
		public string UserName { get; set; }
		public string Name { get; set; }
		public string Sub { get; set; }
		public IEnumerable<string> Apps { get; private set; }
		public bool IsSuperAdmin { get; private set; }
		public IEnumerable<string> Roles { get; private set; } = Enumerable.Empty<string>();
		public IEnumerable<string> Permissions { get; set; } = Enumerable.Empty<string>();
		public string AppId { get; set; }
		public string TenantId { get; set; }
		public List<string> TenanaIds { get; set; }

		protected virtual void Init(ClaimsPrincipal user)
		{
			if (user == null || user.Identity == null || !user.Identity.IsAuthenticated)
				return;

			this.UserName = user.FindFirst(this.UserNameClaimName)?.Value;

			this.Name = user.Identity.Name;

			this.Sub = user.FindFirst(this.SubClaimName)?.Value;

			this.Roles = (IEnumerable<string>)user
				.FindAll(this.RoleClaimName)
				.Select<Claim, string>((Func<Claim, string>)(p => p.Value))
				.ToList<string>();

			this.Permissions = (IEnumerable<string>)user
				.FindAll(this.PermissionClaimName)
				.Select<Claim, string>((Func<Claim, string>)(p => p.Value))
				.ToList<string>();
		}

		public IdentityInfo(ClaimsPrincipal user) => this.Init(user);

		public IdentityInfo(ClaimsPrincipal user, string userNameClaimName)
		{
			this.UserNameClaimName = userNameClaimName;	
			this.Init(user);
		}
	}
}
