using OnBreak.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnBreak.BC
{

    public class Contrato 
    {

        public Contrato()
        {
            this.Init();
        }

        string _modalidadServicio;
        string _tipoEvento;

        public string Numero { get; set; }
        public System.DateTime Creacion { get; set; }
        public System.DateTime Termino { get; set; }
        public string RutCliente { get; set; }
        public string IdModalidad { get; set; }
        public int IdTipoEvento { get; set; }
        public System.DateTime FechaHoraInicio { get; set; }
        public System.DateTime FechaHoraTermino { get; set; }
        public int Asistentes { get; set; }
        public int PersonalAdicional { get; set; }
        public bool Realizado { get; set; }
        public double ValorTotalContrato { get; set; }
        public string Observaciones { get; set; }

        public virtual Cenas Cenas { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Cocktail Cocktail { get; set; }
        public virtual CoffeeBreak CoffeeBreak { get; set; }
        public virtual ModalidadServicio ModalidadServicio { get; set; }



        private void Init()
        {
            this.Numero = string.Empty;
            this.Creacion = DateTime.Now;
            this.Termino = DateTime.Now;
            this.RutCliente = string.Empty;
            this.IdModalidad = string.Empty;
            this.IdTipoEvento = 0;
            this.FechaHoraInicio = DateTime.Now;
            this.FechaHoraTermino = DateTime.Now;
            this.Asistentes = 0;
            this.PersonalAdicional = 0;
            this.Realizado = false;
            this.ValorTotalContrato = 0;
            this.Observaciones = string.Empty;
        }

        public bool Create()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bdd = new BD.OnBreakEntities();

            //Crear un objeto de tipo Cliente (el que se va a agregar)
            BD.Contrato objContrato = new BD.Contrato();
            try
            {

                    CommonBC.Syncronize(this, objContrato);

                    //Agregar el objeto
                    bdd.Contrato.Add(objContrato);

                    //Guardar los cambios
                    bdd.SaveChanges();

                    return true;
            }
            catch (Exception)
            {
                //Si hay un error, no se agrega
                bdd.Contrato.Remove(objContrato);
                return false;
            }
        }

        public bool Read()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bdd = new BD.OnBreakEntities();

            try
            {
                //Buscar el cliente que se quiere leer
                BD.Contrato objContrato = bdd.Contrato.First(c => c.RutCliente.Equals(this.RutCliente));

                    //Pasar los datos del objeto de Entity al objeto actual
                CommonBC.Syncronize(objContrato, this);

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bdd = new BD.OnBreakEntities();
            try
            {
                //busco por el id el contenido de la entidad a modificar
                BD.Contrato objContrato =
                    bdd.Contrato.First(e => e.RutCliente.Equals(this.RutCliente));
                CommonBC.Syncronize(this, Cliente);
                bdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool Delete()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bdd = new BD.OnBreakEntities();
            try
            {
                //busco por el id el contenido de la entidad a eliminar
                BD.Contrato objContrato =
                    bdd.Contrato.First(e => e.RutCliente.Equals(this.RutCliente));
                bdd.Contrato.Remove(objContrato);
                bdd.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void LeerNombreModalidad()
        {
            ModalidadServicio modalidadServicio = new ModalidadServicio() { IdModalidad = IdModalidad };

            if (modalidadServicio.Read())
            {
                _modalidadServicio = modalidadServicio.Nombre;
            }
            else
            {
                _modalidadServicio = string.Empty;

            }
        }

        public void LeerDescripcionEvento()
        {
            TipoEvento tipoEvento = new TipoEvento() { IdTipoEvento = IdTipoEvento };

            if (tipoEvento.Read())
            {
                _tipoEvento = tipoEvento.Descripcion;
            }
            else
            {
                _tipoEvento = string.Empty;

            }
        }


        public List<Contrato> ReadAll()
        {
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                List<BD.Contrato> listaDatos = bd.Contrato.ToList();
                List<Contrato> listaNegocio = GenerarListado(listaDatos);

                return listaNegocio;
            }
            catch (Exception)
            {
                return new List<Contrato>();
            }
        }

        private List<Contrato> GenerarListado(List<BD.Contrato> listaDatos)
        {
            List<Contrato> listaNegocio = new List<Contrato>();
            foreach (BD.Contrato datos in listaDatos)
            {
                Contrato negocio = new Contrato();
                CommonBC.Syncronize(datos, negocio);
                //rescatar la lectura de la Razon Social
                negocio.LeerDescripcionEvento();
                negocio.LeerNombreModalidad();
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }



    }



}
