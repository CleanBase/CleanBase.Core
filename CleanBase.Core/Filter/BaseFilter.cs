using System.Linq.Expressions;

namespace CleanBase.Core.Filter
{
    public abstract class BaseFilter
    {
        public string? FieldName { get; set; }
        public abstract Expression<Func<T, bool>> BuildExpression<T>();
    }
}
