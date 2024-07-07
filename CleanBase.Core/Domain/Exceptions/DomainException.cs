using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Domain.Exceptions
{
	public class DomainException : Exception
	{
		public int HttpCode { get; set; }

		public string ErrorCode { get; set; }

		public IEnumerable<ErrorCodeDetail> ErrorDetails { get; set; }

		public DomainException(
			string message,
			string errorCode="",
			Exception innerException = null,
			int httpCode = 500,
			IEnumerable<ErrorCodeDetail> details = null)
			: base(message,innerException)
		{
			this.HttpCode = httpCode;	
			this.ErrorCode = errorCode;
			this.ErrorDetails = details;
		}
	}
}
