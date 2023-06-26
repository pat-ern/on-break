﻿using System.Diagnostics;
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
        private readonly IContratoService _contratoService;


        public ClienteController(
                                ILogger<HomeController> logger,
                                IClienteService clienteService,
                                ITipoEmpresaService tipoEmpresaService,
                                IActividadEmpresaService actividadEmpresaService,
                                IContratoService contratoService
                                )
        {
            _logger = logger;
            _clienteService = clienteService;
            _actividadEmpresaService = actividadEmpresaService;
            _tipoEmpresaService = tipoEmpresaService;
            _contratoService = contratoService;
            
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
                    TempData["mensajeAgregado"] = "Cliente agregado correctamente.";
                }else
                {
                    Console.WriteLine("Cliente no agregado");
                    TempData["mensajeAdvertenciaAgregar"] = "Cliente no agregado.";
                }

                return RedirectToAction("Lista");
        }
        
        public async Task<ActionResult> Edit(string id)
        {

            var objCliente = await _clienteService.Get(id);

            Cliente objModel = new Cliente()
            {
                RutCliente = objCliente.RutCliente,
                RazonSocial = objCliente.RazonSocial,
                NombreContacto = objCliente.NombreContacto,
                MailContacto = objCliente.MailContacto,
                Direccion = objCliente.Direccion,
                Telefono = objCliente.Telefono,
                IdActividadEmpresa = objCliente.IdActividadEmpresa,
                IdTipoEmpresa = objCliente.IdTipoEmpresa,
                ListActividadEmpresa = await _actividadEmpresaService.GetList(),
                ListTipoEmpresa = await _tipoEmpresaService.GetList()

            };



            return View(objModel);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Cliente clienteUpdate)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var ok = await _clienteService.Update(new Cliente
            {
                RutCliente = clienteUpdate.RutCliente,
                RazonSocial = clienteUpdate.RazonSocial,
                NombreContacto = clienteUpdate.NombreContacto,
                MailContacto = clienteUpdate.MailContacto,
                Direccion = clienteUpdate.Direccion,
                Telefono = clienteUpdate.Telefono,
                IdActividadEmpresa = clienteUpdate.IdActividadEmpresa,
                IdTipoEmpresa = clienteUpdate.IdTipoEmpresa

            });

            if (ok)
            {
                Console.WriteLine("Cliente actualizado");
                TempData["mensajeActualizado"] = "Cliente actualizado correctamente.";

            }
            else
            {
                Console.WriteLine("Cliente no actualizado");
                TempData["mensajeAdvertencia"] = "Cliente no actualizado.";
            }

            return RedirectToAction("Lista");
        }


        public async Task<ActionResult> Delete(string id)
        {
            var ok = await _clienteService.Delete(id);

            var contratos = await _contratoService.GetList();

            var contrato = contratos.Where(c => c.RutCliente == id).FirstOrDefault();

            if (contrato != null)
            {
                Console.WriteLine("Cliente no eliminado, tiene contratos asociados");
                TempData["mensajeAdvertencia"] = "Cliente no eliminado, tiene contratos asociados.";
            }
            else
            {
                if (ok)
                {
                    Console.WriteLine("Cliente eliminado");
                    TempData["mensajeEliminado"] = "Cliente eliminado correctamente.";
                }
                else
                {
                    Console.WriteLine("Cliente no eliminado");
                    TempData["mensajeAdvertencia"] = "Cliente no eliminado.";
                }
            }


            return RedirectToAction("Lista");
        }



    }
    
    }
