using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using OnBreakWeb.Models;

namespace Models
{

    public class Cliente
    {
        [Key]
        public List<ActividadEmpresa>? ListActividadEmpresa { get; set; }
        public List<TipoEmpresa>? ListTipoEmpresa { get; set; }
        public string RutCliente { get; set; }
        public string RazonSocial { get; set; }
        public string NombreContacto { get; set; }
        public string MailContacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int IdActividadEmpresa { get; set; }
        public int IdTipoEmpresa { get; set; }




    }
   
}
