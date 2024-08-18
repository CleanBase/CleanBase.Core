using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.ViewModels.Request.Base
{
	public class EntityRequestBase
	{
		public Guid? Id { get; set; }

		public string? Name { get; set; }
	}
}
