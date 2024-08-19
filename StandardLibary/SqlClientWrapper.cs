using Microsoft.Data.SqlClient;

namespace StandardLibary
{
    public class SqlClientWrapper
    {
        public void MakeConnectionToLocalhost()
        {
            var connection = new SqlConnection($"Server=localhost;MultipleActiveResultSets=True;Integrated Security=true;TrustServerCertificate=True;");
        }
    }
}
