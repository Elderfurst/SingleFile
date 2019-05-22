using Microsoft.EntityFrameworkCore;
using SingleFile.Models;

namespace SingleFile
{
    public class FileContext : DbContext
    {
        public FileContext(DbContextOptions<FileContext> options) : base(options) { }

        public DbSet<File> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<File>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
        }
    }
}
