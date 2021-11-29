using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StrattonOakmontModels;
using StrattonOakmontServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace StrattonOakmontServices.Sql
{
    public class SQLRepository : ISQLRepository
    {
        private readonly AppDBContext _appDBContext;
        private readonly IConfiguration _configuration;

        public SQLRepository(AppDBContext appDBContext, IConfiguration configuration)
        {
            _appDBContext = appDBContext;
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
