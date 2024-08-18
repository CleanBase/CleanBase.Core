using CleanBase.Core.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.ViewModels.Response.Generic
{
    /// <summary>
    /// Represents a response with a result of type <typeparamref name="T"/> indicating the success or failure of an action.
    /// </summary>
    /// <typeparam name="T">The type of the result returned in the response.</typeparam>
    public class ActionResponse<T> : ActionResponse
	{
		/// <summary>
		/// Gets or sets the result of the action.
		/// </summary>
		public T Result { get; set; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ActionResponse{T}"/> class with a successful response.
		/// </summary>
		public ActionResponse()
			: base(true, string.Empty, null, null)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ActionResponse{T}"/> class with the specified result.
		/// </summary>
		/// <param name="result">The result of the action.</param>
		public ActionResponse(T result)
			: this()
		{
			Result = result;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ActionResponse{T}"/> class with the specified result and success status.
		/// </summary>
		/// <param name="result">The result of the action.</param>
		/// <param name="success">Indicates whether the action was successful.</param>
		public ActionResponse(T result, bool success)
			: base(success, string.Empty, null, null)
		{
			Result = result;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ActionResponse{T}"/> class with the specified result, success status, message, error code, and error details.
		/// </summary>
		/// <param name="result">The result of the action.</param>
		/// <param name="success">Indicates whether the action was successful.</param>
		/// <param name="message">A message related to the action response.</param>
		/// <param name="errorCode">An optional error code related to the action response.</param>
		/// <param name="errorDetails">Optional detailed error information.</param>
		public ActionResponse(T result, bool success, string message, string? errorCode, IEnumerable<ErrorCodeDetail>? errorDetails)
			: base(success, message, errorCode, errorDetails)
		{
			Result = result;
		}
	}
}
