using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Transactions
{
	public class EmptyTransaction : ICustomTransaction
	{
		private bool _disposed;

		/// <summary>
		/// Commits the transaction. Since this is an empty transaction, this method does nothing.
		/// </summary>
		public void Commit()
		{
		}

		/// <summary>
		/// Rolls back the transaction. Since this is an empty transaction, this method does nothing.
		/// </summary>
		public void Rollback()
		{
		}

		/// <summary>
		/// Disposes the transaction, releasing any resources held by this instance.
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
					// Dispose managed resources here, if any.
				}

				// Dispose unmanaged resources here, if any.
				_disposed = true;
			}
		}

		/// <summary>
		/// Destructor to ensure resources are released if Dispose is not called.
		/// </summary>
		~EmptyTransaction()
		{
			Dispose(false);
		}
	}
}
