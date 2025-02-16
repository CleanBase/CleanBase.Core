using CleanBase.Core.Domain.Exceptions;

namespace CleanBase.Core.CustomAttribute
{
    [AttributeUsage(AttributeTargets.Property)]
    public class FilterFieldAttribute : Attribute
    {
        public string FilterType { get; }
        public string BindingField { get; }

        public FilterFieldAttribute(string filterType, string bindingField = null)
        {
            if (string.IsNullOrWhiteSpace(filterType))
                throw new DomainException(message: "Filter type cannot be null or empty." + nameof(filterType));

            FilterType = filterType;
            BindingField = bindingField;
        }
    }
}
