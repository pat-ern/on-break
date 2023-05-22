using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class TipoEvento
    {
        public TipoEvento()
        {
            this.ModalidadServicio = new HashSet<ModalidadServicio>();
        }

        public int IdTipoEvento { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ModalidadServicio> ModalidadServicio { get; set; }

    }



}
