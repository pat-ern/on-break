using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class TipoEmpresa
    {
        // Escribiendo un comentario para nada//
        // propiedades //
        public int IdTipoEmpresa { get; set; }

        public string Descripcion { get; set; } 

        public TipoEmpresa()
        {
            this.Init();
        }

        private void Init()
        { 
            IdTipoEmpresa = 0;
            Descripcion = string.Empty;
        }

    }
}