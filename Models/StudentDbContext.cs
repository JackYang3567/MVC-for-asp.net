using System.Data.Entity;

namespace AspNetMvc.QuickStart.Models
{
    public class StudentDbContext : DbContext
    {
        public System.Data.Entity.DbSet<AspNetMvc.QuickStart.Models.Student> Students { get; set; }
    }
}