using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD10Mins.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            Post[] postsToSeed = new Post[10];

            for (int i = 1; i < 11; i++)
            {
                postsToSeed[i - 1] = new Post
                {
                    Id = i,
                    Title = $"Post {i}",
                    Content = $"This is some example content for post {i}. The content is very interesting and I just wanted it to be two sentences long."
                };
            }

            modelBuilder.Entity<Post>().HasData(postsToSeed);
        }
    }
}
