using FirelloProject.Models;
using FirelloProject.Models.demo;
using Microsoft.EntityFrameworkCore;

namespace FirelloProject.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions options):base(options)
        {
                
        }
        public DbSet<Slider>? Slider { get; set; }
        public DbSet<SliderDetail>? SliderDetails { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<ProductImage>? ProductImages { get; set; }
        public DbSet<Bio>? Bios { get; set; }
        public DbSet<Author>? Authors;
        public DbSet<Book>? Books { get; set; }
        public DbSet<BookAuthor>? BookAuthors { get; set; }
        public DbSet<BookGenre>? BookGenres { get; set; }
        public DbSet<Genre>? Genres { get; set; }
        public DbSet<BookImages>? BookImages { get; set; }
        public DbSet<SocialPage>? SocialPages;
    

    }
}
