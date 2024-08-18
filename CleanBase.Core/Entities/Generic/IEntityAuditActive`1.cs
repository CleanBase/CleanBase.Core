using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Generic
{
	public interface IEntityAuditActive <TKey> :
		IEntityAudit<TKey>,
		IEntityActiveKey<TKey>
	{
	}
}
