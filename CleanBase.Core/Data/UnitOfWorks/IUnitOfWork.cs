using CleanBase.Core.Data.Repositories;
using CleanBase.Core.Data.Transactions;
using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CleanBase.Core.Data.UnitOfWorks
{
	/// <summary>
	/// Defines the contract for a unit of work, which manages the coordination 
	/// of transactions and repositories in a data context.
	/// </summary>
	public interface IUnitOfWork
	{
		/// <summary>
		/// Begins a new transaction with the specified isolation level.
		/// </summary>
		/// <param name="level">The isolation level for the transaction.</param>
		/// <returns>An instance of <see cref="ICustomTransaction"/> representing the transaction.</returns>
		ICustomTransaction BeginTransaction(IsolationLevel level);

		/// <summary>
		/// Begins a new transaction with the default isolation level.
		/// </summary>
		/// <returns>An instance of <see cref="ICustomTransaction"/> representing the transaction.</returns>
		ICustomTransaction BeginTransaction();

		/// <summary>
		/// Asynchronously saves all changes made in the context to the database.
		/// </summary>
		/// <returns>A task representing the asynchronous operation.</returns>
		Task SaveChangesAsync();

		/// <summary>
		/// Saves all changes made in the context to the database.
		/// </summary>
		void SaveChanges();

		/// <summary>
		/// Retrieves a repository for the specified entity type.
		/// </summary>
		/// <typeparam name="T">The type of the entity.</typeparam>
		/// <returns>An instance of <see cref="IRepository{T}"/> for the specified entity type.</returns>
		IRepository<T> GetRepositoryByEntityType<T>() where T : class, IEntityCore;

		/// <summary>
		/// Retrieves a repository of the specified type.
		/// </summary>
		/// <typeparam name="TRepo">The type of the repository.</typeparam>
		/// <returns>An instance of the specified repository type.</returns>
		TRepo Repository<TRepo>() where TRepo : IRepository;
	}
}
