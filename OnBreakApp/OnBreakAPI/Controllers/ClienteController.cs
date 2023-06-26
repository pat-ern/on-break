using Microsoft.AspNetCore.Mvc;
using OnBreakWeb;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Models;

namespace OnBreakAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {

        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
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
                    var lst = await db.Cliente.ToListAsync();
                    return Ok(lst);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> Add(Cliente cliente)
        {
            try
            {
                using (DbConnection db = new DbConnection())
                {
                    db.Cliente.Add(cliente);
                    await db.SaveChangesAsync();
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task<bool> Update(Cliente clienteUpdate)
        {
            try
            {
                using (DbConnection db = new DbConnection())
                {
                    Cliente objCliente = await db.Cliente.FirstOrDefaultAsync(c => c.RutCliente == clienteUpdate.RutCliente);

                    if (objCliente == null)
                    {
                        return false;
                    }

                    objCliente.RutCliente = clienteUpdate.RutCliente;
                    objCliente.RazonSocial = clienteUpdate.RazonSocial;
                    objCliente.NombreContacto = clienteUpdate.NombreContacto;
                    objCliente.MailContacto = clienteUpdate.MailContacto;
                    objCliente.Direccion = clienteUpdate.Direccion;
                    objCliente.Telefono = clienteUpdate.Telefono;
                    objCliente.IdActividadEmpresa = clienteUpdate.IdActividadEmpresa;
                    objCliente.IdTipoEmpresa = clienteUpdate.IdTipoEmpresa;


                    db.Update(objCliente);
                    await db.SaveChangesAsync();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [HttpDelete]
        [Route("Delete/{rut}")]
        public async Task<bool> Delete(string rut)
        {
            try
            {
                using (DbConnection db = new DbConnection())
                {
                    Cliente objCliente = await db.Cliente.FirstOrDefaultAsync(c => c.RutCliente == rut);

                    Contrato objContrato = await db.Contrato.FirstOrDefaultAsync(c => c.RutCliente == rut);

                    if (objContrato != null)
                    {
                        return false;
                    }

                    if (objCliente == null)
                    {
                        return false;
                    }

                    db.Cliente.Remove(objCliente);
                    await db.SaveChangesAsync();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("Get/{rut}")]
        public async Task<Cliente> Get(string rut)
        {
            try
            {
                using (DbConnection db = new DbConnection())
                {
                    Cliente objCliente = await db.Cliente.FirstOrDefaultAsync(c => c.RutCliente == rut);

                    if (objCliente == null)
                    {
                        return null;
                    }

                    Cliente cliente = new Cliente()
                    {
                        RutCliente = objCliente.RutCliente,
                        RazonSocial = objCliente.RazonSocial,
                        NombreContacto = objCliente.NombreContacto,
                        MailContacto = objCliente.MailContacto,
                        Direccion = objCliente.Direccion,
                        Telefono = objCliente.Telefono,
                        IdActividadEmpresa = objCliente.IdActividadEmpresa,
                        IdTipoEmpresa = objCliente.IdTipoEmpresa
                    };

                    return cliente;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        





    }
}