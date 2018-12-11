using System.Data.Common;
using System.Data.SqlClient;

namespace CleanArchitecture.Persistence.Repositories
{
    public class ConnectionFactory
    {
        public DbConnection CreateConnection()
        {
            return new SqlConnection(MasterConnection);
        }

        public string MasterConnection
        {
            get
            {
                return "Server=(localDb)\\MSSQLLocalDB; Database=CleanArchitecture; Trusted_Connection=True; MultipleActiveResultSets=true";
                //return public static string MasterConnection = ConfigurationManager.ConnectionStrings["MasterConnection"].ConnectionString;
            }
        }
    }
}
