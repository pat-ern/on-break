using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnBreak.BD;

namespace OnBreak.BC
{
    public class Cliente
    {
        public Cliente()
        {
            this.Init();
            this.Contrato = new HashSet<Contrato>();
        }
        string _descripcionActividadEmpresa;
        string _descripcionTipoEmpresa;

        public string RutCliente { get; set; }
        public string RazonSocial { get; set; }
        public string NombreContacto { get; set; }
        public string MailContacto { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int IdActividadEmpresa { get; set; }
        public int IdTipoEmpresa { get; set; }

        public string DescripcionActividadEmpresa { get => _descripcionActividadEmpresa; }
        public string DescripcionTipoEmpresa { get => _descripcionTipoEmpresa; }

        public virtual ActividadEmpresa ActividadEmpresa { get; set; }
        public virtual TipoEmpresa TipoEmpresa { get; set; }
        public virtual ICollection<Contrato> Contrato { get; set; }


        private void Init()
        {
            this.RutCliente = string.Empty;
            this.RazonSocial = string.Empty;
            this.NombreContacto = string.Empty;
            this.MailContacto = string.Empty;
            this.Direccion = string.Empty;
            this.Telefono = string.Empty;
            this.IdActividadEmpresa = 0;
            this.IdTipoEmpresa = 0;

        }

        public bool Create()
        {
            //Crear una conexión al Entities
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            BD.Cliente Cliente = new BD.Cliente();
            try
            {
                //sincronizo el contenido de las propiedades a la BD
                CommonBC.Syncronize(this, Cliente);
                bd.Cliente.Add(Cliente);
                bd.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                bd.Cliente.Remove(Cliente);
                return false;
            }
        }

        public bool Read()
        {
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                BD.Cliente Cliente = bd.Cliente.First(c => c.RutCliente.Equals(this.RutCliente));
                //sincronizo el contenido de las propiedades a la BD
                CommonBC.Syncronize(Cliente, this);
                LeerDescripcionActividadEmpresa();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public void LeerDescripcionActividadEmpresa()
        {
            ActividadEmpresa actEmpresa = new ActividadEmpresa() { IdActividadEmpresa = IdActividadEmpresa };

            if (actEmpresa.Read()) 
            {
                _descripcionActividadEmpresa = actEmpresa.Descripcion;
            }else
            {
                _descripcionActividadEmpresa = string.Empty;

            }
        }

        public void LeerDescripcionTipoEmpresa()
        {
            TipoEmpresa tipoEmpresa = new TipoEmpresa() { IdTipoEmpresa = IdTipoEmpresa };

            if (tipoEmpresa.Read())
            {
                _descripcionTipoEmpresa = tipoEmpresa.Descripcion;
            }
            else
            {
                _descripcionTipoEmpresa = string.Empty;

            }
        }

        public List<Cliente> ReadAll ()
        {
            BD.OnBreakEntities bd = new BD.OnBreakEntities();
            try
            {
                List<BD.Cliente> listaDatos = bd.Cliente.ToList();
                List<Cliente> listaNegocio = GenerarListado(listaDatos);

                return listaNegocio;
            }
            catch (Exception)
            {
                return new List<Cliente>();
            }
        }

        private List<Cliente> GenerarListado(List<BD.Cliente> listaDatos)
        {
            List<Cliente> listaNegocio = new List<Cliente>();
            foreach (BD.Cliente datos in listaDatos)
            {
                Cliente negocio = new Cliente();
                CommonBC.Syncronize(datos, negocio);
                //rescatar la lectura de la Razon Social
                negocio.LeerDescripcionActividadEmpresa();
                listaNegocio.Add(negocio);
            }
            return listaNegocio;
        }




    }
   
}
