namespace DemoLojinha.Services;

using Microsoft.EntityFrameworkCore;
using DemoLojinha.Models;

public class ProdutosRepositoryEF : IProdutosRepository
{
    private readonly LojinhaContext _context;

    //injetando a dependencia
    public ProdutosRepositoryEF(LojinhaContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Produto>>  ConsultarTodosAsync()
    {
        return await _context.Produtos.OrderBy(p => p.Nome).ToListAsync();
    }

    
}