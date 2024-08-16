using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Base
{
	public interface ICacheManagerProvider
	{
		string BuildKey(params string[] keys);

		Task<T> GetOrCreateAsync<T>(Func<Task<T>> func, params string[] keys);

		bool TryGetValue(object key, out object value);

		object Get(object key);

		TItem Get<TItem>(object key);

		object Set(object value, params string[] keys);

		T Set<T>(T value, params string[] keys);
	}
}
