using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Helpers
{
	public static class InterpolatedStringBuilder
	{
		public static string BuildInterpolatedString(int baseLength, int formattedCount, Action<DefaultInterpolatedStringHandler> action)
		{
			var handler = new DefaultInterpolatedStringHandler(baseLength, formattedCount);
			action(handler);
			return handler.ToStringAndClear();
		}
	}

}
