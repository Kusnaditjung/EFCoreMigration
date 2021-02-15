using System;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class DataContext: DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Can add constraint, index, check, data type, and even data seed
        } 
    }
}
