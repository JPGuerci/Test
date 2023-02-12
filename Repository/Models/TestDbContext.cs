using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

public partial class TestDbContext : DbContext
{
    public TestDbContext()
    {
    }

    public TestDbContext(DbContextOptions<TestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Issue> Issues { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<StatusIssue> StatusIssues { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Issue>(entity =>
        {
            entity.HasOne(d => d.Status).WithMany(p => p.Issues)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Incidencia_EstadoIncidencia");
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Nota");

            entity.HasOne(d => d.Issue).WithMany(p => p.Notes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nota_Incidencia");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
