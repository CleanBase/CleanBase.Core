using CleanBase.Core.Domain.Exceptions;
using CleanBase.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class DeleteOwnerOnlyPolicy<T> : ModificationPolicy<T>, IDeletePolicy<T> where T : IEntityAudit
	{
		private readonly Guid _userId;
		private readonly bool _isSuperAdmin;

		public DeleteOwnerOnlyPolicy(Guid userId, bool isSuperAdmin)
		{
			_userId = userId;
			_isSuperAdmin = isSuperAdmin;
		}

		public override void ChallengeDelete(T entity)
		{
			base.ChallengeDelete(entity);

			if (!_isSuperAdmin && _userId != entity.CreatedBy)
			{
				 throw new DomainValidationException("The entity is created by another user");
			}
		}
	}
}

