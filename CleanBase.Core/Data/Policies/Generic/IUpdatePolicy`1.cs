using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public interface IUpdatePolicy<T> : IModificationPolicy<T>
	{
		void ChallengeBeforeUpdate(T entity);
		void ChallengeAfterUpdate(T entity);
	}
}
