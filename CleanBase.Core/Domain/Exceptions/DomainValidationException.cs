using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Domain.Exceptions
{
	public class DomainValidationException : DomainException
	{
		public DomainValidationException(
			string message,
			string errorCode = "",
			Exception innerException = null,
			int httpCode = 400,
			IEnumerable<ErrorCodeDetail> details = null)
			: base(message,errorCode, innerException, httpCode, details)
		{
		}
	}
}
