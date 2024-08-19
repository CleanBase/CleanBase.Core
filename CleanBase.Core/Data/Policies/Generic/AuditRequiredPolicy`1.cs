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
		private readonly Guid _userId;

		public AuditRequiredPolicy(Guid userId) => _userId = userId;

		public AuditRequiredPolicy(ICoreProvider coreProvider)
		{
			var identityProvider = coreProvider.IdentityProvider;
			_userId = identityProvider?.Identity?.UserId ?? Guid.Empty;
		}

		public void ChallengeAfterAdd(T entity)
		{
			entity.CreatedBy = entity.UpdatedBy == Guid.Empty ? _userId : entity.CreatedBy;
			entity.CreatedDate = DateTime.UtcNow;
			entity.UpdatedBy = entity.UpdatedBy == Guid.Empty ? _userId : entity.UpdatedBy;
			entity.UpdatedDate = entity.CreatedDate;
		}

		public void ChallengeBeforeAdd(T entity)
		{
			entity.CreatedBy = entity.UpdatedBy == Guid.Empty ? _userId : entity.CreatedBy;
			entity.CreatedDate = DateTime.UtcNow;
			entity.UpdatedBy = entity.UpdatedBy == Guid.Empty ? _userId : entity.UpdatedBy;
			entity.UpdatedDate = entity.CreatedDate;
		}
		public void ChallengeAfterUpdate(T entity)
		{
			entity.UpdatedBy = _userId;
			entity.UpdatedDate = DateTime.UtcNow;
		}
		public void ChallengeBeforeUpdate(T entity)
		{
			entity.UpdatedBy = entity.UpdatedBy == Guid.Empty ? _userId : entity.UpdatedBy;
			entity.UpdatedDate = DateTime.UtcNow;
		}
	}
}
