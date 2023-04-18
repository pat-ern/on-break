using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Cliente
    {
        public string RutCliente { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public string NombreContacto { get; set; } = string.Empty;
        public string MailContacto { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public ActividadEmpresa ActividadEmpresa { get; set; } = new ActividadEmpresa();
        public TipoEmpresa TipoEmpresa { get; set; } = new TipoEmpresa();

        public Cliente() 
        {
            this.Init();
        }

        private void Init()
        { 
            RutCliente = string.Empty;
            RazonSocial = string.Empty;
            NombreContacto = string.Empty;
            MailContacto = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            ActividadEmpresa = new ActividadEmpresa();
            TipoEmpresa = new TipoEmpresa();
        }

    }
}
