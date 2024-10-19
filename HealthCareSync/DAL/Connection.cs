namespace HealthCareSync.DAL
{
    public static class Connection
    {
        public static string ConnectionSting()
        {
            var builder = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder
            {
                Server = "cs-dblab01.uwg.westga.edu",
                UserID = "cs3230f24c",
                Password = "ZIEbXBxGYTIGdXa>RbSJ",
                Database = "cs3230f24c",
                Port = 3306
            };
            return builder.ToString();
        }
    }
}
