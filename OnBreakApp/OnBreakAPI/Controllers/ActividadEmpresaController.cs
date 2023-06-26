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



    }
}