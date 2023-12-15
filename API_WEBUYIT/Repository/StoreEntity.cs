using API_WEBUYIT.Entity;
using Dapper;
using API_WEBUYIT.Contracts.Entity;
using API_WEBUYIT.Infrastructure;

namespace API_WEBUYIT.Repository
{
    public class StoreRepository : Connection, IStoreRepository
    {
        public async Task<IEnumerable<StoreEntity>> Get()
        {
            string sql = "SELECT * FROM STORE";
            return await GetConnection().QueryAsync<StoreEntity>(sql);
        }
    }
}