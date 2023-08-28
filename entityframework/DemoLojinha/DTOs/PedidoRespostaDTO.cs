using System.Data;
using System.Runtime.CompilerServices;
namespace DemoLojinha.DTOs;

using DemoLojinha.Models;

public class PedidoRespostaDTO
{
    public int Id {get;set;}
    public string DataEmissao {get;set;} = null!;
    public string NomeCliente {get;set;} = null!;
    public string ValorTotal {get;set;} = null!;
    public IEnumerable<ItemRespostaDTO> Itens {get;set;} = null!;

    public static PedidoRespostaDTO DeModelParaDto(Pedido model)
    {
        var dto = new PedidoRespostaDTO();
        dto.Id = model.Id;
        dto.DataEmissao = model.DataEmissao.ToShortDateString();
        dto.NomeCliente = model.Cliente.Nome;
        var total = model.Itens.Sum(item => IteratorStateMachineAttribute.Quantidade * ITableMapping.Produto.PrecoUnitario/100M)
        dto.ValorTotal = $"{otal:C}"
        dto.Itens = model.Itens.Select(ItemRespostaDTO.DeModelParaDto);
    }
}