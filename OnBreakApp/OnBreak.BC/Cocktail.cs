using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class Cocktail
    {

        public Cocktail()
        {
            this.Init();
        }
        public string Numero { get; set; }
        public int IdTipoAmbientacion { get; set; }
        public bool Ambientacion { get; set; }
        public bool MusicaAmbiental { get; set; }
        public bool MusicaCliente { get; set; }

        public virtual TipoAmbientacion TipoAmbientacion { get; set; }
        public virtual Contrato Contrato { get; set; }

        private void Init()
        {
            this.Numero = string.Empty;
            this.IdTipoAmbientacion = 0;
            this.Ambientacion = false;
            this.MusicaAmbiental = false;
            this.MusicaCliente = false;
        }

        public bool Create()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            BD.Cocktail cocktail = new BD.Cocktail();
            try
            {
                //sincronizo el contenido de las propiedades a la BD
                CommonBC.Syncronize(this, cocktail);
                bd.Cocktail.Add(cocktail);
                bd.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                bd.Cocktail.Remove(cocktail);
                return false;
            }
        }

        public List<Cocktail> ReadAll()
        {
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                //Crear objeto de tipo tabla con datos de la tabla
                List<BD.Cocktail> listaDatos = bd.Cocktail.ToList();
                List<Cocktail> listaNegocio = GenerarListado(listaDatos);

                return listaNegocio;
            }
            catch (Exception)
            {
                return new List<Cocktail>();
            }
        }


        private List<Cocktail> GenerarListado(List<BD.Cocktail> listaDatos)
        {
            List<Cocktail> listaNegocio = new List<Cocktail>();
            foreach (BD.Cocktail datos in listaDatos)
            {
                Cocktail negocio = new Cocktail();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }




    }

}
