using AutoMapper;
using CleanBase.Core.Data.Policies.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Base
{
	public interface ICoreProvider
	{
		ISmartLogger Logger { get; set; }

		IMapper Mapper { get; set; }

		IServiceProvider ServiceProvider { get; set; }

		IIdentityProvider IdentityProvider { get; set; }

		IDataPolicy PolicyFactory { get; set; }
	}
}
