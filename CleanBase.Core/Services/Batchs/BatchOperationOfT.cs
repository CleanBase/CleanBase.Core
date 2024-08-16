using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Batchs
{
	public class BatchOperationOfT<T> : IDisposable
	{
		private static int DEFAULT_BATCH_SIZE = 100000;
		private Func<int, int, Task<IEnumerable<T>>> _actionAsync;
		private Func<int, int, IEnumerable<T>> _action;
		private bool _disposedValue;

		private Action<IEnumerable<T>> _operation { get; set; }
		private Func<IEnumerable<T>, Task> _operationAsync { get; set; }
		public int Index { get; set; } = 1;
		public int PageSize { get; set; } = 10000;
		public bool HasNext { get; protected set; } = true;

		public BatchOperationOfT(
			Func<int, int, IEnumerable<T>> action, 
			Action<IEnumerable<T>> operation = null)
			: this(BatchOperationOfT<T>.DEFAULT_BATCH_SIZE,action,operation)
		{	
		}
		public BatchOperationOfT(
			int pageSize,
			Func<int, int, IEnumerable<T>> action,
			Action<IEnumerable<T>> operation = null)
		{
			this.PageSize = pageSize >= 10 ? pageSize : throw new Exception("Page size should be >= 10");
			this._action = action;
			this._operation = operation;	
		}

		public BatchOperationOfT(
			Func<int, int, Task<IEnumerable<T>>> action,
			Func<IEnumerable<T>, Task> operation = null)
			: this(BatchOperationOfT<T>.DEFAULT_BATCH_SIZE, action, operation)
		{
		}
		public BatchOperationOfT(
			int pageSize,
			Func<int, int, Task<IEnumerable<T>>> action,
			Func<IEnumerable<T>, Task> operation = null)
		{
			this.PageSize = pageSize >= 10 ? pageSize : throw new Exception("Page size should be >= 10");
			this._actionAsync = action;
			this._operationAsync = operation;
		}

		public virtual IEnumerable<T> GetNext()
		{
			IEnumerable<T> source = this._action(this.Index++, this.PageSize);
			this.HasNext = source.Count<T>() == this.PageSize;

			if(this._operation != null)
				this._operation(source);

			return source;
		}

		public virtual async Task<IEnumerable<T>> GetNextAsync()
		{
			IEnumerable<T> source = await this._actionAsync(this.Index++, this.PageSize);
			this.HasNext = source.Count<T>() == this.PageSize;

			if(this._operationAsync != null)
				await this._operationAsync(source);

			return source;
		}

		public List<T> GetAll()
		{
			List<T> all = new List<T>();

			do
			{
				all.AddRange(this.GetNext());
			}
			while (this.HasNext);

			return all;
		}

		public async Task<List<T>> GetAllAsync()
		{
			List<T> result = new List<T>();

			do
			{
				result.AddRange(await this.GetNextAsync());
			}
			while (this.HasNext);

			return result;
		}

		public void RunBatchOperation()
		{
			do
			{
				this.GetNext();
			}
			while(this.HasNext);
		}

		public async Task RunBatchOperationAsync()
		{
			do
			{
				await this.GetNextAsync();
			}
			while(!this.HasNext);
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (_disposedValue)
				return;

			if (disposing)
			{
				DisposeManagedState();
			}

			_disposedValue = true;
		}
		protected virtual void DisposeManagedState()
		{
			// Implement disposal of managed resources here
			// Example: Clean up collections or other managed objects
		}
	}
}
