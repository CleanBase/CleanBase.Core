using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Domain.Generic
{
	public class ListResultOfT<T>
	{
		public IEnumerable<T> Items { get; set; }
		public int Total { get; set; }	
		public int? Skiped { get; set; }
		public int? PageSize { get; set; }	
		public object MetaData { get; set; }

		public ListResultOfT(IEnumerable<T> items, int total = -1)
		{
			this.Items = items;

			if (total == -1)
				this.Total = this.Items.Count<T>();
			else 
				this.Total = total;
		}
	}
}
