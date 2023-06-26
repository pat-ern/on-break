using Microsoft.AspNetCore.Mvc;
using OnBreakWeb;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Models;

namespace OnBreakAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContratoController : Controller
    {

        private readonly ILogger<ContratoController> _logger;

        public ContratoController(ILogger<ContratoController> logger)
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
                    var lst = await db.Contrato.ToListAsync();
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