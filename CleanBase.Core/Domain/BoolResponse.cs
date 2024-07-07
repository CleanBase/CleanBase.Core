using CleanBase.Core.Domain.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Domain
{
	public class BoolResponse : GeneralResponseOfT<bool>
	{
		public BoolResponse(bool value, string message ="")
			: base(value,message)
		{
		}
	}
}
