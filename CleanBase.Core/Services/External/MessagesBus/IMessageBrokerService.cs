using CleanBase.Core.Services.External.MessagesBus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.External.MessagesBus
{
	public interface IMessageBrokerService
	{
		Task SendMessageAsync<T>(T obj) where T : IServiceBusMessage;
	}
}
