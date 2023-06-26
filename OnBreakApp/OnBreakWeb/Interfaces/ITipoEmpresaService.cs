using Models;
using OnBreakWeb.Models;

namespace OnBreakWeb.Interfaces
{
    public interface ITipoEmpresaService
    {
        Task<TipoEmpresa> Get(int idTipoEmpresa);
        Task<List<TipoEmpresa>> GetList();
    }
}
