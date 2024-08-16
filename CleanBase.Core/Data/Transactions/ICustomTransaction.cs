using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Transactions
{
		/// <summary>
		/// Represents a custom transaction interface that supports commit, rollback, and resource disposal.
		/// </summary>
		public interface ICustomTransaction : IDisposable
		{
			/// <summary>
			/// Commits the transaction.
			/// </summary>
			void Commit();

			/// <summary>
			/// Rolls back the transaction.
			/// </summary>
			void Rollback();
		}
}
