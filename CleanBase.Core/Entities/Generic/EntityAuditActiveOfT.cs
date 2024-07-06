using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Generic
{
	public class EntityAuditActiveOfT<TKey> :
		EntityAuditOfT<TKey>,
		IEntityAuditActiveOfT<TKey>
	{
		public bool IsDeleted { get; set; }

		public EntityAuditActiveOfT() => this.IsDeleted = false;

		public override void MarkDeleted() => this.IsDeleted = true;
	}
}
