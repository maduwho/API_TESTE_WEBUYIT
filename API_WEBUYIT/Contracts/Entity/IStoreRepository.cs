using API_WEBUYIT.Entity;

namespace API_WEBUYIT.Contracts.Entity
{
    public interface IStoreRepository
    {
       Task<IEnumerable<StoreEntity>> Get();
    }
}
