using CleanBase.Core.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Base
{
	public interface IKeyVaultService
	{
		Task<AppSettings> GetConfig();
	}
}
