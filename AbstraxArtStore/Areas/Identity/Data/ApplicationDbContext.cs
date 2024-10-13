using AbstraxArtStore.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AbstraxArtStore.Models;

namespace AbstraxArtStore.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{


    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }


    protected override void OnModelCreating(ModelBuilder builder)
    {

        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });
            });

            // Seeds the role which is the admin role.
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" }
                );

            // Creates a password hasher.
            var harsher = new PasswordHasher<ApplicationUser>();

            // Seeds the user table with an admin user.
            builder.Entity<ApplicationUser>().HasData(

                new ApplicationUser
                {
                    Id = "1",
                    FirstName = "Ahmad",
                    LastName = "Mahmoud",
                    UserName = "admin@abstraxartstore.com", // Email
                    NormalizedUserName = "ADMIN@ABSTRAXARTSTORE.COM",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    // Password
                    PasswordHash = harsher.HashPassword(null, "Admin123")
                }

            );

            // Seeds the UserRoles table.
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "1", UserId = "1" }
            );
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        }
    }

    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(255);
            builder.Property(u => u.LastName).HasMaxLength(255);
        }
    }

    public DbSet<AbstraxArtStore.Models.Cart> Cart { get; set; } = default!;

    public DbSet<AbstraxArtStore.Models.Payment> Payment { get; set; } = default!;

    public DbSet<AbstraxArtStore.Models.Product> Product { get; set; } = default!;

    public DbSet<AbstraxArtStore.Models.Order> Order { get; set; } = default!;

    public DbSet<AbstraxArtStore.Models.Category> Category { get; set; } = default!;
}
