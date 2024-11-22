using Microsoft.EntityFrameworkCore;

namespace fDSignUp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SignUpModel> SignUps { get; set; }
    }
}
