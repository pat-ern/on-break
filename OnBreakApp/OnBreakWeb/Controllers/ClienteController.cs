using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnBreakWeb.Models;
using Newtonsoft.Json;
using Models;
using OnBreakWeb.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace OnBreakWeb.Controllers
{
    public class ClienteController: Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IClienteService _clienteService;
        private readonly IActividadEmpresaService _actividadEmpresaService;
        private readonly ITipoEmpresaService _tipoEmpresaService;


        public ClienteController(
                                ILogger<HomeController> logger,
                                IClienteService clienteService,
                                ITipoEmpresaService tipoEmpresaService,
                                IActividadEmpresaService actividadEmpresaService
                                )
        {
            _logger = logger;
            _clienteService = clienteService;
            _actividadEmpresaService = actividadEmpresaService;
            _tipoEmpresaService = tipoEmpresaService;
            
        }


        public async Task<ActionResult> Lista()
        {
            var objListado = from c in await _clienteService.GetList()
                             select new Cliente
                             {
                                 RutCliente = c.RutCliente,
                                 RazonSocial = c.RazonSocial,
                                 NombreContacto = c.NombreContacto,
                                 MailContacto = c.MailContacto,
                                 Direccion = c.Direccion,
                                 Telefono = c.Telefono,
                                 IdActividadEmpresa = c.IdActividadEmpresa,
                                 IdTipoEmpresa = c.IdTipoEmpresa
                             };

            return View(objListado.ToList());
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpGet]
        public async Task<ActionResult> Add()
        {
            Cliente objModel = new Cliente()
            {
                ListActividadEmpresa = await _actividadEmpresaService.GetList(),
                ListTipoEmpresa = await _tipoEmpresaService.GetList()
            };
            return View(objModel);


        }


        [HttpPost]
        public async Task<ActionResult> Add(Cliente clienteAdd)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

                var ok = await _clienteService.Add(new Cliente
                {
                    RutCliente = clienteAdd.RutCliente,
                    RazonSocial = clienteAdd.RazonSocial,
                    NombreContacto = clienteAdd.NombreContacto,
                    MailContacto = clienteAdd.MailContacto,
                    Direccion = clienteAdd.Direccion,
                    Telefono = clienteAdd.Telefono,
                    IdActividadEmpresa = clienteAdd.IdActividadEmpresa,
                    IdTipoEmpresa = clienteAdd.IdTipoEmpresa

                });

                if (ok)
                {
                    Console.WriteLine("Cliente agregado");
                }else
                {
                    Console.WriteLine("Cliente no agregado");
                }

                return RedirectToAction("Lista");
        }
        }
    
    }
