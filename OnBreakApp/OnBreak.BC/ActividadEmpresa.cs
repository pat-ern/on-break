using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class ActividadEmpresa
    {
        public ActividadEmpresa()
        {
            this.Cliente = new HashSet<Cliente>();
            this.Init();
        }

        public int IdActividadEmpresa { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }


        private void Init()
        {
            this.IdActividadEmpresa = 0;
            this.Descripcion = string.Empty;
        }

        public bool Read()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //busco por el id el contenido de la entidad
                BD.ActividadEmpresa actEmpresa =
                    bd.ActividadEmpresa.First(e => e.IdActividadEmpresa.Equals(this.IdActividadEmpresa));
                CommonBC.Syncronize(actEmpresa, this);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ActividadEmpresa> ReadAll()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //Crear una lista de DATOS
                List<BD.ActividadEmpresa> listaDatos = bd.ActividadEmpresa.ToList();
                //Crear una lista de NEGOCIO
                List<ActividadEmpresa> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception)
            {
                return new List<ActividadEmpresa>();
            }
        }

        private List<ActividadEmpresa> GenerarListado(List<BD.ActividadEmpresa> listaDatos)
        {
            List<ActividadEmpresa> listaNegocio = new List<ActividadEmpresa>();
            foreach (BD.ActividadEmpresa datos in listaDatos)
            {
                ActividadEmpresa negocio = new ActividadEmpresa();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }
    }


}


