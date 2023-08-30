using System;
using System.Collections.Generic;
using DemoWebServiceScaffold.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoWebServiceScaffold.Services;

public partial class BibliotecaContext : DbContext
{
    public BibliotecaContext()
    {
    }

    public BibliotecaContext(DbContextOptions<BibliotecaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autor> Autors { get; set; }

    public virtual DbSet<Emprestimo> Emprestimos { get; set; }

    public virtual DbSet<Livro> Livros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>(entity =>
        {
            entity.ToTable("Autor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Primeironome)
                .HasMaxLength(10)
                .HasColumnName("primeironome");
            entity.Property(e => e.Ultimonome)
                .HasMaxLength(10)
                .HasColumnName("ultimonome");
        });

        modelBuilder.Entity<Emprestimo>(entity =>
        {
            entity.ToTable("Emprestimo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Datadevolucao)
                .HasColumnType("date")
                .HasColumnName("datadevolucao");
            entity.Property(e => e.Dataretirada)
                .HasColumnType("date")
                .HasColumnName("dataretirada");
            entity.Property(e => e.Entregue).HasColumnName("entregue");
            entity.Property(e => e.Idlivro).HasColumnName("idlivro");

            entity.HasOne(d => d.IdlivroNavigation).WithMany(p => p.Emprestimos)
                .HasForeignKey(d => d.Idlivro)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Emprestimo_Livro");
        });

        modelBuilder.Entity<Livro>(entity =>
        {
            entity.ToTable("Livro");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Titulo)
                .HasMaxLength(50)
                .HasColumnName("titulo");

            entity.HasMany(d => d.Idautors).WithMany(p => p.Idlivros)
                .UsingEntity<Dictionary<string, object>>(
                    "AutorLivro",
                    r => r.HasOne<Autor>().WithMany()
                        .HasForeignKey("Idautor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AutorLivro_Autor"),
                    l => l.HasOne<Livro>().WithMany()
                        .HasForeignKey("Idlivro")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AutorLivro_Livro"),
                    j =>
                    {
                        j.HasKey("Idlivro", "Idautor");
                        j.ToTable("AutorLivro");
                        j.IndexerProperty<int>("Idlivro").HasColumnName("idlivro");
                        j.IndexerProperty<int>("Idautor").HasColumnName("idautor");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
