using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Generic
{
	public class EntityCoreActive<TKey> : 
		EntityCoreKey<TKey>,
		IEntityKey<TKey>,
		IEntityActive
	{
		public bool IsDeleted { get; set; }
		public override void MarkDeleted() => this.IsDeleted = true;
	}
}
