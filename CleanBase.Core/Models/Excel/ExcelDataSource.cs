using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Models.Excel
{
	public class ExcelDataSource
	{
		public string DateFormat { get; set; } = "yyyy-MM-dd";

		public List<ExcelSheet> Sheets { get; set; } = new List<ExcelSheet>();
	}
}
