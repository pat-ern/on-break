using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Cena
    {
        public enum ModalidadServicioCena
        {
            Ejecutivo,
            Celebracion
        }

        public enum Ambientacion
        {
            Basica,
            Personalizada
        }

        public enum Local
        {
            OnBreak,
            Otro
        }

        public ModalidadServicioCena Servicio { get; set; }
        public Ambientacion TipoAmbientacion { get; set; }
        public bool MusicaAmbiental { get; set; }
        public Local Lugar { get; set; }

        // Constructor
        public Cena(ModalidadServicioCena servicio, Ambientacion tipoAmbientacion, bool musicaAmbiental, Local lugar)
        {
            Servicio = servicio;
            TipoAmbientacion = tipoAmbientacion;
            MusicaAmbiental = musicaAmbiental;
            Lugar = lugar;
        }

        public Cena()
        { }
    }
}
