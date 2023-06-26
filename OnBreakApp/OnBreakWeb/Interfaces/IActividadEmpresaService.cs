using Models;

namespace OnBreakWeb.Interfaces
{
    public interface IActividadEmpresaService
    {
        Task<List<ActividadEmpresa>> GetList();
    }
}
