using CleanBase.Core.Entities;
using CleanBase.Core.Services.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class OwnerOrSystemFilterPolicyOfT<T> : IFilterPolicyOfT<T> where T : IOwnerOrSystemEntity
	{
		private ICoreProvider _coreProvider;

		public OwnerOrSystemFilterPolicyOfT(ICoreProvider coreProvider) => _coreProvider = coreProvider;

		public Expression<Func<T, bool>> Predicate()
		{
			string user = this._coreProvider.IdentityProvider.Identity.UserName;
			return (Expression<Func<T, bool>>)(p => p.CreatedBy == "system" || p.CreatedBy == user);
		}
	}
}
