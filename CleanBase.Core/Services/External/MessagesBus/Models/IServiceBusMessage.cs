using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.External.MessagesBus.Models
{
	public interface IServiceBusMessage
	{
		string Type { get; set; }

		string ServiceDomain { get; set; }
	}
}
