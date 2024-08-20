using CleanBase.Core.Data.Policies.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public interface IFilterPolicy<T> : IDataPolicy
	{
		Expression<Func<T, bool>> Predicate();
	}
}
