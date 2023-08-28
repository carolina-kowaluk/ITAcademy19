namespace DemoWebServiceSqlServer.Services;

using Microsoft.EntityFrameworkCore;
using DemoWebServiceSqlServer.Models;

public class TarefaContext : DbContext
{
    public DbSet<Tarefa> Tarefas {get; set;} = null!;
 // esta classe vai ter 2 construtores: o base e o q recebe o obj de configuracao do DbContext
    public TarefaContext()
    {
    }
// abaixo, chama construtor herdado:
    public TarefaContext(DbContextOptions<TarefaContext> opcoes)
        : base(opcoes)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { // documentação no EFCore = creating Model = entity types
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Tarefa>(entityBuilder => {
            entityBuilder.HasKey(t => t.Id)
                         .HasName("PK_Tarefas_Id"); //pode haver Alternate Keys (mais de uma PK = compostas)
            entityBuilder.Property(t => t.Nome)
                         .HasMaxLength(30);
            entityBuilder.Property(t => t.Descricao)
                         .HasMaxLength(150);
        });
    }
}