using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Helpers
{
	public static class DateTimeHelper
	{
		public static DateTime ConvertToVNTime(this DateTime dt) => dt.AddHours(7.0);

		public static DateTime VnNow() => DateTime.UtcNow.ConvertToVNTime();
	}
}
