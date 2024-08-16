using CleanBase.Core.Entities;
using CleanBase.Core.Services.Core.Generic;
using CleanBase.Core.ViewModels.Request;
using CleanBase.Core.ViewModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Base
{
	public interface IEmailTemplateService :
		IServiceBaseOfT4<EmailTemplate, EmailTemplateRequest, EmailTemplateResponse, EmailTemplateGetAllRequest>
	{
	}
}
