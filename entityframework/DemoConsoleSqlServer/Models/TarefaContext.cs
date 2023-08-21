using Microsoft.EntityFrameworkCore;

public class TarefaContext : DbContext
{
    public DbSet<Tarefa> Tarefas {get;set;} = null!;

    protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Server=nomeDoServidor;DataBase=tarefasbd;Trusted_Connection=True;"); //configura conexão com o banco de dados
        //string de conexão passada por parâmetro
        optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating (ModelBuilder modelBuilder)
    { //vai sobrescrever as regras padrão
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Tarefa>()
                    .Property(t => t.Nome)
                    .HasMaxLength(30);
    } 
}