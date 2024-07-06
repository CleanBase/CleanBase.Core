using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Generic
{
	public class EntityActiveOfT<TKey> : EntityCoreKeyOfT<TKey>, IEntityActive
	{
		public bool IsDeleted { get; set; }

		public EntityActiveOfT() => this.IsDeleted = false;
	}
}
