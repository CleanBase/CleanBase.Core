using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Validators.Base
{
	/// <summary>
	/// Base interface for all validators.
	/// </summary>
	public interface IValidatorBase
	{
		/// <summary>
		/// Validates the specified object and returns a <see cref="ValidationResult"/>.
		/// </summary>
		/// <param name="instance">The object to validate.</param>
		/// <returns>A <see cref="ValidationResult"/> that contains the validation results.</returns>
		ValidationResult Validate(object instance);
	}
}
