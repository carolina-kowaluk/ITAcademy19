namespace DemoWebServiceSqlServer.Models;

public class Tarefa
{ //Id automaticamente vira PK! (TarefaId também)
    public long Id {get; set;}
    public string Nome {get; set;} = null!;
    public string? Descricao {get; set;} //se coloca ? fica opcional no BD
    public bool Completa {get; set;}
}