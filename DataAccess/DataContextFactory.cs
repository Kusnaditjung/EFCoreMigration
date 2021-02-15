using System;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DataContext>();
            //this code will be never executed in runtime only in design time
            builder.UseSqlServer(
         "Server=localhost;Database=EFCoreMigration;Trusted_Connection=True;");
            return new DataContext(builder.Options);
        }
    }
}