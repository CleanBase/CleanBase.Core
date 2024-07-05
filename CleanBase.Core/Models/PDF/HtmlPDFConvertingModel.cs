using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Models.PDF
{
	public class HtmlPDFConvertingModel : PDFConvertingModel
	{
		public string Html { get; set; }

		public object Data { get; set; }

		public string Path { get; set; }
	}
}
