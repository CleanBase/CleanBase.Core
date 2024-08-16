using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.ViewModels.Response.Base
{
	public class EntityAuditResponseBase : EntityResponseBase
	{
		public string CreatedBy { get; set; }

		public string UpdatedBy { get; set; }

		public DateTime CreatedDate { get; set; }

		public DateTime UpdatedDate { get; set; }
	}
}
