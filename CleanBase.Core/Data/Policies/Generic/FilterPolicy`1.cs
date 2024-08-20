using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class FilterPolicy<T> : IFilterPolicy<T>
	{
		protected Expression<Func<T, bool>> Expression { get; set; }

		public FilterPolicy() { }
		public FilterPolicy(Expression<Func<T, bool>> expression) => Expression = expression;

		public Expression<Func<T, bool>> Predicate() => this.Expression;
		
	}
}
