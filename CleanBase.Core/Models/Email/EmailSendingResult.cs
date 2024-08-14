using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Models.Email
{
	public class EmailSendingResult
	{
		public bool IsSuccess { get; set; }	
		public string Content { get; set; }
	}
}
