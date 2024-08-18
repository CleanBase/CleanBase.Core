using CleanBase.Core.Entities.Base;
using CleanBase.Core.Services.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class TenantFilterPolicy<T> : IFilterPolicy<T> where T : ITenanEntity 
	{
		private ICoreProvider _coreProvider;

		public TenantFilterPolicy(ICoreProvider coreProvider) => _coreProvider = coreProvider;

		public Expression<Func<T, bool>> Predicate()
		{
			string tenantId = this._coreProvider.IdentityProvider.Identity.TenantId;
			return (p => p.TenantId == tenantId);
		}
	}
}
