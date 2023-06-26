using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Models
{
    public class TipoAmbientacion
    {
        [Key]
        public int IdTipoAmbientacion { get; set; }
        public string Descripcion { get; set; }
       
    }



}
