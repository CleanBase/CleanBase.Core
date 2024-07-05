using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Models.PDF
{
	public class PDFReportModel
	{
		public string Title { get; set; }  // Title of the PDF report
		public DateTime DateGenerated { get; set; }  // Date when the report was generated
		public List<ReportSection> Sections { get; set; }  // Sections/content of the report

		public PDFReportModel()
		{
			Sections = new List<ReportSection>();
		}
	}

	public class ReportSection
	{
		public string SectionTitle { get; set; }  // Title of the report section
		public string Content { get; set; }  // Content/text of the report section
	}
}
