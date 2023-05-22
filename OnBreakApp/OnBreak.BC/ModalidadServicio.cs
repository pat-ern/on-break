using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class ModalidadServicio
    {
        public ModalidadServicio()
        {
            this.Contrato = new HashSet<Contrato>();
        }

        public string IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public string Nombre { get; set; }
        public double ValorBase { get; set; }
        public int PersonalBase { get; set; }

        public virtual ICollection<Contrato> Contrato { get; set; }
        public virtual TipoEvento TipoEvento { get; set; }

    }



}
