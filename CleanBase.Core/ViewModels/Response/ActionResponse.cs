using CleanBase.Core.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.ViewModels.Response
{
    /// <summary>
    /// Represents the result of an action with success status, message, and error details.
    /// </summary>
    public class ActionResponse
    {
        /// <summary>
        /// Indicates whether the action was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Provides a message related to the action result.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Contains an error code if the action was not successful.
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Provides detailed error information if the action was not successful.
        /// </summary>
        public IEnumerable<ErrorCodeDetail> ErrorDetails { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionResponse"/> class with specified values.
        /// </summary>
        /// <param name="success">Indicates whether the action was successful.</param>
        /// <param name="message">Provides a message related to the action result.</param>
        /// <param name="errorCode">Contains an error code if the action was not successful.</param>
        /// <param name="errorDetails">Provides detailed error information if the action was not successful.</param>
        public ActionResponse(bool success, string message, string errorCode, IEnumerable<ErrorCodeDetail> errorDetails)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            ErrorDetails = errorDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionResponse"/> class with success set to true.
        /// </summary>
        public ActionResponse() => Success = true;
    }
}
