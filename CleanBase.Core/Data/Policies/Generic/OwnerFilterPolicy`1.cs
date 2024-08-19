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
	public class OwnerFilterPolicy<T> : IFilterPolicy<T> where T : IOwnerEntity
	{
		private ICoreProvider _coreProvider;
		public OwnerFilterPolicy(ICoreProvider coreProvider) => this._coreProvider = coreProvider;

		public Expression<Func<T, bool>> Predicate()
		{
			Guid user = this._coreProvider.IdentityProvider.Identity.UserId;
			return (Expression<Func<T, bool>>)(p => p.CreatedBy == user);
		} 

	}
}
