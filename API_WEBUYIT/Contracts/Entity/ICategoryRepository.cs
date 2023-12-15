using API_WEBUYIT.DTO;
using API_WEBUYIT.Entity;

namespace API_WEBUYIT.Contracts.Entity
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<CategoryEntity>> Get();
    }
}
