using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;
using Newtonsoft.Json;
using OnBreakWeb.Models;

namespace Models
{

    public class Cliente
    {

        [Key]
        [Required(ErrorMessage = "El campo es requerido.")]
        public string RutCliente { get; set; }
        [Required(ErrorMessage = "El campo es requerido.")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "El campo es requerido.")]
        public string NombreContacto { get; set; }
        [Required(ErrorMessage = "El campo es requerido.")]
        public string MailContacto { get; set; }
        [Required(ErrorMessage = "El campo es requerido.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo es requerido.")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "El campo es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes elegir una actividad empresa.")]
        public int IdActividadEmpresa { get; set; }
        [Required(ErrorMessage = "El campo es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "Debes elegir un tipo empresa.")]
        public int IdTipoEmpresa { get; set; }

        public List<ActividadEmpresa>? ListActividadEmpresa { get; set; }

        public List<TipoEmpresa>? ListTipoEmpresa { get; set; }





    }
   
}
