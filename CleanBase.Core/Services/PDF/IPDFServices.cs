using CleanBase.Core.Models.PDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.PDF
{
	public interface IPDFServices
	{
		// Convert PDF using specified model
		Task<MemoryStream> Convert(PDFConvertingModel model);

		// Convert PDF to Base64 string using specified model
		Task<string> ConvertAsBase64(PDFConvertingModel model);

		// Generate PDF report asynchronously
		Task<MemoryStream> GenerateReportAsync(PDFReportModel model);

		// Merge multiple PDF documents into one
		Task<MemoryStream> MergePdfDocumentsAsync(params MemoryStream[] pdfDocuments);

		// Extract text from PDF document
		Task<string> ExtractTextAsync(MemoryStream pdfDocument);
	}
}
