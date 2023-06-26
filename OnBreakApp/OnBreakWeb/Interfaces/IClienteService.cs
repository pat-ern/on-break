
using Models;

namespace OnBreakWeb.Interfaces
{
    public interface IClienteService
    {
        Task<bool> Add(Cliente clienteAdd);
        Task<bool> Delete(string rutCliente);
        Task<Cliente> Get(string rutCliente);
        Task<List<Cliente>> GetList();
        Task<bool> Update(Cliente clienteUpdate);
    }
}
