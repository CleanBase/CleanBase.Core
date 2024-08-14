using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Extensions
{
	public static class StringExtension
	{
		public static string AppendJson(this string str, object data, string combine= ":")
		{
			return str + combine + " " + JsonConvert.SerializeObject(data);
		}

		public static string AppendJson(this string str, object data1, object data2, string combine= ":")
		{
			DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(2,4);
			interpolatedStringHandler.AppendFormatted(str);
			interpolatedStringHandler.AppendFormatted(combine);
			interpolatedStringHandler.AppendLiteral(" ");
			interpolatedStringHandler.AppendFormatted(JsonConvert.SerializeObject(data1));
			interpolatedStringHandler.AppendLiteral(" ");
			interpolatedStringHandler.AppendFormatted(JsonConvert.SerializeObject(data2));

			return interpolatedStringHandler.ToStringAndClear();
		}

		public static string PathCombine(this string src, params string[] dest)
		{
			List<string> list = ((IEnumerable<string>) dest).ToList<string>();
			list.Insert(0, src);
			return Path.Combine(list.ToArray());
		}
	}
}
