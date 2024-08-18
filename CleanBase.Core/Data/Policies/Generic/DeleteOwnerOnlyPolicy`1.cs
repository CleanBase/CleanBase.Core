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
		private readonly string _userName;
		private readonly bool _isSuperAdmin;

		public DeleteOwnerOnlyPolicy(string userName, bool isSuperAdmin)
		{
			_userName = userName;
			_isSuperAdmin = isSuperAdmin;
		}

		public override void ChallengeDelete(T entity)
		{
			base.ChallengeDelete(entity);

			if (!_isSuperAdmin && _userName != entity.CreatedBy)
			{
				 throw new DomainValidationException("The entity is created by another user");
			}
		}
	}
}

