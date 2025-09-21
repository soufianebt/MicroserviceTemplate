using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace ProjectName.Data
{
    public class ProjectNameContext: DbContext
    {
        public DbSet<Model.ProjectName> ProjectNames { get; set; }
        public ProjectNameContext(DbContextOptions<ProjectNameContext> options)
            : base(options)
        {
        }
        //  protected override void OnConfiguring(DbContextOptionsBuilder options)
        //=> options.UseSqlServer("Server=localhost,1433;Database=GoogleToken;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;");
    }
}
