using Models;

namespace OnBreakWeb.Interfaces
{
    public interface IClienteService
    {
        Task<bool> Add(Cliente clienteAdd);
        Task<List<Cliente>> GetList();
    }
}
