namespace ProgressCheck.DatabaseConnection
{
    public static class Connection
    {
        public static AuthorizationDabaseEntities Entities { get; }

        static Connection() => Entities = new AuthorizationDabaseEntities();
    }
}
