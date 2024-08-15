using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class FilterPolicyOfT<T> : IFilterPolicyOfT<T>
	{
		protected Expression<Func<T, bool>> Expression { get; set; }

		public FilterPolicyOfT() { }
		public FilterPolicyOfT(Expression<Func<T, bool>> expression) => Expression = expression;

		Expression<Func<T, bool>> Predicate() => this.Expression;

	}
}
