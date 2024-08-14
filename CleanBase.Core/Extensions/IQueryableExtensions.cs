using CleanBase.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Extensions
{
	public static class IQueryableExtensions
	{
		private static MethodInfo OrderByMethod =
			MethodOf<IOrderedQueryable<object>>(
				() => default(IOrderedQueryable<object>)
					.OrderBy<object,object>(default(Expression<Func<object,object>>))
				).GetGenericMethodDefinition();

		private static MethodInfo OrderByDescendingMethod =
			MethodOf<IOrderedQueryable<object>>(
				() => default(IOrderedQueryable<object>)
					.OrderByDescending<object,object>(default(Expression<Func<object,object>>))
				).GetGenericMethodDefinition();

		private static MethodInfo ThenByMethod =
			MethodOf<IOrderedQueryable<object>>(
				() => default(IOrderedQueryable<object>)
					.ThenBy(default(Expression<Func<object, object>>))
				).GetGenericMethodDefinition();

		private static MethodInfo ThenByDescendingMethod =
			MethodOf<IOrderedQueryable<object>>(
				() => default(IOrderedQueryable<object>)
					.ThenByDescending(default(Expression<Func<object, object>>))
				).GetGenericMethodDefinition();

		public static IQueryable<T> Order<T, TKey>(
			this IQueryable<T> query,
			Expression<Func<T, TKey>> keySelector,
			bool? asc
			)
		{
			return asc.HasValue && !asc.Value ? query.OrderByDescending<T, TKey>(keySelector) : query.OrderBy<T, TKey>(keySelector);
		}

		public static IQueryable<T> OrderDynamic<T>(
			this IQueryable<T> source,
			string sortField,
			object asc)
		{
			if (string.IsNullOrWhiteSpace(sortField))
				throw new ArgumentException("Sort field cannot be null or empty", nameof(sortField));

			sortField = char.ToUpper(sortField[0]) + sortField.Substring(1);


			bool isDescending = asc switch
			{
				bool booleanValue => !booleanValue,
				string stringValue when stringValue.Equals("OrderByDescending", StringComparison.OrdinalIgnoreCase) => true,
				_ => throw new ArgumentException("Invalid type for asc parameter", nameof(asc))
			};

			if (sortField.Contains("."))
			{
				var sortItems = new List<SortItem>
		{
			new SortItem
			{
				PropertyName = sortField,
				IsDesc = isDescending
			}
		};
				return source.SortBy(sortItems);
			}

			var parameterExpression = Expression.Parameter(typeof(T), "p");
			var propertyExpression = Expression.Property(parameterExpression, sortField);
			var lambdaExpression = Expression.Lambda(propertyExpression, parameterExpression);

			var methodName = isDescending ? "OrderByDescending" : "OrderBy";
			var methodCallExpression = Expression.Call(
				typeof(Queryable),
				methodName,
				new[] { source.ElementType, propertyExpression.Type },
				source.Expression,
				lambdaExpression);

			return source.Provider.CreateQuery<T>(methodCallExpression);
		}


		public static IOrderedQueryable<T> SortBy<T>(
			this IQueryable<T> query,
			ICollection<SortItem> sortItems)
		{
			if (query == null)
				throw new ArgumentNullException(nameof(query), "query cannot be null");
			if (sortItems == null || !sortItems.Any())
				throw new ArgumentNullException(nameof(sortItems), "sortItems cannot be null or empty");

			Type type = typeof(T);
			IOrderedQueryable<T> orderedQueryable = null;

			foreach (var sortItem in sortItems)
			{
				var (expression, propertyType) = CreateExpression(type, sortItem.PropertyName);

				var method = (orderedQueryable == null)
					? (sortItem.IsDesc.Value 
						? IQueryableExtensions.OrderByDescendingMethod 
						: IQueryableExtensions.OrderByMethod)
					: (sortItem.IsDesc.Value 
						? IQueryableExtensions.ThenByDescendingMethod 
						: IQueryableExtensions.ThenByMethod);

				var parameterExpression = Expression.Parameter(
					orderedQueryable == null ? typeof(IQueryable<T>) : typeof(IOrderedQueryable<T>), "query");

				var lambda = Expression.Lambda(
					Expression.Call(
						method.MakeGenericMethod(type, propertyType),
						parameterExpression,
						expression),
					parameterExpression);

				orderedQueryable = lambda.Compile().DynamicInvoke(orderedQueryable ?? query) as IOrderedQueryable<T>;
			}

			return orderedQueryable;
		}

		private static (Expression expression, Type propertyType) CreateExpression(
			Type type,
			string propertyName)
		{
			var parameterExpression = Expression.Parameter(type, "o");
			var propertyNames = propertyName.Split('.');
			var expression = propertyNames.Aggregate(
				(Expression)parameterExpression,
				(current, propertyName) => Expression.PropertyOrField(current, propertyName));

			var propertyType = propertyNames
				.Select(propertyName => type.GetProperty(propertyName)?.PropertyType)
				.LastOrDefault();

			return (Expression.Lambda(expression, parameterExpression), propertyType);
		}

		public static MethodInfo MethodOf<T>(Expression<Func<T>> method)
		{
			return ((MethodCallExpression)method.Body).Method;
		}

	}
}
