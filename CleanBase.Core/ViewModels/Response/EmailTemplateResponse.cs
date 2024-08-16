using CleanBase.Core.ViewModels.Response.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.ViewModels.Response
{
	public class EmailTemplateResponse : EntityAuditNameResponseBase
	{
		public string ExternalTemplateId { get; set; }

		public string Html { get; set; }

		public string Subject { get; set; }

		public string From { get; set; }

		public string FromName { get; set; }

		public string To { get; set; }

		public string Cc { get; set; }

		public string Bcc { get; set; }

		public string HtmlBody { get; set; }

		public string TextBody { get; set; }

		public bool SendAsHtml { get; set; }
	}
}
