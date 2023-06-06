using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{
    public class Cenas 
    {
        public string Numero { get; set; }
        public int IdTipoAmbientacion { get; set; }
        public bool MusicaAmbiental { get; set; }
        public bool LocalOnBreak { get; set; }
        public bool OtroLocalOnBreak { get; set; }
        public double ValorArriendo { get; set; }

        public virtual TipoAmbientacion TipoAmbientacion { get; set; }
        public virtual Contrato Contrato { get; set; }

        public void Init()
        {
            this.Numero = string.Empty;
            this.IdTipoAmbientacion = 0;
            this.MusicaAmbiental = false;
            this.LocalOnBreak = false;
            this.OtroLocalOnBreak = false;
            this.ValorArriendo = 0;
        }

        public bool Create()
        {
            // Crear una conexión a la entidad Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            BD.Cenas cena = new BD.Cenas();
            try
            {
                // Sincronizar el contenido de las propiedades con la BD
                CommonBC.Syncronize(this, cena);
                bd.Cenas.Add(cena);
                bd.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                bd.Cenas.Remove(cena);
                return false;
            }
        }

        public List<Cenas> ReadAll()
        {
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                // Crear objeto de tipo tabla con datos de la tabla
                List<BD.Cenas> listaDatos = bd.Cenas.ToList();
                List<Cenas> listaNegocio = GenerarListado(listaDatos);

                return listaNegocio;
            }
            catch (Exception)
            {
                return new List<Cenas>();
            }
        }

        private List<Cenas> GenerarListado(List<BD.Cenas> listaDatos)
        {
            List<Cenas> listaNegocio = new List<Cenas>();
            foreach (BD.Cenas datos in listaDatos)
            {
                Cenas negocio = new Cenas();
                CommonBC.Syncronize(datos, negocio);
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }

    }
}
