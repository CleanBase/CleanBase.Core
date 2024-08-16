using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Generic
{
	public class EntityAuditOfT<TKey> :
		EntityCoreKeyOfT<TKey>,
		IEntityAuditOfT<TKey>
	{
		[MaxLength(36)]
		public TKey? CreatedBy { get; set; }

		[MaxLength(36)]
		public TKey? UpdatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }

		public EntityAuditOfT()
		{
			this.CreatedDate = DateTime.UtcNow;
			this.UpdatedDate = DateTime.UtcNow;
		}
	}
}
