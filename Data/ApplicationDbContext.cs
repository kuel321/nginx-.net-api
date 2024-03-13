// File: ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using ImageGalleryApi.Models; // Add this line

namespace ImageGalleryApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Image> ImageGallery { get; set; }
        public DbSet<ToDoList> ToDoList { get; set; }
          protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDoList>().HasKey(e => e.TaskID);
        // other configurations
    }
    }
}
