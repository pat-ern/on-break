using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class ModalidadServicio
    {
        public string IdModalidad { get; set; }
        public TipoEvento TipoEvento { get; set; }
        public string Nombre { get; set; }
        public float ValorBase { get; set; }
        public int PersonalBase { get; set; }


        public ModalidadServicio()
        {
            this.Init();
        }

        private void Init()
        {
            IdModalidad = string.Empty;
            TipoEvento = new TipoEvento();
            Nombre = string.Empty;
            ValorBase = 0;
            PersonalBase = 0;
        }

    }



}
