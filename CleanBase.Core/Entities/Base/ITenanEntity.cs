using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Entities.Base
{
    public interface ITenanEntity
    {
        string? TenantId { get; set; }
    }
}
