using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities
{
	public class EntityBaseName : 
		EntityCoreKey,
		IEntityKeyName
	{
		[System.ComponentModel.DataAnnotations.MaxLength(255)]
		public string? Name { get; set; }
	}
}
