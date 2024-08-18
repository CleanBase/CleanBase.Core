using CleanBase.Core.Entities;
using CleanBase.Core.Services.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class AuditRequiredPolicy<T> : IAddPolicy<T>, IUpdatePolicy<T> where T : IEntityAudit
	{
		private readonly string _userName;

		public AuditRequiredPolicy(string userName) => _userName = userName;

		public AuditRequiredPolicy(ICoreProvider coreProvider)
		{
			var identityProvider = coreProvider.IdentityProvider;
			_userName = identityProvider?.Identity?.UserName ?? string.Empty;
		}

		public void ChallengeAfterAdd(T entity)
		{
			entity.CreatedBy = string.IsNullOrEmpty(entity.CreatedBy) ? _userName : entity.CreatedBy;
			entity.CreatedDate = DateTime.UtcNow;
			entity.UpdatedBy = string.IsNullOrEmpty(entity.UpdatedBy) ? _userName : entity.UpdatedBy;
			entity.UpdatedDate = entity.CreatedDate;
		}

		public void ChallengeBeforeAdd(T entity)
		{
			entity.CreatedBy = string.IsNullOrEmpty(entity.CreatedBy) ? _userName : entity.CreatedBy;
			entity.CreatedDate = DateTime.UtcNow;
			entity.UpdatedBy = string.IsNullOrEmpty(entity.UpdatedBy) ? _userName : entity.UpdatedBy;
			entity.UpdatedDate = entity.CreatedDate;
		}
		public void ChallengeAfterUpdate(T entity)
		{
			entity.UpdatedBy = _userName;
			entity.UpdatedDate = DateTime.UtcNow;
		}
		public void ChallengeBeforeUpdate(T entity)
		{
			entity.UpdatedBy = string.IsNullOrEmpty(entity.UpdatedBy) ? _userName : entity.UpdatedBy;
			entity.UpdatedDate = DateTime.UtcNow;
		}
	}
}
