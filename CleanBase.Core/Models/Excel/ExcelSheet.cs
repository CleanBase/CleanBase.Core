using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Models.Excel
{
	public class ExcelSheet
	{
		public string Name { get; set; }

		public List<ExcelHeader> Headers { get; set; } = new List<ExcelHeader>();

		public IEnumerable<object> Data { get; set; }
	}
}
