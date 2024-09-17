using Microsoft.EntityFrameworkCore;

namespace AbstraxArtStore.Models
{
    public class ImageDbContext:DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext> options) : base(options) 
        { 
        }
        public DbSet<ImageModel> Images { get; set; }
    }
}
