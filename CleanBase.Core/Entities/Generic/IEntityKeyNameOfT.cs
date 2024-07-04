using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanBase.Core.Entities.Base;

namespace CleanBase.Core.Entities.Generic
{
    public interface IEntityKeyNameOfT<TKey> : IEntityKeyOfT<TKey>, IEntityName
    {
    }
}
