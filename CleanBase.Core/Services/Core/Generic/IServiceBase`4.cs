using CleanBase.Core.Entities;
using CleanBase.Core.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Generic
{
	/// <summary>
	/// Defines the base service interface with common operations for entities.
	/// </summary>
	/// <typeparam name="T">The type of the entity.</typeparam>
	/// <typeparam name="TRequest">The type of the request for create and update operations.</typeparam>
	/// <typeparam name="TResponse">The type of the response returned by the service.</typeparam>
	/// <typeparam name="TGetAllRequest">The type of the request used for querying entities.</typeparam>
	public interface IServiceBase<T, TRequest, TResponse, TGetAllRequest> :
		IServiceBase<T, TRequest, TResponse, TGetAllRequest, EntityBaseName>
		where T : class, IEntityKey, new()
		where TGetAllRequest : GetAllRequest
	{
	}
}
