using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases
{
    public class Contrato 
    {
        public string Numero { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Termino { get; set; }
        public Cliente Cliente { get; set; }
        public ModalidadServicio ModalidadServicio { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraTermino { get; set; }
        public int Asistentes { get; set; }
        public int PersonalAdicional { get; set; }
        public bool Realizado { get; set; }
        public float ValorTotalContrato { get; set; }
        public string Observaciones { get; set; }


        public Contrato()
        {
            DateTime fechaHoraActual = DateTime.Now;
            string formatoNumeroContrato = "yyyyMMddHHmm";
            this.Numero = fechaHoraActual.ToString(formatoNumeroContrato);

            this.Init();
        }

        public Contrato(string numero, DateTime creacion, DateTime termino, Cliente cliente, ModalidadServicio modalidadServicio, DateTime fechaHoraInicio, DateTime fechaHoraTermino, int asistentes, int personalAdicional, bool realizado, float valorTotalContrato, string observaciones)
        {
            Numero = numero;
            Creacion = creacion;
            Termino = termino;
            Cliente = cliente;
            ModalidadServicio = modalidadServicio;
            FechaHoraInicio = fechaHoraInicio;
            FechaHoraTermino = fechaHoraTermino;
            Asistentes = asistentes;
            PersonalAdicional = personalAdicional;
            Realizado = realizado;
            ValorTotalContrato = valorTotalContrato;
            Observaciones = observaciones;
        }  

        private void Init()
        {
            Creacion = DateTime.Now;
            Termino = DateTime.Now;
            Cliente = new Cliente();
            ModalidadServicio = new ModalidadServicio();
            FechaHoraInicio = DateTime.Now;
            FechaHoraTermino = DateTime.Now;
            Asistentes = 0;
            PersonalAdicional = 0;
            Realizado = false;
            ValorTotalContrato = 0;
            Observaciones = string.Empty;


        }


    }

}
