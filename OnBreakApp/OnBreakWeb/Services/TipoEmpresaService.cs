using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OnBreakWeb.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace OnBreakWeb.Services
{
    public class TipoEmpresaService : ITipoEmpresaService
    {
        public TipoEmpresaService()
        {

        }

        public async Task<List<TipoEmpresa>> GetList()
        {
            string urlBase = "https://localhost:7010/api/";
            string url = "GetList";

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.GetAsync($"{urlBase}TipoEmpresa/{url}");

                    if (!response.IsSuccessStatusCode)
                    {
                        return null;
                    }

                    var data = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<List<TipoEmpresa>>(data);

                    if (obj == null)
                    {
                        return null;
                    }

                    List<TipoEmpresa> tipoEmpresas = new List<TipoEmpresa>();
                    foreach (var item in obj)
                    {
                        tipoEmpresas.Add(new TipoEmpresa
                        {
                            IdTipoEmpresa = item.IdTipoEmpresa,
                            Descripcion = item.Descripcion,
                        });
                    }

                    return tipoEmpresas;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
