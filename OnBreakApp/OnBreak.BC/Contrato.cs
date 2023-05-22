using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class Contrato 
    {

        public string Numero { get; set; }
        public System.DateTime Creacion { get; set; }
        public System.DateTime Termino { get; set; }
        public string RutCliente { get; set; }
        public string IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public System.DateTime FechaHoraInicio { get; set; }
        public System.DateTime FechaHoraTermino { get; set; }
        public int Asistentes { get; set; }
        public int PersonalAdicional { get; set; }
        public bool Realizado { get; set; }
        public double ValorTotalContrato { get; set; }
        public string Observaciones { get; set; }

        public virtual Cenas Cenas { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Cocktail Cocktail { get; set; }
        public virtual CoffeeBreak CoffeeBreak { get; set; }
        public virtual ModalidadServicio ModalidadServicio { get; set; }



    }

}
