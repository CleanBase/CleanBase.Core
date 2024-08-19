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
	public class OwnerOrSystemFilterPolicy<T> : IFilterPolicy<T> where T : IOwnerOrSystemEntity
	{
		private ICoreProvider _coreProvider;

		public OwnerOrSystemFilterPolicy(ICoreProvider coreProvider) => _coreProvider = coreProvider;

		public Expression<Func<T, bool>> Predicate()
		{
			Guid user = this._coreProvider.IdentityProvider.Identity.UserId;
			return (Expression<Func<T, bool>>)(p => p.CreatedBy.ToString() == "system" || p.CreatedBy == user);
		}
	}
}
