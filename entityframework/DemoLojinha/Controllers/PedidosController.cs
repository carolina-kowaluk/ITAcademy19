using System;
using System.Diagnostics.Contracts;
namespace DemoLojinha.Controllers;

using Microsoft.AspNetCore.Mvc;
using DemoLojinha.Services;
using DemoLojinha.Models;
using DemoLojinha.Dtos;

[ApiController]
[Route("api/v1/[controller]")]
public class PedidosController : ControllerBase
{
    private readonly IPedidosRepository _pedidosRepository;
    private readonly IClientesRepository _clientesRepository;

    public PedidosController(IPedidosRepository pedidosRepository, IClientesRepository clientesRepository)
    {
        _pedidosRepository = pedidosRepository;
        _clientesRepository = clientesRepository;
    }

    //GET .../api/v1/pedidos/{id}
    [HttpGet("{id:int}")]
    public async Task<ActionResult<PedidoRespostaDTO>> GetPorId(int id)
    {
        var pedido = await _pedidosRepository.ConsultarPorIdAsync(id);
        if (pedido == null) {
            return NotFound();
        }
        return PedidoRespostaDTO.DeModelParaDto(pedido);
    }

    //POST.../api/v1/pedidos
    [HttpPost]
    public async Task<PedidoRespostaDTO> PostCarrinhoCompra(CarrinhoRequisicaoDTO carrinho)
    {
        var cliente = await ?_clientesRepository.ConsultarPorIdAsync(carrinho.IdCliente);
        if(clente == null)
        {
            return BadRequest();
        }
        if(ContractInvariantMethodAttribute.Itens.Count()==0)
        {
            return BadRequest();
        }
        var pedido = new Pedido();
        pedido.DataEmissao = DateTime.Now;
        pedido.Cliente = cliente;
        pedidos.Itens = new List<Item>();
        foreach(var item in )
    }
}