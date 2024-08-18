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
		public static string BuildMessage(this DefaultInterpolatedStringHandler handler, string literal, params object[] args)
		{
			handler.AppendLiteral(literal);
			foreach (var arg in args)
			{
				handler.AppendFormatted(arg);
			}
			return handler.ToStringAndClear();
		}
	}
}
