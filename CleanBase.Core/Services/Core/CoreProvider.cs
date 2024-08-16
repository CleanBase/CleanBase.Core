using AutoMapper;
using CleanBase.Core.Data.Policies.Base;
using CleanBase.Core.Services.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core
{
	public class CoreProvider : ICoreProvider
	{
		public ISmartLogger Logger { get ; set ; }
		public IMapper Mapper { get ; set ; }
		public IServiceProvider ServiceProvider { get ; set ; }
		public IIdentityProvider IdentityProvider { get ; set ; }
		public IPolicyFactory PolicyFactory { get ; set ; }
		public CoreProvider(
			ISmartLogger logger,
			IMapper mapper,
			IIdentityProvider identityProvider,
			IServiceProvider serviceProvider,
			IPolicyFactory policyFactory)
		{
			this.Logger = logger;
			this.Mapper = mapper;
			this.IdentityProvider = identityProvider;
			this.ServiceProvider = serviceProvider;
			this.PolicyFactory = policyFactory;
		}
	}
}
