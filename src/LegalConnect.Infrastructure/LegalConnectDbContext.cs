using LegalConnect.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LegalConnect.Infrastructure;

public sealed class LegalConnectDbContext(DbContextOptions<LegalConnectDbContext> options) : DbContext(options)
{
    public DbSet<LawyerProfile> LawyerProfiles => Set<LawyerProfile>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LawyerProfile>(entity =>
        {
            entity.HasKey(profile => profile.Id);
            entity.Property(profile => profile.DisplayName).HasMaxLength(160).IsRequired();
            entity.Property(profile => profile.PracticeSummary).HasMaxLength(1000).IsRequired();
            entity.HasIndex(profile => profile.VerificationStatus);
        });
    }
}

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("LegalConnect")
            ?? "Server=(localdb)\\mssqllocaldb;Database=LegalConnect;Trusted_Connection=True;MultipleActiveResultSets=true";
        services.AddDbContext<LegalConnectDbContext>(options => options.UseSqlServer(connectionString));
        return services;
    }
}
