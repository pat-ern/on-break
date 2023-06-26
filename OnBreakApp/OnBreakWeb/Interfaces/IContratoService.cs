using Models;

namespace OnBreakWeb.Interfaces
{
    public interface IContratoService
    {
        Task<List<Contrato>> GetList();
    }
}
