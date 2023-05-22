using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class TipoEmpresa
    {
        public TipoEmpresa()
        {
            this.Cliente = new HashSet<Cliente>();
            this.Init();
        }

        public int IdTipoEmpresa { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Cliente> Cliente { get; set; }

        private void Init()
        {
            this.IdTipoEmpresa = 0;
            this.Descripcion = string.Empty;
        }

        public bool Read()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //busco por el id el contenido de la entidad
                BD.TipoEmpresa actEmpresa =
                    bd.TipoEmpresa.First(e => e.IdTipoEmpresa.Equals(this.IdTipoEmpresa));
                CommonBC.Syncronize(actEmpresa, this);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TipoEmpresa> ReadAll()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //Crear una lista de DATOS
                List<BD.TipoEmpresa> listaDatos = bd.TipoEmpresa.ToList();
                //Crear una lista de NEGOCIO
                List<TipoEmpresa> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception)
            {
                return new List<TipoEmpresa>();
            }
        }

        private List<TipoEmpresa> GenerarListado(List<BD.TipoEmpresa> listaDatos)
        {
            List<TipoEmpresa> listaNegocio = new List<TipoEmpresa>();
            foreach (BD.TipoEmpresa datos in listaDatos)
            {
                TipoEmpresa negocio = new TipoEmpresa();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }
    }

}
