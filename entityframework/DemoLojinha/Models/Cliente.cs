namespace DemoLojinha.Models;

public class Cliente
{
    public int Id {get;set;}
    public string Nome {get;set;}
    public string Email {get;set;}
    public string? Telefone {get;set;}
     //relacionamento 1-N com Pedido
    public List<Pedido> Pedidos {get;set;} = null!;
}