using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace pokemon;

public partial class PostgresContext : DbContext
{
    public PostgresContext()
    {
    }

    public PostgresContext(DbContextOptions<PostgresContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FightsLog> FightsLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=127.0.0.2;Port=5433;Database=postgres;Username=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FightsLog>(entity =>
        {
            entity
                .ToTable("fights_log")
                .HasKey(p => p.Id);

            entity.HasIndex(e => e.Id, "fights_log_id_idx").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Loser)
                .HasColumnType("character varying")
                .HasColumnName("loser");
            entity.Property(e => e.Winner)
                .HasColumnType("character varying")
                .HasColumnName("winner");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
