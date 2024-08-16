using CleanBase.Core.Validators.Base;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Validators.Generic
{
	/// <summary>
	/// Interface for type-specific validators.
	/// </summary>
	/// <typeparam name="T">The type of object to validate.</typeparam>
	public interface IValidatorOfT<T> : IValidatorBase
	{
		/// <summary>
		/// Validates an object of type T.
		/// </summary>
		/// <param name="instance">The object of type T to validate.</param>
		/// <returns>Validation result.</returns>
		ValidationResult Validate(T instance);
	}
}
