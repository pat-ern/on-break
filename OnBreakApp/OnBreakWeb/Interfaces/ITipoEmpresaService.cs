using Models;
using OnBreakWeb.Models;

namespace OnBreakWeb.Interfaces
{
    public interface ITipoEmpresaService
    {
        Task<List<TipoEmpresa>> GetList();
    }
}
