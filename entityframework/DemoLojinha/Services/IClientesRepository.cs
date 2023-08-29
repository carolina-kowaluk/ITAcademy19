namespace DemoLojinha.Services;

using DemoLojinha.Models;

public interface IClientesRepository
{
    Task<Cliente?> ConsultaPorIdAsync(int id);
}