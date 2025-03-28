using ConsoleServiceTool.RepairHub.Persistence.Entities.Parts;
using ConsoleServiceTool.RepairHub.Services;
using Microsoft.EntityFrameworkCore;

namespace ConsoleServiceTool.RepairHub.Persistence;

public class ApplicationDbContext : DbContext
{
    public DbSet<PartType> PartTypes { get; set; }
    public DbSet<PartAttributeDefinition> PartsAttributes { get; set; }
    public DbSet<PartDefinition> Parts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=repairhub.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PartType>().HasData(
            new PartType { Id = 1L, Description = "Single component", Name = "Component" },
            new PartType { Id = 2L, Description = "Assembled component", Name = "Assembled component" },
            new PartType { Id = 3L, Description = "Final assembled product", Name = "Final" }
        );

        modelBuilder.Entity<PartAttributeDefinition>().HasData(
            new PartAttributeDefinition { Id = 1L, Description = "Serial number of the mother board", Name = "Mb Serial" },
            new PartAttributeDefinition { Id = 2L, Description = "Serial number of the daughter board", Name = "Db Serial" },
            new PartAttributeDefinition { Id = 3L, Description = "Serial number of the console", Name = "Console Serial" }
        );
        modelBuilder.Entity<PartDefinition>().HasData(
            new PartDefinition { Id = 1L, Description = "PS5 Motherboard", Name = "EDM-010", PartTypeId = 2L },
            new PartDefinition { Id = 2L, Description = "PS5 Motherboard", Name = "EDM-020", PartTypeId = 2L },
            new PartDefinition { Id = 3L, Description = "PS5 Motherboard", Name = "EDM-030", PartTypeId = 2L },
            new PartDefinition { Id = 4L, Description = "PS5 Motherboard", Name = "EDM-031", PartTypeId = 2L },
            new PartDefinition { Id = 5L, Description = "PS5 Motherboard", Name = "EDM-032", PartTypeId = 2L },
            new PartDefinition { Id = 6L, Description = "PS5 Motherboard", Name = "EDM-033", PartTypeId = 2L },
            new PartDefinition { Id = 7L, Description = "PS5 Digital - first edition", Name = "CFI-10XXB", PartTypeId = 3L },
            new PartDefinition { Id = 8L, Description = "PS5 Digital - second edition", Name = "CFI-11XXB", PartTypeId = 3L },
            new PartDefinition { Id = 9L, Description = "PS5 Digital - third edition", Name = "CFI-11XXB", PartTypeId = 3L }
        );

        modelBuilder.Entity<PartDefinitionPartAttributeDefinition>().HasData(
            new {PartDefinitionId = 1L,  PartAttributeDefinitionId = 1L, IsRequired = true },
            new { PartDefinitionId = 1L, PartAttributeDefinitionId = 2L, IsRequired = true },
            new { PartDefinitionId = 2L, PartAttributeDefinitionId = 3L, IsRequired = false }
        );

        // NEW: Many-to-many link between PartDefinition and PartAttributeDefinition
        modelBuilder.Entity<PartDefinition>(entity =>
        {
            entity.HasKey(pd => pd.Id);
            entity.HasMany(pd => pd.PartAttributes)
                .WithOne(link => link.PartDefinition)
                .HasForeignKey(link => link.PartDefinitionId);
        });

        modelBuilder.Entity<PartAttributeDefinition>(entity =>
        {
            entity.HasKey(pa => pa.Id);
            entity.HasMany(pa => pa.PartDefinitions)
                .WithOne(link => link.PartAttributeDefinition)
                .HasForeignKey(link => link.PartAttributeDefinitionId);
        });

        modelBuilder.Entity<PartDefinitionPartAttributeDefinition>(entity =>
        {
            entity.HasKey(link => new { link.PartDefinitionId, link.PartAttributeDefinitionId });
        });
    }
}