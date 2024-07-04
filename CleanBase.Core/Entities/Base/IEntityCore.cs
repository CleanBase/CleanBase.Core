using System.Linq.Expressions;

namespace CleanBase.Core.Entities.Base
{
    public interface IEntityCore
    {
        void MarkDelete();

        Expression<Func<TResult>> BuildSummaryExpression<TResult>();
    }
}
