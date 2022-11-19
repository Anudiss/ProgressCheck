using System.Data.Entity;

namespace ProgressCheck2.DatabaseConnection
{
    public static class DatabaseContext
    {
        public static ShopExampleEntities Entities { get; }

        static DatabaseContext()
        {
            Entities = new ShopExampleEntities();

            Entities.Toy.Load();
        }
    }
}
