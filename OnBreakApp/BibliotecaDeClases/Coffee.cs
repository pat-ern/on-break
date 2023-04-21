using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public enum ModalidadServicioCoffee
    {
        LightBreak,
        JournalBreak,
        DayBreak
    }
    public class Coffee
    {
        public ModalidadServicioCoffee Servicio { get; set; }
        public bool AlimentacionVegetariana { get; set; }

        public Coffee(ModalidadServicioCoffee servicio, bool alimentacionVegetariana)
        {
            Servicio = servicio;
            AlimentacionVegetariana = alimentacionVegetariana;
        }
    }
}
