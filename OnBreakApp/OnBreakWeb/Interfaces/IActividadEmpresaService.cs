using Models;

namespace OnBreakWeb.Interfaces
{
    public interface IActividadEmpresaService
    {
        Task<ActividadEmpresa> Get(int idActividadEmpresa);
        Task<List<ActividadEmpresa>> GetList();
    }
}
