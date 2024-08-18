using System;

namespace CleanBase.Core.Data.Policies.Generic
{
	/// <summary>
	/// Provides a base implementation for modification policies for entities of type <typeparamref name="T"/>.
	/// </summary>
	/// <typeparam name="T">The type of the entity that this policy applies to.</typeparam>
	public class ModificationPolicy<T> : IModificationPolicy<T>
	{
		/// <summary>
		/// Default implementation of the Chalenge method.
		/// </summary>
		/// <param name="entity">The entity to be processed.</param>
		public void Challenge(T entity) => throw new NotImplementedException();

		/// <summary>
		/// Virtual method to handle checks or actions before deleting an entity.
		/// Can be overridden in derived classes to provide specific functionality.
		/// </summary>
		/// <param name="entity">The entity to be checked before deletion.</param>
		public virtual void ChallengeDelete(T entity)
		{
			// Default implementation does nothing.
			// Override in derived classes to provide specific functionality.
		}

		/// <summary>
		/// Virtual method to handle checks or actions before adding an entity.
		/// Can be overridden in derived classes to provide specific functionality.
		/// </summary>
		/// <param name="entity">The entity to be checked before addition.</param>
		public virtual void ChallengeBeforeAdd(T entity)
		{
			// Default implementation does nothing.
			// Override in derived classes to provide specific functionality.
		}

		/// <summary>
		/// Virtual method to handle checks or actions before finding an entity.
		/// Can be overridden in derived classes to provide specific functionality.
		/// </summary>
		/// <param name="entity">The entity to be checked before searching.</param>
		public virtual void ChallengeFind(T entity)
		{
			// Default implementation does nothing.
			// Override in derived classes to provide specific functionality.
		}

		/// <summary>
		/// Virtual method to handle checks or actions before updating an entity.
		/// Can be overridden in derived classes to provide specific functionality.
		/// </summary>
		/// <param name="entity">The entity to be checked before updating.</param>
		public virtual void ChallengeBeforeUpdate(T entity)
		{
			// Default implementation does nothing.
			// Override in derived classes to provide specific functionality.
		}
	}
}
