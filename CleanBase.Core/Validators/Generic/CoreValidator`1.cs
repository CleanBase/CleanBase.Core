using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;

namespace CleanBase.Core.Validators.Generic
{
	public class CoreValidator<T> : AbstractValidator<T>, IValidator<T>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="CoreValidator{T}"/> class.
		/// </summary>
		protected CoreValidator()
		{
			ApplyDefaultRules();
			ApplyCustomRules();
		}

		/// <summary>
		/// Applies default validation rules.
		/// </summary>
		protected virtual void ApplyDefaultRules()
		{
			// Define default rules here
		}

		/// <summary>
		/// Applies custom validation rules.
		/// </summary>
		protected virtual void ApplyCustomRules()
		{
			// Define custom rules here
		}

		/// <summary>
		/// Validates an object of type T.
		/// </summary>
		/// <param name="instance">The object of type T to validate.</param>
		/// <returns>Validation result.</returns>
		public ValidationResult Validate(T instance)
		{
			return base.Validate(instance);
		}

		/// <summary>
		/// Validates an object of type <see cref="object"/>.
		/// </summary>
		/// <param name="instance">The object to validate.</param>
		/// <returns>Validation result.</returns>
		public ValidationResult Validate(object instance)
		{
			if (instance is T typedInstance)
			{
				return Validate(typedInstance);
			}

			// Handle the case where the instance is not of type T
			throw new ArgumentException($"Instance must be of type {typeof(T).FullName}", nameof(instance));
		}
	}
}

