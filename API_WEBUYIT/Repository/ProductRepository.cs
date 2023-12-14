using API_WEBUYIT.Contracts.Entity;
using API_WEBUYIT.DTO;
using API_WEBUYIT.Entity;
using API_WEBUYIT.Infrastructure;
using Dapper;

namespace API_WEBUYIT.Repository
{
    public class ProductRepository : Connection, IProductRepository
    {
        public async Task Add(ProductDTO product)
        {
            string sql = "INSERT INTO PRODUCT (Name, Description, OriginalPrice, CurrentPrice, Discount, Buyers) VALUE (@Name, @Description, @OriginalPrice, @CurrentPrice, @Discount, @Buyers)";

            await Execute(sql, product);
        }

        public async Task Delete(int id)
        {
            string sql = "DELETE FROM PRODUCT WHERE Id = @id";
            await Execute(sql, new { id });
        }

        public async Task<IEnumerable<ProductEntity>> Get()
        {
            string sql = "SELECT * FROM PRODUCT";
            return await GetConnection().QueryAsync<ProductEntity>(sql);
        }

        public async Task<ProductEntity> GetById(int id)
        {
            string sql = "SELECT * FROM PRODUCT WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new { id });
        }

        public async Task<ProductEntity> GetByName(string name)
        {
            string sql = "SELECT * FROM PRODUCT WHERE Name = @name";
            return await GetConnection().QueryFirstAsync<ProductEntity>(sql, new { name });
        }

        public async Task Update(ProductEntity product)
        {
            string sql = "@ UPDATE PRODUCT SET Name = @Name, Description = @Description, OriginalPrice = @OriginalPrice, CurrentPrice = @CurrentPrice, Discount = @Discount, Buyers = @Buyers";

            await Execute(sql, product);
        }
    }

}
