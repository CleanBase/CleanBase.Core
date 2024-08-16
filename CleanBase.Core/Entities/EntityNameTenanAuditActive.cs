using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities
{
	public class EntityNameTenanAuditActive :
		EntityNameAuditActive,
		ITenanEntity
	{
		[MaxLength(36)]
		public string? TenantId { get; set; }
	}
}
