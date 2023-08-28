namespace DemoWebServiceSqlServer.Services;

using DemoWebServiceSqlServer.Models;

public interface ITarefasRepository
{ //usar métodos assincronos, p nao bloquear usuarios
    Task<IEnumerable<Tarefa>> ConsultarTodosAsync(); 
    Task<Tarefa?> ConsultarPorIdAsync(long Id);
    Task<Tarefa> AdicionarAsync(Tarefa tarefa);
    Task AlterarAsync(Tarefa tarefa); //sincrono void
}