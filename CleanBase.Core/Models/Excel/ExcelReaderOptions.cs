using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Models.Excel
{
	public class ExcelReaderOptions
	{
		public List<string> Headers = new List<string>();

		public List<ExcelReaderOptions.ExcelReaderColumnOptions> ColumnOptions { get; set; } = new List<ExcelReaderOptions.ExcelReaderColumnOptions>();

		public Dictionary<string, ExcelReaderOptions.ExcelReaderColumnOptions> DictColumnOptions
		{
			get
			{
				return this.ColumnOptions.ToDictionary<ExcelReaderOptions.ExcelReaderColumnOptions, string, ExcelReaderOptions.ExcelReaderColumnOptions>((Func<ExcelReaderOptions.ExcelReaderColumnOptions, string>)(x => x.Property.ToLower()), (Func<ExcelReaderOptions.ExcelReaderColumnOptions, ExcelReaderOptions.ExcelReaderColumnOptions>)(x => x));
			}
		}

		public int SheetIndex { get; set; }

		public int RowHeaderIndex { get; set; }

		public int StartRow { get; set; } = 2;

		public int EndRow { get; set; } = int.MaxValue;

		public int StartCol { get; set; }

		public int EndCol { get; set; } = int.MaxValue;

		public int BatchSize { get; set; } = 500;

		public bool ParseExtracType { get; set; }

		public class ExcelReaderColumnOptions
		{
			public string Property { get; set; }

			public int Index { get; set; }

			public Func<object, object> Transform { get; set; }

			public string Format { get; set; }

			public Type Type { get; set; }
		}
	}
}
}
