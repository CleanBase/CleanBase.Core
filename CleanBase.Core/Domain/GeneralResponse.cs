using CleanBase.Core.Domain.Generic;

namespace CleanBase.Core.Domain
{
	public class GeneralResponse : GeneralResponseOfT<object>
	{
		public GeneralResponse(object result, string message) 
			: base(result, message)
		{ 
		}
	}
}
