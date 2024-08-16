using CleanBase.Core.Models.Excel;
using CleanBase.Core.Services.Batchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Base
{
	public interface IExcelHelper
	{
		BatchOperationOfT<T> ReadFileAsBatch<T>(Stream stream, ExcelReaderOptions excelReaderOptions);

		BatchOperationOfT<T> ReadCsvFileAsBatch<T>(Stream stream, ExcelReaderOptions excelReaderOptions);

		Task<Stream> Export(ExcelDataSource dataSource);

		Task Export(string path, ExcelDataSource dataSource);

		void SetLink(object cell, string link);
	}
}
