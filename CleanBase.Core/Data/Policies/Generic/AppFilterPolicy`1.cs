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
	public class AppFilterPolicy<T> : IFilterPolicy<T> where T : IAppEntity
	{
		private ICoreProvider _coreProvider;
		public AppFilterPolicy(ICoreProvider coreProvider) => this._coreProvider = coreProvider;

		public Expression<Func<T, bool>> Predicate()
		{
			string appId = this._coreProvider.IdentityProvider.Identity.AppId;
			return (p => p.AppId == appId);
		}

	}
}
