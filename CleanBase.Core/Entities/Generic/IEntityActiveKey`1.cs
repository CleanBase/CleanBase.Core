using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Generic
{
	public interface IEntityActiveKey <T> : IEntityActive, IEntityKey<T>
	{
	}
}
