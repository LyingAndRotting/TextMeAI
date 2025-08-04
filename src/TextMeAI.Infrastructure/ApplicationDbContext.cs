using Microsoft.EntityFrameworkCore;
using TextMeAI.Domain.Entities;
using TextMeAI.Domain.Entities.Chat;
using TextMeAI.Infrastructure.Configurations;

namespace TextMeAI.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base()
    {
        
    }

    public ApplicationDbContext(DbContextOptions options) :
        base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Server=127.0.0.1;port=5432; DataBase=TMAI;UserId=postgres;password=root");
    }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Chat> Chats { get; set; }
    
}