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
            this.Init();
            this.ModalidadServicio = new HashSet<ModalidadServicio>();
        }

        public int IdTipoEvento { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<ModalidadServicio> ModalidadServicio { get; set; }


        private void Init()
        {
            this.IdTipoEvento = 0;
            this.Descripcion = string.Empty;
        }


        public bool Read()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //busco por el id el contenido de la entidad
                BD.TipoEvento tipoEvento =
                    bd.TipoEvento.First(e => e.IdTipoEvento.Equals(this.IdTipoEvento));
                CommonBC.Syncronize(tipoEvento, this);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TipoEvento> ReadAll()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //Crear una lista de DATOS
                List<BD.TipoEvento> listaDatos = bd.TipoEvento.ToList();
                //Crear una lista de NEGOCIO
                List<TipoEvento> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception)
            {
                return new List<TipoEvento>();
            }
        }

        private List<TipoEvento> GenerarListado(List<BD.TipoEvento> listaDatos)
        {
            List<TipoEvento> listaNegocio = new List<TipoEvento>();
            foreach (BD.TipoEvento datos in listaDatos)
            {
                TipoEvento negocio = new TipoEvento();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }

    }



}
