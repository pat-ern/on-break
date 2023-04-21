using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    //
    public class ActividadEmpresa
    {
        public int IdActividadEmpresa { get; set; }
        public string Descripcion { get; set; }

        public ActividadEmpresa()
        {
            this.Init();
        }

        private void Init()
        {
            IdActividadEmpresa = 0;
            Descripcion = string.Empty;
        }


    }






}
