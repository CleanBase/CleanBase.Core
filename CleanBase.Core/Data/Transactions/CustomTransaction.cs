using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CleanBase.Core.Data.Transactions
{
	/// <summary>
	/// A concrete implementation of the ICustomTransaction interface that wraps a System.Transactions.TransactionScope.
	/// </summary>
	public class CustomTransaction : ICustomTransaction
	{
		private readonly TransactionScope _transactionScope;
		private bool _disposed;

		/// <summary>
		/// Initializes a new instance of the <see cref="CustomTransaction"/> class with a specific isolation level.
		/// </summary>
		/// <param name="isolationLevel">The isolation level for the transaction.</param>
		public CustomTransaction(IsolationLevel isolationLevel)
		{
			_transactionScope = new TransactionScope(TransactionScopeOption.Required, new TransactionOptions
			{
				IsolationLevel = isolationLevel
			});
		}

		/// <summary>
		/// Commits the transaction, completing all operations within the transaction scope.
		/// </summary>
		public void Commit()
		{
			_transactionScope.Complete();
		}

		/// <summary>
		/// Rolls back the transaction by simply disposing of the transaction scope without completing it.
		/// </summary>
		public void Rollback()
		{
			// No need to explicitly rollback; simply do not call Complete and dispose.
		}

		/// <summary>
		/// Disposes the transaction, releasing the transaction scope and any resources held by this instance.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		/// <summary>
		/// Disposes the transaction, optionally releasing managed resources.
		/// </summary>
		/// <param name="disposing">True to release managed resources, otherwise false.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					_transactionScope?.Dispose();
				}
				_disposed = true;
			}
		}

		/// <summary>
		/// Destructor to ensure resources are released if Dispose is not called.
		/// </summary>
		~CustomTransaction()
		{
			Dispose(false);
		}
	}
}
