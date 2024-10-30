namespace DataAccessLayer
{
	public class SqlHelper
	{
        public string ConnectionString { get; set; }
        public SqlHelper(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
    }
}
