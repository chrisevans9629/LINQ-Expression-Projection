
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace LinqExpressionProjection.Test.Model
{
    class ProjectsDbContext : DbContext
    {
        static SqliteConnection con = new SqliteConnection("DataSource=:memory:");
        public DbSet<Project> Projects { get; set; }
        public DbSet<Subproject> Subprojects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            con.Open();

            optionsBuilder.UseSqlite(con);
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
