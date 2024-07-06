using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanBase.Core.Data.Repositories;
using System.Threading.Tasks;
using CleanBase.Core.Entities.Base;
using CleanBase.Core.Data.Policies.Base;
using System.Linq.Expressions;

namespace CleanBase.Core.Data.Repositories
{
	public abstract class RepositoryOfT<T> : IRepositoryOfT<T> where T : class, IEntityCore
	{
		private List<IDataPolicy> _policies = new List<IDataPolicy>();

		private IReadOnlyList<IDataPolicy> _empty = (IReadOnlyList<IDataPolicy>)new List<IDataPolicy>().AsReadOnly();

		protected bool IsDisablePolicies { get; set; }

		protected IReadOnlyList<IDataPolicy> Policies
		{
			get
			{
				return this.IsDisablePolicies ? this._empty : (IReadOnlyList<IDataPolicy>)this._policies.AsReadOnly();
			}
		}

		public Type EntityType { get; set; } = typeof(T);

		public abstract T Add(T entity, bool saveChanges = false);

		public abstract Task<T> AddAsync(T entity, bool saveChanges = false);

		public object Add(object entity, bool saveChanges = false)
		{
			return (object)this.Add(entity as T, saveChanges);
		}

		public abstract bool Delete(T entity, bool saveChanges = false);

		public abstract bool HardDelete(T entity, bool saveChanges = false);

		public bool Delete(object entity, bool saveChanges = false)
		{
			return this.Delete(entity as T, saveChanges);
		}

		public abstract T Update(T entity, bool saveChanges = false);

		public object Update(object entity, bool saveChanges = false)
		{
			return (object)this.Update(entity as T, saveChanges);
		}

		public abstract T Find(params object[] keys);

		public abstract Task<T> FindAsync(params object[] keys);

		public abstract IQueryable<T> GetAll(bool ignoreGlobalFilter = false);

		public abstract Task<IQueryable<T>> GetAllAsync(bool ignoreGlobalFilter = false);

		public abstract IQueryable<T> GetAllInActive();

		public abstract Task<IQueryable<T>> GetAllInActiveAsync();

		public abstract T FindInActive(params object[] keys);

		public abstract Task<T> FindInActiveAsync(params object[] keys);

		public abstract IQueryable<T> Where(Expression<Func<T, bool>> predicate);

		public abstract Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);

		public abstract bool Delete(params object[] keys);

		public abstract bool HardDelete(params object[] keys);

		public void AddPolicies(params IDataPolicy[] policy)
		{
			this._policies.AddRange((IEnumerable<IDataPolicy>)policy);
		}

		public void EnableDisablePolicies(bool isEnable) => this.IsDisablePolicies = !isEnable;

		public abstract void BatchAdd(IEnumerable<T> entities, bool saveChanges = false);

		public abstract void BulkAdd(IEnumerable<T> entities, bool saveChanges = false);

		public abstract Task BatchAddAsync(IEnumerable<T> entities, bool saveChanges = false);

		public abstract Task BulkAddAsync(IEnumerable<T> entities, bool saveChanges = false);

		public abstract void BatchUpdate(IEnumerable<T> entities, bool saveChanges = false);

		public abstract void BulkUpdate(IEnumerable<T> entities, bool saveChanges = false);

		public abstract Task BulkUpdateAsync(IEnumerable<T> entities, bool saveChanges = false);

		public abstract void BatchDelete(IEnumerable<T> enties, bool saveChanges = false);

		public abstract void BulkDelete(IEnumerable<T> enties, bool saveChanges = false);

		public abstract void BatchDelete(IEnumerable<string> keys, bool saveChanges = false);

		public abstract void BulkDelete(IEnumerable<string> keys, bool saveChanges = false);
	}
}
