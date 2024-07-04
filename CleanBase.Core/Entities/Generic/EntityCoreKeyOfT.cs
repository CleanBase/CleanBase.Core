using CleanBase.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Generic
{
    public class EntityCoreKeyOfT<TKey> :
        EntityCore,
        IEntityKeyOfT<TKey>
    {
        [Key]
        [MaxLength(36)]
        public TKey Id { get; set; }
    }
}
