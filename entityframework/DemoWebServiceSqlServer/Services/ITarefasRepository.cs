namespace DemoWebServiceSqlServer.Services;
using DemoWebServiceSqlServer.Models;

public interface ITarefasRepository
{
    Task<Tarefa?> ConsultarPorIdAsync(long id);
    Task<IEnumerable<Tarefa>> ConsultarTodosAsync();
    Task<Tarefa> AdicionarAsync(Tarefa tarefa);
    
}