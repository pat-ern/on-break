using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class CoffeeBreak
    {
        public string Numero { get; set; }
        public bool Vegetariana { get; set; }

        public virtual Contrato Contrato { get; set; }


    }
}
