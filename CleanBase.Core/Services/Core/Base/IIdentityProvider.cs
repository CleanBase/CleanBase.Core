using CleanBase.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Base
{
	public interface IIdentityProvider
	{
		string RequestId { get; set; }
		IdentityInfo Identity { get; set; }

		T GetIdentityAs<T>() where T : IdentityInfo;

		Task UpdateIdentity(ClaimsPrincipal user, string token);
	}
}
