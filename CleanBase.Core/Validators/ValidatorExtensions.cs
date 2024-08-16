using CleanBase.Core.Validators.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Validators
{
	public static class ValidatorExtensions
	{
		/// <summary>
		/// Validates an instance and returns a boolean result.
		/// </summary>
		/// <typeparam name="T">The type of object to validate.</typeparam>
		/// <param name="validator">The validator instance.</param>
		/// <param name="instance">The object to validate.</param>
		/// <returns>True if validation is successful, otherwise false.</returns>
		public static bool ValidateAndReturnBool<T>(this IValidatorOfT<T> validator, T instance)
		{
			var result = validator.Validate(instance);
			return result.IsValid;
		}
	}
}
