using CleanBase.Core.Domain.Exceptions;
using System.Collections.Generic;

namespace CleanBase.Core.ViewModels.Response
{
	/// <summary>
	/// Represents a response indicating a failed action with detailed error information.
	/// </summary>
	public class FailActionResponse : ActionResponse
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FailActionResponse"/> class with a failure message.
		/// </summary>
		/// <param name="message">The failure message.</param>
		public FailActionResponse(string message)
			: base(false, message, null, null)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FailActionResponse"/> class with a failure message, error code, and error details.
		/// </summary>
		/// <param name="message">The failure message.</param>
		/// <param name="errorCode">The error code associated with the failure.</param>
		/// <param name="errors">Detailed error information.</param>
		public FailActionResponse(string message, string errorCode, IEnumerable<ErrorCodeDetail> errors)
			: base(false, message, errorCode, errors)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FailActionResponse"/> class with a failure message and error details.
		/// </summary>
		/// <param name="message">The failure message.</param>
		/// <param name="errors">Detailed error information.</param>
		public FailActionResponse(string message, IEnumerable<ErrorCodeDetail> errors)
			: base(false, message, string.Empty, errors)
		{
		}
	}
}
