using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyFirstMVCApp.Models;

public partial class devdbContext : DbContext
{
    public devdbContext(DbContextOptions<devdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<app_info> app_info { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<app_info>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__app_info__3213E83F916AB731");

            entity.Property(e => e.author).HasMaxLength(50);
            entity.Property(e => e.name).HasMaxLength(50);
            entity.Property(e => e.remark).HasMaxLength(100);
            entity.Property(e => e.version).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
