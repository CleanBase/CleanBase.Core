using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Generic
{
	public class EntityActive<TKey> : EntityCoreKey<TKey>, IEntityActive
	{
		public bool IsDeleted { get; set; }

		public EntityActive() => this.IsDeleted = false;
	}
}
