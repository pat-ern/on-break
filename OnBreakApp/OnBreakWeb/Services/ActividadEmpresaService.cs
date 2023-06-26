using Newtonsoft.Json;
using OnBreakWeb.Interfaces;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnBreakWeb.Models;
using Models;
using System.Text;

namespace OnBreakWeb.Services
{
    public class ActividadEmpresaService : IActividadEmpresaService
    {
        public ActividadEmpresaService()
        {

        }

        public async Task<List<ActividadEmpresa>> GetList()
        {
            string urlBase = "https://localhost:7010/api/";
            string url = "GetList";

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}ActividadEmpresa/{url}");

                    if (!response.IsSuccessStatusCode)
                    {
                        return null;
                    }

                    var data = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<List<ActividadEmpresa>>(data);

                    if (obj == null)
                    {
                        return null;
                    }

                    List<ActividadEmpresa> actividadEmpresas = new List<ActividadEmpresa>();
                    foreach (var item in obj)
                    {
                        actividadEmpresas.Add(new ActividadEmpresa
                        {
                            IdActividadEmpresa = item.IdActividadEmpresa,
                            Descripcion = item.Descripcion,
                        });
                    }

                    return actividadEmpresas;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ActividadEmpresa> Get(int idActividadEmpresa)
        {
            string urlBase = "https://localhost:7010/api/";
            string url = $"Get/{idActividadEmpresa}";

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}Cliente/{url}");

                    if (!response.IsSuccessStatusCode)
                    {
                        return null;
                    }

                    var data = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<ActividadEmpresa>(data);

                    if (obj == null)
                    {
                        return null;
                    }

                    ActividadEmpresa actividadEmpresa = new ActividadEmpresa
                    {
                        IdActividadEmpresa = obj.IdActividadEmpresa,
                        Descripcion = obj.Descripcion,
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
