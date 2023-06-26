using Microsoft.AspNetCore.Mvc;
using OnBreakWeb;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Models;

namespace OnBreakAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActividadEmpresaController : Controller
    {

        private readonly ILogger<ActividadEmpresaController> _logger;

        public ActividadEmpresaController(ILogger<ActividadEmpresaController> logger)
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
                    var lst = await db.ActividadEmpresa.ToListAsync();
                    return Ok(lst);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpGet]
        [Route("Get/{idActividadEmpresa}")]
        public async Task<ActividadEmpresa> Get(int idActividadEmpresa)
        {
            try
            {
                using (DbConnection db = new DbConnection())
                {
                    ActividadEmpresa objActividadEmpresa = await db.ActividadEmpresa.FirstOrDefaultAsync(c => c.IdActividadEmpresa == idActividadEmpresa);

                    if (objActividadEmpresa == null)
                    {
                        return null;
                    }

                    ActividadEmpresa actividadEmpresa = new ActividadEmpresa()
                    {
                        IdActividadEmpresa = objActividadEmpresa.IdActividadEmpresa,
                        Descripcion = objActividadEmpresa.Descripcion

                    };

                    return actividadEmpresa;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }





    }
}