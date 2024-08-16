using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities
{
	public class EmailTemplate : EntityNameAuditActive
	{
		[MaxLength(256)]
		public string? Code { get; set; }

		[MaxLength(256)]
		public string? ExternalTemplateId { get; set; }

		[MaxLength(256)]
		public string? From { get; set; }

		[MaxLength(256)]
		public string? FromName { get; set; }

		public string? To { get; set; }

		public string? Cc { get; set; }

		public string? Bcc { get; set; }

		public string? HtmlBody { get; set; }

		public string? TextBody { get; set; }

		[MaxLength(256)]
		public string? Subject { get; set; }

		public bool SendAsHtml { get; set; }

		public string? Language { get; set; }
	}
}
