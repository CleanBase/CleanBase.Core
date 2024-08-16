using CleanBase.Core.Entities;
using CleanBase.Core.ViewModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.ViewModels.Profiles
{
	/// <summary>
	/// AutoMapper profile for configuring mappings related to EmailTemplate entities and view models.
	/// </summary>
	public abstract class EmailTemplateBaseProfile : ProfileBase
	{
		/// <summary>
		/// Configures default mappings for EmailTemplate-related entities and view models.
		/// </summary>
		protected override void DefaultMapping()
		{
			CreateMap<EmailTemplate, EmailTemplate>();
			CreateMap<EmailTemplateRequest, EmailTemplate>();
			CreateMap<EmailTemplate, EmailTemplateResponse>();
		}
	}
}
