using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;

namespace Emplyee.Data
{
    public class EmplyeeContext : DbContext
    {
        public DbSet<Model.Emplyee> Emplyees { get; set; }
        public EmplyeeContext(DbContextOptions<EmplyeeContext> options)
            : base(options)
        {
        }
        //  protected override void OnConfiguring(DbContextOptionsBuilder options)
        //=> options.UseSqlServer("Server=localhost,1433;Database=GoogleToken;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;");
    }
}
