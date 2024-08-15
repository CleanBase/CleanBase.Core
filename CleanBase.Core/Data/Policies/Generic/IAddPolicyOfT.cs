using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public interface IAddPolicyOfT<T> : IModificationPolicyOfT<T>
	{
		void ChallengeBeforeAdd(T entity);
		void ChallengeAfterAdd(T entity);
	}
}
