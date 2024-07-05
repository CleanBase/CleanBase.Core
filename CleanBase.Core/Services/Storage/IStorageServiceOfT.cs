using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Storage
{
	public interface IStorageServiceOfT <T> where T : IStorageProvider
	{
		T Service { get; set; }	
	}
}
