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

            this.Init();
        }

        public string IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public string Nombre { get; set; }
        public double ValorBase { get; set; }
        public int PersonalBase { get; set; }

        public virtual ICollection<Contrato> Contrato { get; set; }
        public virtual TipoEvento TipoEvento { get; set; }


        private void Init()
        {
            this.IdModalidad = string.Empty;
            this.IdTipoEvento = 0;
            this.Nombre = string.Empty;
            this.ValorBase = 0;
            this.PersonalBase = 0;
        }

        public bool Read()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //busco por el id el contenido de la entidad
                BD.ModalidadServicio modalidadServicio =
                    bd.ModalidadServicio.First(e => e.IdModalidad.Equals(this.IdModalidad));
                CommonBC.Syncronize(modalidadServicio, this);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ModalidadServicio> ReadAll()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //Crear una lista de DATOS
                List<BD.ModalidadServicio> listaDatos = bd.ModalidadServicio.ToList();
                //Crear una lista de NEGOCIO
                List<ModalidadServicio> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception)
            {
                return new List<ModalidadServicio>();
            }
        }

        private List<ModalidadServicio> GenerarListado(List<BD.ModalidadServicio> listaDatos)
        {
            List<ModalidadServicio> listaNegocio = new List<ModalidadServicio>();
            foreach (BD.ModalidadServicio datos in listaDatos)
            {
                ModalidadServicio negocio = new ModalidadServicio();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }

    }



}
