using CleanBase.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Base
{
	public class IdentityProvider : IIdentityProvider
	{
		public string RequestId { get; set; } = Guid.NewGuid().ToString();
		public IdentityInfo Identity { get; set; }
		public T GetIdentityAs<T>() where T : IdentityInfo => this.Identity as T;
		public virtual Task UpdateIdentity(ClaimsPrincipal user, string token)
		{
			this.Identity = new IdentityInfo(user);
			return Task.CompletedTask;
		}
	}
}
