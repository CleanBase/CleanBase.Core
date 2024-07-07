using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Extensions
{
	public static class DictionaryExtension
	{
		public static dynamic ToAnonymous<TKey, TValue>(this IDictionary<TKey, TValue> dict)
		{
			dynamic anonymous = (object)new ExpandoObject();
			IDictionary<string, object> dictionary = (IDictionary<string, object>)anonymous;
			foreach (KeyValuePair<TKey, TValue> keyValuePair in (IEnumerable<KeyValuePair<TKey, TValue>>)dict)
			{
				string key = keyValuePair.Key.ToString();
				dictionary[key] = keyValuePair.Value;
			}
			return anonymous;
		}
	}
}
