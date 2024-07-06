using CleanBase.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Repositories
{
	public interface IRepositoryKeyOfT <T> : IRepository where T : class, IEntityKey
	{
		bool Delete(string key, bool saveChanges = false);
	}
}
