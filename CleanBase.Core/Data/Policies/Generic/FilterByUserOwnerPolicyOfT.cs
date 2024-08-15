using CleanBase.Core.Entities;
using CleanBase.Core.Services.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBase.Core.Data.Policies.Generic
{
	public class FilterByUserOwnerPolicyOfT<T> : FilterPolicyOfT<T> where T : IEntityAudit
	{
		public FilterByUserOwnerPolicyOfT(string userName)
		  : base(p => p.CreatedBy == userName)
		{
		}
		public FilterByUserOwnerPolicyOfT(IIdentityProvider identityProvider)
		{
			if (identityProvider.Identity != null)
			{
				this.Expression = p => p.CreatedBy == identityProvider.Identity.Name;
			}
			else
			{
				this.Expression = p => false;
			}
		}
	}
}
