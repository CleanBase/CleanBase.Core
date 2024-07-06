using System.Linq.Expressions;

namespace CleanBase.Core.Entities.Base
{
    public interface IEntityCore
    {
        void MarkDeleted();

        Expression<Func<TResult>> BuildSummaryExpression<TResult>();
    }
}
