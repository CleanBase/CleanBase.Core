using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Base
{
	public class EntityCore : IEntityCore
	{
		public virtual void MarkDelete()
		{
		}

		public virtual Expression<Func<TResult>> BuildSummaryExpression<TResult>()
		{
			throw new Exception("This type not support summary expression");
		}
	}
}
