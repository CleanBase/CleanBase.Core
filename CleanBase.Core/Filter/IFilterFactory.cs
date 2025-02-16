namespace CleanBase.Core.Filter
{
    public interface IFilterFactory
    {
        BaseFilter CreateFilter(string filterType);
        void RegisterFilter(string filterType, Func<BaseFilter> filterCreator);
    }
}
