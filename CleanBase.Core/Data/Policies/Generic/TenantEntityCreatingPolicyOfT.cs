using CleanBase.Core.Entities.Base;
using CleanBase.Core.Services.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class TenantEntityCreatingPolicyOfT<T> : IAddPolicyOfT<T> where T : ITenanEntity
	{
		private ICoreProvider _coreProvider;

		TenantEntityCreatingPolicyOfT(ICoreProvider coreProvider) => _coreProvider = coreProvider;
		public void ChallengeAfterAdd(T entity)
		{
			_coreProvider.Logger.Information<T>("Tenan success added",entity);
		}

		public void ChallengeBeforeAdd(T entity)
		{
			_coreProvider.Logger.Information<T>("Tenan starting add",entity);

			if (!string.IsNullOrEmpty(entity.TenantId))
			{
				_coreProvider.Logger.Information<T>("Tenan error add with null", entity);
				return;
			}

			entity.TenantId = this._coreProvider.IdentityProvider.Identity.TenantId;
		}
	}
}
