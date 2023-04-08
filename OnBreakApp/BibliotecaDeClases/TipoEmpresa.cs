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

        // propiedades //
        public int IdTipoEmpresa { get; set; }

        public string Descripcion { get; set; } = string.Empty;

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