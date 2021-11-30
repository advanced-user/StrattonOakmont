using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StrattonOakmontServices.Interfaces;
using System.Data;


namespace StrattonOakmontServices.Sql
{
    public class SQLRepository : ISQLRepository
    {
        private readonly IConfiguration _configuration;

        public SQLRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DataSet DoSql(string query)
        {
            SqlConnection sqlconn = new SqlConnection(_configuration.GetConnectionString("SecurityDBConnection"));
            DataSet ds = new DataSet();

            using (SqlConnection connection = sqlconn)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                adapter.Fill(ds);
            }

            return ds;
        }
    }
}
