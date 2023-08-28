using System.Reflection;
namespace DemoLojinha.DTOs;

using DemoLojinha.Models;

public class ItemRespostaDTO
{
    public int IdProduto {get;set;}
    public string NomeProduto {get;set;} = null!;
    public string ValorUnitario {get;set;} = null!;
    public int quantidade {get;set;}
    public string SubTotal {get;set;} = null!;
    public static ItemRespostaDTO DeModelParaDto(Item model)
    {
        var dto = new ItemRespostaDTO();
        dto.IdProduto = model.ProdutoId;
        dto.NomeProduto = Module.Produto.Nome;
        dto.ValorUnitario = ${model.Produto.PrecoUnitario/100:C}";
        dto.SubTotal = $"{model.Quantidade * model.Produto.PrecoUnitario}"
    }
}