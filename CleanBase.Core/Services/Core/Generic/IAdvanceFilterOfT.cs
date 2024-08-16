using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Generic
{
	public interface IAdvanceFilterOfT<T>
	{
		Expression<Func<T, bool>> AdvanceFilterExpression(string filter);
	}
}
