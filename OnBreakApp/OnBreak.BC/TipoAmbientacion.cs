using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class TipoAmbientacion
    {
        public TipoAmbientacion()
        {
            this.Cenas = new HashSet<Cenas>();
            this.Cocktail = new HashSet<Cocktail>();
        }

        public int IdTipoAmbientacion { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Cenas> Cenas { get; set; }
        public virtual ICollection<Cocktail> Cocktail { get; set; }
    }



}
