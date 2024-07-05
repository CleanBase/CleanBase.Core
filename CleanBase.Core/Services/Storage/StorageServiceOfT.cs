using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Storage
{
	public class StorageServiceOfT<T> : IStorageServiceOfT<T> where T : IStorageProvider
	{
		public T Service { get; set; }

		public StorageServiceOfT(T service) => this.Service = service;
	}
}
