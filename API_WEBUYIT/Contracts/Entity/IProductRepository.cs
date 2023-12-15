using API_WEBUYIT.Entity;
using API_WEBUYIT.DTO;

namespace API_WEBUYIT.Contracts.Entity
{
    public interface IProductRepository
    {
        Task Add(ProductDTO product);
        Task<IEnumerable<ProductEntity>> Get();
        Task Update(ProductEntity product);
        Task Delete(int id);
        Task<ProductEntity> GetById(int id);
        Task<ProductEntity> GetByName(string name);
    }
}
