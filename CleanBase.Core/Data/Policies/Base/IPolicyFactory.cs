using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Base
{
	public interface IPolicyFactory
	{
		IEnumerable<IDataPolicy> CreateCorePolicy(Type entityType, )
	}
}
