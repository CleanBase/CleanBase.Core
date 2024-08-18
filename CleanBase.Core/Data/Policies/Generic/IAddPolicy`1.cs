using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public interface IAddPolicy<T> : IModificationPolicy<T>
	{
		void ChallengeBeforeAdd(T entity);
		void ChallengeAfterAdd(T entity);
	}
}
