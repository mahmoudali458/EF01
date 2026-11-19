using Microsoft.EntityFrameworkCore;

namespace EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext dbContext = new AppDbContext() ;
            // opened a connection with database

            dbContext.Database.MigrateAsync();

           // dbContext.testModels.Add(new TestModel());

            dbContext.SaveChanges();
           

        }
    }
}
