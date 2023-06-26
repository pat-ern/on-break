using Microsoft.AspNetCore.Mvc;
using OnBreakWeb;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Models;

namespace OnBreakAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoEmpresaController : Controller
    {

        private readonly ILogger<TipoEmpresaController> _logger;

        public TipoEmpresaController(ILogger<TipoEmpresaController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        [Route("GetList")]
        public async Task<ActionResult> List()
        {
            try
            {
                using (DbConnection db = new DbConnection())
                {
                    var lst = await db.TipoEmpresa.ToListAsync();
                    return Ok(lst);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]
        [Route("Get/{idTipoEmpresa}")]
        public async Task<TipoEmpresa> Get(int idTipoEmpresa)
        {
            try
            {
                using (DbConnection db = new DbConnection())
                {
                    TipoEmpresa objTipoEmpresa = await db.TipoEmpresa.FirstOrDefaultAsync(c => c.IdTipoEmpresa == idTipoEmpresa);

                    if (objTipoEmpresa == null)
                    {
                        return null;
                    }

                    TipoEmpresa tipoEmpresa = new TipoEmpresa()
                    {
                        IdTipoEmpresa = objTipoEmpresa.IdTipoEmpresa,
                        Descripcion = objTipoEmpresa.Descripcion

                    };

                    return tipoEmpresa;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}