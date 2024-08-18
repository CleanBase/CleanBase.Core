using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Extensions
{
	public static class InterpolatedStringHandlerExtensions
	{
		public static string BuildMessage(this DefaultInterpolatedStringHandler handler, params object[] parts)
		{
			foreach (var part in parts)
			{
				if (part is string literal)
				{
					handler.AppendLiteral(literal);
				}
				else
				{
					handler.AppendFormatted(part);
				}
			}

			return handler.ToStringAndClear();
		}
	}
}
