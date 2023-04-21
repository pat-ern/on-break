using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Cena : Contrato
    {
        public string Numero { get; set; }
        public TipoAmbientacion TipoAmbientacion { get; set; }
        public bool MusicaAmbiental { get; set; }
        public bool LocalOnBreak { get; set; }
        public bool OtroLocalOnBreak { get; set; }
        public float ValorArriendo { get; set; }


        // Constructor

        public Cena(string numero, TipoAmbientacion tipoAmbientacion, bool musicaAmbiental, bool localOnBreak, bool otroLocalOnBreak, float valorArriendo)
        {
            Numero = numero;
            TipoAmbientacion = tipoAmbientacion;
            MusicaAmbiental = musicaAmbiental;
            LocalOnBreak = localOnBreak;
            OtroLocalOnBreak = otroLocalOnBreak;
            ValorArriendo = valorArriendo;
        }

        public Cena()
        {
            this.Init();
        }

        private void Init()
        {

            Numero = string.Empty;
            TipoAmbientacion = new TipoAmbientacion();
            MusicaAmbiental = false;
            LocalOnBreak = false;
            OtroLocalOnBreak = false;
            ValorArriendo = 0;

        }
    }
}
