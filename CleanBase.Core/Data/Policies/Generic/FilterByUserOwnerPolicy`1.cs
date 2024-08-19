using CleanBase.Core.Entities;
using CleanBase.Core.Services.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class FilterByUserOwnerPolicy<T> : FilterPolicy<T> where T : IEntityAudit
	{
		public FilterByUserOwnerPolicy(Guid userId)
		  : base(p => p.CreatedBy == userId)
		{
		}
		public FilterByUserOwnerPolicy(IIdentityProvider identityProvider)
		{
			if (identityProvider.Identity != null)
			{
				this.Expression = p => p.CreatedBy == identityProvider.Identity.UserId;
			}
			else
			{
				this.Expression = p => false;
			}
		}
	}
}
