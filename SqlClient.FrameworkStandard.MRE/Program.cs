using StandardLibary;

namespace FrameworkProject
{
    static class Program
    {
        static void Main(string[] args)
        {
            // This should work but does NOT work
            // System.IO.FileNotFoundException: Microsoft.Data.SqlClient
            var sqlClient = new SqlClientWrapper();
            sqlClient.MakeConnectionToLocalhost();
        }
    }
}