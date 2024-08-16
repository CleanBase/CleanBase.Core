using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.External.MessagesBus
{
	public interface IServiceBrokerConfigProvider
	{
		string ConnectionString { get; set; }

		IDictionary<Type, string> QueueNames { get; set; }
	}
}
