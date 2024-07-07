using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities
{
	public class EntityNameAuditActive :
		EntityAuditActive,
		IEntityKeyName
	{
		[MaxLength(255)]
		public string? Name { get; set; }
	}
}
