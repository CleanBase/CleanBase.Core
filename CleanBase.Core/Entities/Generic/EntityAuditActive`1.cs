using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Generic
{
	public class EntityAuditActive<TKey> :
		EntityAudit<TKey>,
		IEntityAuditActive<TKey>
	{
		public bool IsDeleted { get; set; }

		public EntityAuditActive() => this.IsDeleted = false;

		public override void MarkDeleted() => this.IsDeleted = true;
	}
}
