using Newtonsoft.Json;
using OnBreakWeb.Interfaces;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnBreakWeb.Models;
using Models;
using System.Text;

namespace OnBreakWeb.Services
{
    public class ClienteService : IClienteService
    {
        public ClienteService() { 

        }

        public async Task<List<Cliente>> GetList()
        {
            string urlBase = "https://localhost:7010/api/";
            string url = "GetList";

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
                    var obj = JsonConvert.DeserializeObject<List<Cliente>>(data);

                    if (obj == null)
                    {
                        return null;
                    }

                    List<Cliente> clientes = new List<Cliente>();
                    foreach (var item in obj)
                    {
                        clientes.Add(new Cliente
                        {
                            RutCliente = item.RutCliente,
                            RazonSocial = item.RazonSocial,
                            NombreContacto = item.NombreContacto,
                            MailContacto = item.MailContacto,
                            Direccion = item.Direccion,
                            Telefono = item.Telefono,
                            IdActividadEmpresa = item.IdActividadEmpresa,
                            IdTipoEmpresa = item.IdTipoEmpresa
                        });
                    }

                    return clientes;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Add(Cliente clienteAdd)
        {
            string urlBase = "https://localhost:7010/api/";
            string url = $"Add";

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    var data = JsonConvert.SerializeObject(clienteAdd);
                    var content = new StringContent(data, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await httpClient.PostAsync($"{urlBase}Cliente/{url}", content);

                    if (!response.IsSuccessStatusCode)
                    {
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Update(Cliente clienteUpdate)
        {
            string urlBase = "https://localhost:7010/api/";
            string url = $"Update";

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    var data = JsonConvert.SerializeObject(clienteUpdate);
                    var content = new StringContent(data, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await httpClient.PutAsync($"{urlBase}Cliente/{url}", content);

                    if (!response.IsSuccessStatusCode)
                    {
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> Delete(string rutCliente)
        {
            string urlBase = "https://localhost:7010/api/";
            string url = $"Delete/{rutCliente}";

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync($"{urlBase}Cliente/{url}");

                    if (!response.IsSuccessStatusCode)
                    {
                        return false;
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<Cliente> Get(string rutCliente)
        {
            string urlBase = "https://localhost:7010/api/";
            string url = $"Get/{rutCliente}";

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
                    var obj = JsonConvert.DeserializeObject<Cliente>(data);

                    if (obj == null)
                    {
                        return null;
                    }

                    Cliente cliente = new Cliente
                    {
                        RutCliente = obj.RutCliente,
                        RazonSocial = obj.RazonSocial,
                        NombreContacto = obj.NombreContacto,
                        MailContacto = obj.MailContacto,
                        Direccion = obj.Direccion,
                        Telefono = obj.Telefono,
                        IdActividadEmpresa = obj.IdActividadEmpresa,
                        IdTipoEmpresa = obj.IdTipoEmpresa
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
