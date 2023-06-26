using Newtonsoft.Json;
using OnBreakWeb.Interfaces;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnBreakWeb.Models;
using Models;
using System.Text;

namespace OnBreakWeb.Services
{
    public class ContratoService : IContratoService
    {
        public ContratoService()
        {

        }

        public async Task<List<Contrato>> GetList()
        {
            string urlBase = "https://localhost:7010/api/";
            string url = "GetList";

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}Contrato/{url}");

                    if (!response.IsSuccessStatusCode)
                    {
                        return null;
                    }

                    var data = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<List<Contrato>>(data);

                    if (obj == null)
                    {
                        return null;
                    }

                    List<Contrato> contratos = new List<Contrato>();
                    foreach (var item in obj)
                    {
                        contratos.Add(new Contrato
                        {
                            Numero = item.Numero,
                            Creacion = item.Creacion,
                            Termino = item.Termino,
                            RutCliente = item.RutCliente,
                            IdModalidad = item.IdModalidad,
                            IdTipoEvento = item.IdTipoEvento,
                            FechaHoraInicio = item.FechaHoraInicio,
                            FechaHoraTermino = item.FechaHoraTermino,
                            Asistentes = item.Asistentes,
                            PersonalAdicional = item.PersonalAdicional,
                            Realizado = item.Realizado,
                            ValorTotalContrato = item.ValorTotalContrato,
                            Observaciones = item.Observaciones
 

                        });
                    }

                    return contratos;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       

    }
}
