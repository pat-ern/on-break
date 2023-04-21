using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Cocktail : Contrato
    {
        public string Numero { get; set; }
        public TipoAmbientacion TipoAmbientacion { get; set; }
        public bool Ambientacion { get; set; }
        public bool MusicaAmbiental { get; set; }
        public bool MusicaCliente { get; set; }


        public Cocktail(string numero, TipoAmbientacion tipoAmbientacion, bool ambientacion, bool musicaAmbiental, bool musicaCliente)
        {
            Numero = numero;
            TipoAmbientacion = tipoAmbientacion;
            Ambientacion = ambientacion;
            MusicaAmbiental = musicaAmbiental;
            MusicaCliente = musicaCliente;
        }

        public Cocktail()
        {
            this.Init();
        }


        private void Init()
        {
            Numero = string.Empty;
            TipoAmbientacion = new TipoAmbientacion();
            Ambientacion = false;
            MusicaAmbiental = false;
            MusicaCliente = false;

        }
    }

}
