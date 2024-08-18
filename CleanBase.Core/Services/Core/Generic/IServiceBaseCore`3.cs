using CleanBase.Core.Domain.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Core.Generic
{
	public interface IServiceBaseCore<T, TRequest, TGetAllRequest>
		where T : class
	{
		IQueryable<T> GetAll(TGetAllRequest request);

		IQueryable<T> GetAll(TGetAllRequest request, int pageSizeMax);

		Task<ListResult<T>> ListAsync(TGetAllRequest request);

		Task<T?> GetByIdAsync(params object[] id);

		Task<T> SaveAsync(T entity);

		Task<T> SaveAsync(TRequest entity);

		Task<bool> SoftDeleteAsync(Guid id);

		Task<bool> HardDeleteAsync(Guid id);

		Task UpsertAsync<T2, TKey>(
			IEnumerable<T2> source,
			Func<T2, TKey> keySelector,
			Func<T, TKey> sourceKeySelector,
			Func<IQueryable<T>, List<TKey>, IQueryable<T>> existingPredicate,
			Action<T2, T>? addTransform = null,
			Action<T2, T>? updateTransform = null,
			bool allowAdd = true,
			bool allowUpdate = true,
			bool allowDelete = false)
			where T2 : class;

		Task UpsertBatchAsync<T2, TKey>(
			IEnumerable<T2> source,
			Func<T2, TKey> keySelector,
			Func<T, TKey> sourceKeySelector,
			Func<IQueryable<T>, List<TKey>, IQueryable<T>> existingPredicate,
			Action<T2, T>? addTransform = null,
			Action<T2, T>? updateTransform = null,
			bool allowAdd = true,
			bool allowUpdate = true,
			bool allowDelete = false)
			where T2 : class;
	}
}

