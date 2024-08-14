using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class NameOrderByPolicyOfT<T> : IOrderByPolictyOfT<T> where T : IEntityName
	{
		public IQueryable<T> OrderBy(IQueryable<T> query)
		=> query.OrderBy<T, string>((Expression<Func<T, string>>)(p => p.Name));
	}
}
