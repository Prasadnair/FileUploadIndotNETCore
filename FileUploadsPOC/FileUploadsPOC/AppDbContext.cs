using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FileUploadsPOC
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<ImageEntity> Images { get; set; }
    }
}
