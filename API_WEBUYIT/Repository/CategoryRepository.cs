using API_WEBUYIT.Entity;
using Dapper;
using API_WEBUYIT.Contracts.Entity;
using API_WEBUYIT.Infrastructure;

namespace API_WEBUYIT.Repository
{
    public class CategoryRepository : Connection, ICategoryRepository
    {
        public async Task<IEnumerable<CategoryEntity>> Get()
        {
            string sql = "SELECT * FROM CATEGORY";
            return await GetConnection().QueryAsync<CategoryEntity>(sql);
        }
    }
}