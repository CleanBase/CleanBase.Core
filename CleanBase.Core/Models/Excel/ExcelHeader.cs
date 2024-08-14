using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Models.Excel
{
	public class ExcelHeader
	{
		public string Name { get; set; }

		public string Property { get; set; }

		public string Format { get; set; }

		public int? Width { get; set; }

		public bool IsWrapText { get; set; }

		public Func<object, object> ActionTransform { get; set; }

		public Action<object, object> CellTransform { get; set; }
	}
}
