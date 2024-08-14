using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using CleanBase.Core.Extensions;

namespace CleanBase.Core
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			TestOrderDynamic_SortsAscending_WhenAscIsTrue();
			TestOrderDynamic_SortsDescending_WhenAscIsFalse();
			TestOrderDynamic_ThrowsException_WhenSortFieldIsEmpty();
			TestOrderDynamic_ThrowsException_WhenAscIsInvalid();
		}

		private static void TestOrderDynamic_SortsAscending_WhenAscIsTrue()
		{
			// Arrange
			dynamic obj = new ExpandoObject();
			obj.HI = "HELO";
			obj.HAHA = "HAHA";

			var data = new List<Person>
			{
				new Person { Name = "Charlie", Age = 30},
				new Person { Name = "Alice", Age = 25 },
				new Person { Name = "Bob", Age = 2 }
			}.AsQueryable();

			// Act
			var result = data.OrderDynamic("Name", true).ToList();

			// Output
			Console.WriteLine("TestOrderDynamic_SortsAscending_WhenAscIsTrue:");
			foreach (var person in result)
			{
				Console.WriteLine($"{person.Name} - {person.Age}");
			}
		}

		private static void TestOrderDynamic_SortsDescending_WhenAscIsFalse()
		{
			// Arrange
			var data = new List<Person>
			{
				new Person { Name = "Charlie", Age = 30 },
				new Person { Name = "Alice", Age = 25 },
				new Person { Name = "Bob", Age = 28 }
			}.AsQueryable();

			// Act
			var result = data.OrderDynamic("Age", false).ToList();

			// Output
			Console.WriteLine("TestOrderDynamic_SortsDescending_WhenAscIsFalse:");
			foreach (var person in result)
			{
				Console.WriteLine($"{person.Name} - {person.Age}");
			}
		}

		private static void TestOrderDynamic_ThrowsException_WhenSortFieldIsEmpty()
		{
			// Arrange
			var data = new List<Person>().AsQueryable();

			// Act & Output
			try
			{
				data.OrderDynamic("", true);
				Console.WriteLine("TestOrderDynamic_ThrowsException_WhenSortFieldIsEmpty: No exception thrown");
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine($"TestOrderDynamic_ThrowsException_WhenSortFieldIsEmpty: Exception thrown - {ex.Message}");
			}
		}

		private static void TestOrderDynamic_ThrowsException_WhenAscIsInvalid()
		{
			// Arrange
			var data = new List<Person>().AsQueryable();

			// Act & Output
			try
			{
				data.OrderDynamic("Age", "InvalidValue");
				Console.WriteLine("TestOrderDynamic_ThrowsException_WhenAscIsInvalid: No exception thrown");
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine($"TestOrderDynamic_ThrowsException_WhenAscIsInvalid: Exception thrown - {ex.Message}");
			}
		}
	}

	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public dynamic? Object { get; set; }
	}

	public class SortItem
	{
		public string PropertyName { get; set; }
		public bool? IsDesc { get; set; }
	}
}
