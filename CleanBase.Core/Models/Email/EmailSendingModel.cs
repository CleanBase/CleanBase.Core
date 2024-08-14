using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Models.Email
{
	public class EmailSendingModel
	{
		public string Subject { get; set; }	
		public string From { get; set; }
		public string FromName { get; set; }
		public List<string> To { get; set; }
		public List<string> Cc { get; set; }

		public List<string> Bcc { get; set; }
		public string ExternalTempalteId { get; set; }
		public bool SendAsHtml { get; set; }
		public string HtmlBody { get; set; }
		public string TextBody { get; set; }
		public object Data { get; set; }
		public string TransactionId { get; set; } = Guid.NewGuid().ToString();
	}
}
