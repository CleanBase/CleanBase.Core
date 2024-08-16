using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.ViewModels.Request
{
	public class GetAllRequest
	{
		public string? Filter { get; set; }

		public int? Skip { get; set; }

		public int? PageIndex { get; set; }

		public int PageSize { get; set; }

		public string? SortField { get; set; }

		public bool? Asc { get; set; }
	}
}
