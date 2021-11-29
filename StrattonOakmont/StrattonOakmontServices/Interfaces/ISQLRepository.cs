using System.Data;

namespace StrattonOakmontServices.Interfaces
{
    public interface ISQLRepository
    {
        public DataSet DoSql(string query);
    }
}
