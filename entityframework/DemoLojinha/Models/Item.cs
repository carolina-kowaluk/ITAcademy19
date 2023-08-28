using System.Dynamic;
namespace DemoLojinha.Models;

public class Item
{
    public int Quantidade {get;set;}
    //relacionamento N-1 com Poduto
    public Produto Produto {get;set;} = null!;
    public int ProdutoId {get;set;}
    //relacionamento N-1 com Pedido
    public Pedido Pedido {get;set;} = null!;
    public int PedodoId {get;set;}

}