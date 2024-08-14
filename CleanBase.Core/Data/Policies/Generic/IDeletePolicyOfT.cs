using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public interface IDeletePolicyOfT<T> : IModificationPolicyOfT<T>
	{
		void ChalengeDelete(T entity);
	}
}
