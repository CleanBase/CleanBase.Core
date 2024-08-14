using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Extensions
{
	public static class ObjectExtensions
	{
		public static void NormalizeData(this object obj)
		{
			if (obj == null) return;

			foreach(PropertyInfo property in obj.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty))
			{
				var currenObjValue = property.GetValue(obj);
				
				if(currenObjValue is string && property.CanWrite)
				{
					var newNormalizeObjectData = ((string) currenObjValue).Trim();
					property.SetValue(obj, newNormalizeObjectData);
				}
			}	
		}
	}
}
