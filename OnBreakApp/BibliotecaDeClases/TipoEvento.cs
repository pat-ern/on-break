using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class TipoEvento
    {
        public int IdTipoEvento { get; set; }
        public string Descripcion { get; set; }

        public TipoEvento()
        {
            this.Init();
        }

        private void Init()
        {
            IdTipoEvento = 0;
            Descripcion = string.Empty;
        }

    }



}
