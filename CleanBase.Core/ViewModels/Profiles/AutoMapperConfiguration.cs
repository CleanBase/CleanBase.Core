using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.ViewModels.Profiles
{
	public abstract class AutoMapperConfiguration
	{
		/// <summary>
		/// Registers AutoMapper configurations and returns an IMapper instance.
		/// </summary>
		/// <returns>An instance of IMapper configured with the profiles.</returns>
		public IMapper RegisterAutoMapper() =>
			new MapperConfiguration(cfg => ConfigureProfiles(cfg)).CreateMapper();

		/// <summary>
		/// Configures AutoMapper profiles.
		/// </summary>
		/// <param name="cfg">The IMapperConfigurationExpression instance.</param>
		private void ConfigureProfiles(IMapperConfigurationExpression cfg) =>
			GetProfiles(cfg)
				.Concat(GetGeneratedProfiles(cfg))
				.ToList()  // Ensure profiles are materialized
				.ForEach(profile => cfg.AddProfile(profile));

		/// <summary>
		/// Gets the profiles to be registered with AutoMapper.
		/// </summary>
		/// <param name="cfg">The IMapperConfigurationExpression instance.</param>
		/// <returns>A collection of profiles.</returns>
		protected abstract IEnumerable<Profile> GetProfiles(IMapperConfigurationExpression cfg);

		/// <summary>
		/// Gets additional profiles generated dynamically.
		/// </summary>
		/// <param name="cfg">The IMapperConfigurationExpression instance.</param>
		/// <returns>A collection of additional profiles.</returns>
		protected virtual IEnumerable<Profile> GetGeneratedProfiles(IMapperConfigurationExpression cfg) =>
			Enumerable.Empty<Profile>();
	}
}
