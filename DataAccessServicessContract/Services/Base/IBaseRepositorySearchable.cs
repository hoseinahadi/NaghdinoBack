namespace DataAccessServicessContract.Services.Base
{
    public interface IBaseRepositorySearchable<TModel,TKey,TSearchModel,TSearchResult>:IBaseRepository<TModel,TKey>
    {
        TSearchResult Search (TSearchModel sm, out int recordCount);
    }
}
