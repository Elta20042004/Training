using System.Data.Entity;

namespace WebApplication1
{
    public class Books : DbContext
    {
        static Books ()
        {
            Database.SetInitializer<Books>(null);
            Database.SetInitializer<Books>(new CreateDatabaseIfNotExists<Books>());
        }

        public DbSet<Authors> Authors { get; set; }
        public DbSet<Boooks> Boooks { get; set; }
    }
}