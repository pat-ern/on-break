using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Contrato
    {
        public string IdContrato { get; set; }
        public string RutCliente { get; set; } = string.Empty;
        public Cliente Cliente { get; set; } = new Cliente();

        private Cena cena;
        private Coffee coffee;
        private Cocktail cocktail;
        public Contrato()
        {
            // Generar número de contrato en base a la fecha y hora actual
            DateTime fechaHoraActual = DateTime.Now;
            string formatoNumeroContrato = "yyyyMMddHHmm";
            this.IdContrato = fechaHoraActual.ToString(formatoNumeroContrato);
        }
        public Contrato(Cena cena)
        {
            this.cena = cena;
        }

        public Contrato(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public Contrato(Cocktail cocktail)
        {
            this.cocktail = cocktail;
        }

        private void Init()
        {
            IdContrato = string.Empty;
            Cliente = new Cliente();

        }
    }

}
