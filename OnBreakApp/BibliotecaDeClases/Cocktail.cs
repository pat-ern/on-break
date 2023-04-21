using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public enum ModalidadServicioCocktail
    {
        QuickCocktail,
        AmbientCocktail
    }

    public class Cocktail
    {
        public ModalidadServicioCocktail Servicio { get; set; }
        public bool Ambientacion { get; set; }
        public bool MusicaAmbiental { get; set; }
        public string TipoAmbientacion { get; set; }

        public Cocktail(ModalidadServicioCocktail servicio, bool ambientacion, bool musicaAmbiental, string tipoAmbientacion)
        {
            Servicio = servicio;
            Ambientacion = ambientacion;
            MusicaAmbiental = musicaAmbiental;
            TipoAmbientacion = tipoAmbientacion;
        }
    }

}
