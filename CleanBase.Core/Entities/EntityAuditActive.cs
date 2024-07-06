using CleanBase.Core.Entities.Base;
using CleanBase.Core.Entities.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities
{
	public class EntityAuditActive :
	    EntityAuditActiveOfT<string>,
		IEntityAudit,
		IEntityAuditActive,
		IEntityActiveKey
	{
	}
}
