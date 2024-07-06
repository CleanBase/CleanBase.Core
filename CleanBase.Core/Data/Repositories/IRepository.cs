using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Repositories
{
	public interface IRepository
	{
		object Add(object entity, bool saveChanges = false);
		object Update(object entity, bool saveChanges = false);	
		bool Delete(object entity, bool saveChanges = false);	
		
		Type EntityType { get; }
	}
}
