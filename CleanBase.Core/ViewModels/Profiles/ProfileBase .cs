using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.ViewModels.Profiles
{
	/// <summary>
	/// Base class for all AutoMapper profile configurations.
	/// Provides a mechanism to add default and custom mappings.
	/// </summary>
	public abstract class ProfileBase : Profile
	{
		/// <summary>
		/// Initializes an instance of <see cref="ProfileBase"/> and performs default and custom mappings.
		/// </summary>
		protected ProfileBase()
		{
			ConfigureMappings();
		}

		/// <summary>
		/// Configures mappings by calling default and custom mapping methods.
		/// </summary>
		private void ConfigureMappings()
		{
			DefaultMapping();
			CustomMapping();
		}

		/// <summary>
		/// Method for configuring default mappings. 
		/// Can be overridden in derived classes to set up default mappings.
		/// </summary>
		protected virtual void DefaultMapping()
		{
			// Default mappings can be configured here.
			// Example: CreateMap<Source, Destination>();
		}

		/// <summary>
		/// Method for configuring custom mappings.
		/// Can be overridden in derived classes to set up custom mappings.
		/// </summary>
		protected virtual void CustomMapping()
		{
			// Custom mappings can be configured here.
		}
	}
}
