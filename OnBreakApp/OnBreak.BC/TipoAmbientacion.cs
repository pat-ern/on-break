using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class TipoAmbientacion
    {
        public TipoAmbientacion()
        {
            this.Cenas = new HashSet<Cenas>();
            this.Cocktail = new HashSet<Cocktail>();

            this.Init();
        }

        public int IdTipoAmbientacion { get; set; }
        public string Descripcion { get; set; }
        public virtual ICollection<Cenas> Cenas { get; set; }
        public virtual ICollection<Cocktail> Cocktail { get; set; }


        private void Init()
        {
            IdTipoAmbientacion = 0;
            Descripcion = string.Empty;
        }


        public bool Read()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //busco por el id el contenido de la entidad
                BD.TipoAmbientacion tipoAmbientacion =
                    bd.TipoAmbientacion.First(e => e.IdTipoAmbientacion.Equals(this.IdTipoAmbientacion));
                CommonBC.Syncronize(tipoAmbientacion, this);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TipoAmbientacion> ReadAll()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //Crear una lista de DATOS
                List<BD.TipoAmbientacion> listaDatos = bd.TipoAmbientacion.ToList();
                //Crear una lista de NEGOCIO
                List<TipoAmbientacion> listaNegocio = GenerarListado(listaDatos);
                return listaNegocio;
            }
            catch (Exception)
            {
                return new List<TipoAmbientacion>();
            }
        }

        private List<TipoAmbientacion> GenerarListado(List<BD.TipoAmbientacion> listaDatos)
        {
            List<TipoAmbientacion> listaNegocio = new List<TipoAmbientacion>();
            foreach (BD.TipoAmbientacion datos in listaDatos)
            {
                TipoAmbientacion negocio = new TipoAmbientacion();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }

    }



}
