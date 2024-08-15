using CleanBase.Core.Entities.Base;
using CleanBase.Core.Services.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class AppEntityCreatingPolicyOfT<T> : IAddPolicyOfT<T> where T : IAppEntity
	{
		private readonly ICoreProvider _coreProvider;

		public AppEntityCreatingPolicyOfT(ICoreProvider coreProvider) => _coreProvider = coreProvider;

		public void ChallengeAfterAdd(T entity)
		{
			_coreProvider.Logger.Information<T>("Creating entity app succsess",entity);
		}

		public void ChallengeBeforeAdd(T entity)
		{
			if (string.IsNullOrEmpty(entity.AppId))
			{
				entity.AppId = _coreProvider.IdentityProvider.Identity.AppId;
			}
		}
	}
}
