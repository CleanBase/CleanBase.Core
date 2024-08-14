using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public interface IUpdatePolicyOfT<T> : IModificationPolicyOfT<T>
	{
		void ChalengeBeforeUpdate(T entity);
		void ChalengeAfterUpdate(T entity);
	}
}
