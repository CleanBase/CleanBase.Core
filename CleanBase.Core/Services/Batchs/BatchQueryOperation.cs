using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Services.Batchs
{
	public class BatchQueryOperation
	{
		public static IEnumerable<T> GetAll<T>(
			int pageSize,
			Func<int, int, IEnumerable<T>> action)
		{
			return new BatchOperationOfT<T>(pageSize, action).GetAll();
		}

		public static IEnumerable<T> GetAll<T>(
			Func<int, int, IEnumerable<T>> action)
		{
			return new BatchOperationOfT<T>(action).GetAll();
		}

		public static void RunBatchOperation<T>(
			int pageSize,
			Func<int, int, IEnumerable<T>> action,
			Action<IEnumerable<T>> operaion)
		{
			new BatchOperationOfT<T>(pageSize, action, operaion).RunBatchOperation();
		}

		public static void RunBatchOperation<T>(
			Func<int, int, IEnumerable<T>> action,
			Action<IEnumerable<T>> operaion)
		{
			new BatchOperationOfT<T>(action, operaion).RunBatchOperation();
		}

		public static async Task RunBatchOperationAsync<T>(
			int pageSize,
			Func<int, int, Task<IEnumerable<T>>> action,
			Func<IEnumerable<T>, Task> operation = null)
		{
			await new BatchOperationOfT<T>(pageSize, action, operation).RunBatchOperationAsync();
		}

		public static async Task RunBatchOperationAsync<T>(
			Func<int, int, Task<IEnumerable<T>>> action,
			Func<IEnumerable<T>, Task> operation = null)
		{
			await new BatchOperationOfT<T>(action, operation).RunBatchOperationAsync();
		}
	}
}
