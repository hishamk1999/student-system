using P02_SalesDatabase.Data;

namespace P02_SalesDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationDBContext();
            context.Database.EnsureCreated();
            DbSeeder.Seed(context);
        }
    }
}
