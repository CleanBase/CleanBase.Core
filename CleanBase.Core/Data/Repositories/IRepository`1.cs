using CleanBase.Core.Data.Policies.Base;
using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Repositories
{
	public interface IRepository <T>: IRepository where T : class, IEntityCore
	{

		IQueryable<T> GetAll(bool ignoreGlobalFilter = false);

		Task<IQueryable<T>> GetAllAsync(bool ignoreGlobalFilter = false);

		IQueryable<T> GetAllInActive();

		Task<IQueryable<T>> GetAllInActiveAsync();

		IQueryable<T> Where(Expression<Func<T, bool>> predicate);

		T Add(T entity, bool saveChanges = false);

		void BatchAdd(IEnumerable<T> entities, bool saveChanges = false);

		void BulkAdd(IEnumerable<T> entities, bool saveChanges = false);

		Task<T> AddAsync(T entity, bool saveChanges = false);

		Task BatchAddAsync(IEnumerable<T> entities, bool saveChanges = false);

		Task BulkAddAsync(IEnumerable<T> entities, bool saveChanges = false);

		T Update(T entity, bool saveChanges = false);
		Task<T> UpdateAsync(T entity, bool saveChanges = false);

		void BatchUpdate(IEnumerable<T> entities, bool saveChanges = false);
		Task BatchUpdateAsync(IEnumerable<T> entities, bool saveChanges = false);


		void BulkUpdate(IEnumerable<T> entities, bool saveChanges = false);

		Task BulkUpdateAsync(IEnumerable<T> entities, bool saveChanges = false);

		bool Delete(T entity, bool saveChanges = false);

		bool HardDelete(T entity, bool saveChanges = false);
		Task<bool> DeleteAsync(T entity, bool saveChanges = false);
		Task<bool> HardDeleteAsync(T entity, bool saveChanges = false);
		void BatchDelete(IEnumerable<T> enties, bool saveChanges = false);

		void BulkDelete(IEnumerable<T> enties, bool saveChanges = false);

		void BatchDelete(IEnumerable<string> keys, bool saveChanges = false);

		void BulkDelete(IEnumerable<string> keys, bool saveChanges = false);

		bool Delete(params object[] keys);

		bool HardDelete(params object[] keys);
		Task<bool> DeleteAsync(params object[] keys);
		Task<bool> HardDeleteAsync(params object[] keys);

		T Find(params object[] keys);

		Task<T> FindAsync(params object[] keys);

		T FindInActive(params object[] keys);

		Task<T> FindInActiveAsync(params object[] keys);

		Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

		void AddPolicies(params IDataPolicy[] policy);

		void EnableDisablePolicies(bool isEnable);
	}
}
