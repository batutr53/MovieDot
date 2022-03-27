using Microsoft.EntityFrameworkCore;
using MovieDot.Core.Models;
using System.Reflection;

namespace MovieDot.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.Entity<MovieCategory>().HasKey(x => new { x.CategoryId, x.MovieId });
            modelBuilder.Entity<MovieActor>().HasKey(x => new { x.ActorId, x.MovieId });
            modelBuilder.Entity<MovieGenre>().HasKey(x => new { x.GenreId, x.MovieId });
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

    }
}
