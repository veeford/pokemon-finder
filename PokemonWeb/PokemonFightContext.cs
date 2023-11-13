using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PokemonWeb;

public partial class PokemonFightContext : DbContext
{
    public PokemonFightContext()
    {
    }

    public PokemonFightContext(DbContextOptions<PokemonFightContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FightsLog> FightsLogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=127.0.0.2;Port=5433;Database=pokemon_fight;Username=postgres;Password=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FightsLog>(entity =>
        {
            entity.HasKey(e => e.FightId).HasName("fights_log_pkey");

            entity.ToTable("fights_log");

            entity.Property(e => e.FightId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("fight_id");
            entity.Property(e => e.FightDatetime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fight_datetime");
            entity.Property(e => e.LoserId).HasColumnName("loser_id");
            entity.Property(e => e.RoundsCount).HasColumnName("rounds_count");
            entity.Property(e => e.WinnerId).HasColumnName("winner_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
