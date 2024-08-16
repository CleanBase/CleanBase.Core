using CleanBase.Core.Entities.Base;
using CleanBase.Core.ViewModels.Request.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.ViewModels.Request
{
	public class EmailTemplateRequest : EntityRequestBase, IKeyObject
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

		public bool SendAsHtml { get; set; } = true;
	}
}
