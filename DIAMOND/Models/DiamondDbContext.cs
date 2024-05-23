using Microsoft.EntityFrameworkCore;

namespace DIAMOND.Models
{
    public class DiamondDbContext : DbContext
    {
        public DiamondDbContext()
        {

        }
        public DiamondDbContext(DbContextOptions<DiamondDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
            var strConn = /*config["ConnectionStrings:DB"]*/ config.GetConnectionString("DB");

            return strConn;
        }

        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(e =>
            {
                e.ToTable("User");
                e.HasKey(x => x.userID);
                e.Property(x => x.username);
                e.Property(x => x.password);
                e.Property(x => x.email);
                e.Property(x => x.fullName);
                e.Property(x => x.status);
                e.Property(x => x.roleID);
                e.HasOne(x => x.role)
                .WithMany()
                .HasForeignKey(x => x.roleID);

            });
            modelBuilder.Entity<Role>(e =>
            {
                e.HasKey(x => x.roleID);
                e.Property(x => x.roleName);

            });



        }

    }
}
