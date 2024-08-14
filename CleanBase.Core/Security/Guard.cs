using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Security
{
	public static class Guard
	{
		public static void ThrowIfFalse(bool value, string message = "Object is false", string errorCode = "", int httpCode = 500)
		{
			if (!value)
			{

			}
		}
	}
}
