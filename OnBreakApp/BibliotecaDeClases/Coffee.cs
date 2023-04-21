using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Coffee
    {
        public string Numero { get; set; }
        public bool Vegetariana { get; set; }

        public Coffee(string numero, bool vegetariana)
        {
            Numero = numero;
            Vegetariana = vegetariana;
        }

        public Coffee()
        {
            this.Init();
        }

        private void Init() 
        {
            Numero = string.Empty;
            Vegetariana = false;

        }


    }
}
