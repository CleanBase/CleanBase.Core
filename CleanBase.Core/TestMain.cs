using System;
using System.Collections.Generic;
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
			var data = new List<Person>
			{
				new Person { Name = "Charlie", Age = 30 },
				new Person { Name = "Alice", Age = 25 },
				new Person { Name = "Bob", Age = 28 }
			}.AsQueryable();

			// Act
			var result = data.OrderDynamic("Age", true).ToList();

			// Assert
			Console.WriteLine("TestOrderDynamic_SortsAscending_WhenAscIsTrue:");
			Console.WriteLine(result[0].Name == "Alice" ? "Passed" : "Failed");
			Console.WriteLine(result[1].Name == "Bob" ? "Passed" : "Failed");
			Console.WriteLine(result[2].Name == "Charlie" ? "Passed" : "Failed");
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

			// Assert
			Console.WriteLine("TestOrderDynamic_SortsDescending_WhenAscIsFalse:");
			Console.WriteLine(result[0].Name == "Charlie" ? "Passed" : "Failed");
			Console.WriteLine(result[1].Name == "Bob" ? "Passed" : "Failed");
			Console.WriteLine(result[2].Name == "Alice" ? "Passed" : "Failed");
		}

		private static void TestOrderDynamic_ThrowsException_WhenSortFieldIsEmpty()
		{
			// Arrange
			var data = new List<Person>().AsQueryable();

			// Act & Assert
			try
			{
				data.OrderDynamic("", true);
				Console.WriteLine("TestOrderDynamic_ThrowsException_WhenSortFieldIsEmpty: Failed");
			}
			catch (ArgumentException)
			{
				Console.WriteLine("TestOrderDynamic_ThrowsException_WhenSortFieldIsEmpty: Passed");
			}
		}

		private static void TestOrderDynamic_ThrowsException_WhenAscIsInvalid()
		{
			// Arrange
			var data = new List<Person>().AsQueryable();

			// Act & Assert
			try
			{
				data.OrderDynamic("Age", "InvalidValue");
				Console.WriteLine("TestOrderDynamic_ThrowsException_WhenAscIsInvalid: Failed");
			}
			catch (ArgumentException)
			{
				Console.WriteLine("TestOrderDynamic_ThrowsException_WhenAscIsInvalid: Passed");
			}
		}
	}

	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
	}


	public class SortItem
	{
		public string PropertyName { get; set; }
		public bool? IsDesc { get; set; }
	}
}
