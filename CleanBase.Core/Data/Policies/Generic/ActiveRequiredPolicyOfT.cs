using CleanBase.Core.Data.Policies.Base;
using CleanBase.Core.Domain.Exceptions;
using CleanBase.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class ActiveRequiredPolicyOfT<T> :
		FilterPolicyOfT<T>,
		IFindPolicyOfT<T>,
		IDeletePolicyOfT<T>,
		IActiveFilter 
		where T : IEntityActive
	{
		public ActiveRequiredPolicyOfT()
		  : base((p => !p.IsDeleted))
		{
		}

		public void ChallengeDelete(T entity)
		{
			if (entity is null)
				return;

			entity.IsDeleted = true;
		}

		public void ChallengeFind(T entity)
		{
			if(entity.IsDeleted) 
				throw new DomainValidationException("Object is deleted");
		}
	}
}
