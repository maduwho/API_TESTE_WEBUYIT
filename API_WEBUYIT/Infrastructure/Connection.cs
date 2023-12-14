﻿using Dapper;
using MySql.Data.MySqlClient;

namespace API_WEBUYIT.Infrastructure
{
    public class Connection
    {
        protected string connectionString = "Server=localhost;Database=api_teste;User=root;Password=root";

        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        protected async Task<int> Execute(string sql, object obj)
        {
            using (MySqlConnection conn = GetConnection())
            {
                return await conn.ExecuteAsync(sql, obj);
            }
        }
    }
}