using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StudentApp.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            var connectionString =
                "server=localhost;port=3306;database=studentdb;user=root;password=;";

            optionsBuilder.UseMySQL(connectionString);

            return new AppDbContext(optionsBuilder.Options);
        }
    }
}