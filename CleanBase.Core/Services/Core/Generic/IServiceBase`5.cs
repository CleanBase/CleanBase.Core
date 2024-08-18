using CleanBase.Core.Entities;
using CleanBase.Core.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Generic
{
	public interface IServiceBase<T, TRequest, TResponse, TGetAllRequest, TSummary> :
		IServiceBaseCore<T, TRequest, TGetAllRequest>
		where T : class, IEntityKey, new()
		where TGetAllRequest : GetAllRequest
		where TSummary : class, IEntityKey, new()
	{
		IQueryable<TSummary> GetAllSummary(TGetAllRequest request);
	}
}
