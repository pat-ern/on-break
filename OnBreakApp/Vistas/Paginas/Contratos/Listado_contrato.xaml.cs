using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vistas.Paginas.Contratos
{
    /// <summary>
    /// Lógica de interacción para Listado_contrato.xaml
    /// </summary>
    public partial class Listado_contrato
    {

        List<Contrato> contratos = new List<Contrato>();

        List<Cliente> customers = new List<Cliente>();

        ActividadEmpresa actEmp1 = new ActividadEmpresa() { IdActividadEmpresa = 1, Descripcion = "Prestamos y financiamiento" };
        ActividadEmpresa actEmp2 = new ActividadEmpresa() { IdActividadEmpresa = 2, Descripcion = "Produccion de alimentos" };
        ActividadEmpresa actEmp3 = new ActividadEmpresa() { IdActividadEmpresa = 3, Descripcion = "Logistica y cadena de suministros" };
        ActividadEmpresa actEmp4 = new ActividadEmpresa() { IdActividadEmpresa = 4, Descripcion = "Asesoramiento financiero" };
        ActividadEmpresa actEmp5 = new ActividadEmpresa() { IdActividadEmpresa = 5, Descripcion = "Marketing y publicidad" };

        TipoEmpresa tipEmp1 = new TipoEmpresa() { IdTipoEmpresa = 1, Descripcion = "Sociedad Anonima" };
        TipoEmpresa tipEmp2 = new TipoEmpresa() { IdTipoEmpresa = 2, Descripcion = "Sociedad Limitada" };
        TipoEmpresa tipEmp3 = new TipoEmpresa() { IdTipoEmpresa = 3, Descripcion = "Sociedad Anonima Cerrada" };
        TipoEmpresa tipEmp4 = new TipoEmpresa() { IdTipoEmpresa = 4, Descripcion = "Sociedad en Participacion" };
        TipoEmpresa tipEmp5 = new TipoEmpresa() { IdTipoEmpresa = 5, Descripcion = "Sociedad en Comandita" };

        public Listado_contrato()
        {
            InitializeComponent();

            // Lista de clientes
            Cliente cli01 = new Cliente { RutCliente = "16591230-K", RazonSocial = "Advance", NombreContacto = "Pedro Ramirez", MailContacto = "pramires@mail.com", Direccion = "Calle 1 Villa Las Americas", Telefono = "12345678", ActividadEmpresa = this.actEmp1, TipoEmpresa = this.tipEmp1 };
            Cliente cli02 = new Cliente { RutCliente = "12854638-7", RazonSocial = "Global Solutions", NombreContacto = "María González", MailContacto = "mgonzalez@mail.com", Direccion = "Av. Providencia 1234", Telefono = "22334455", ActividadEmpresa = this.actEmp2, TipoEmpresa = this.tipEmp2 };
            Cliente cli03 = new Cliente { RutCliente = "13678945-6", RazonSocial = "Innovatec", NombreContacto = "Luisa Rojas", MailContacto = "lrojas@mail.com", Direccion = "San Diego 456", Telefono = "99887766", ActividadEmpresa = this.actEmp3, TipoEmpresa = this.tipEmp3 };
            Cliente cli04 = new Cliente { RutCliente = "19876543-2", RazonSocial = "TechCorp", NombreContacto = "Manuel Díaz", MailContacto = "mdiaz@mail.com", Direccion = "Las Condes 789", Telefono = "77665544", ActividadEmpresa = this.actEmp4, TipoEmpresa = this.tipEmp4 };
            Cliente cli05 = new Cliente { RutCliente = "14123456-7", RazonSocial = "EcoGreen", NombreContacto = "Carla Vargas", MailContacto = "cvargas@mail.com", Direccion = "Maipú 321", Telefono = "11223344", ActividadEmpresa = this.actEmp5, TipoEmpresa = this.tipEmp5 };
            Cliente cli06 = new Cliente { RutCliente = "11567890-1", RazonSocial = "SoftTech", NombreContacto = "Javier Soto", MailContacto = "jsoto@mail.com", Direccion = "Providencia 567", Telefono = "33221100", ActividadEmpresa = this.actEmp1, TipoEmpresa = this.tipEmp1 };
            Cliente cli07 = new Cliente { RutCliente = "16789012-3", RazonSocial = "SmartSolutions", NombreContacto = "Ana López", MailContacto = "alopez@mail.com", Direccion = "La Reina 345", Telefono = "55443322", ActividadEmpresa = this.actEmp2, TipoEmpresa = this.tipEmp2 };
            Cliente cli08 = new Cliente { RutCliente = "13245678-9", RazonSocial = "FutureTech", NombreContacto = "Juan Torres", MailContacto = "jtorres@mail.com", Direccion = "Providencia 999", Telefono = "88990011", ActividadEmpresa = this.actEmp3, TipoEmpresa = this.tipEmp3 };
            Cliente cli09 = new Cliente { RutCliente = "14567890-2", RazonSocial = "Innovative Minds", NombreContacto = "Andrea Castro", MailContacto = "acastro@mail.com", Direccion = "Las Condes 456", Telefono = "22110033", ActividadEmpresa = this.actEmp4, TipoEmpresa = this.tipEmp4 };
            Cliente cli10 = new Cliente { RutCliente = "17654321-0", RazonSocial = "Creative Designs", NombreContacto = "Ricardo Fernández", MailContacto = "rfernandez@mail.com", Direccion = "Santiago Centro 789", Telefono = "66778899", ActividadEmpresa = this.actEmp5, TipoEmpresa = this.tipEmp5 };

            // Tipos de eventos
            TipoEvento coffeeBreak = new TipoEvento() { IdTipoEvento = 01, Descripcion = "Coffee Break" };
            TipoEvento cocktail = new TipoEvento() { IdTipoEvento = 02, Descripcion = "Cocktail" };
            TipoEvento cenas = new TipoEvento() { IdTipoEvento = 03, Descripcion = "Cenas" };

            // Modalidades de servicio
            ModalidadServicio lightBreak = new ModalidadServicio() { IdModalidad = "01LB", TipoEvento = coffeeBreak, Nombre = "Light Break", ValorBase = 3, PersonalBase = 2 };
            ModalidadServicio journalBreak = new ModalidadServicio() { IdModalidad = "02JB", TipoEvento = coffeeBreak, Nombre = "Journal Break", ValorBase = 8, PersonalBase = 6 };
            ModalidadServicio dayBreak = new ModalidadServicio() { IdModalidad = "03DB", TipoEvento = coffeeBreak, Nombre = "Day Break", ValorBase = 12, PersonalBase = 6 };

            // Agregamos contratos a la lista
            this.contratos.Add(new Contrato { Numero = "C01", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli01, ModalidadServicio = dayBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 100, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            this.contratos.Add(new Contrato { Numero = "C02", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli02, ModalidadServicio = journalBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 200, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            this.contratos.Add(new Contrato { Numero = "C03", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli03, ModalidadServicio = lightBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 300, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            this.contratos.Add(new Contrato { Numero = "C04", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli04, ModalidadServicio = dayBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 400, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            this.contratos.Add(new Contrato { Numero = "C05", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli05, ModalidadServicio = journalBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 500, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            this.contratos.Add(new Contrato { Numero = "C06", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli06, ModalidadServicio = lightBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 600, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            this.contratos.Add(new Contrato { Numero = "C07", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli07, ModalidadServicio = dayBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 700, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            this.contratos.Add(new Contrato { Numero = "C08", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli08, ModalidadServicio = journalBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 800, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            this.contratos.Add(new Contrato { Numero = "C09", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli09, ModalidadServicio = lightBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 900, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            this.contratos.Add(new Contrato { Numero = "C10", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli10, ModalidadServicio = dayBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 1000, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            this.contratos.Add(new Contrato { Numero = "C11", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = cli01, ModalidadServicio = journalBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 1100, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });

            this.miTabla.ItemsSource = this.contratos;

            string[] tipoEventoItems = new string[] { coffeeBreak.Descripcion, cocktail.Descripcion, cenas.Descripcion };
            filtroTipoEvento.ItemsSource = tipoEventoItems;

            string[] modalidadServicioItems = new string[] { lightBreak.Nombre, journalBreak.Nombre, dayBreak.Nombre };
            filtroModalidadServicio.ItemsSource = modalidadServicioItems;

        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }

        private void TextBoxRut_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textoBusqueda = txt_busquedaRut.Text;

            var resultadosRut = from c in contratos
                                where c.Cliente.RutCliente.Contains(textoBusqueda)
                                select c;

            this.miTabla.ItemsSource = resultadosRut.ToList();
        }

        private void TextBoxNroContrato_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textoBusqueda = txt_busquedaNroContrato.Text;

            var resultadosRut = from c in contratos
                                where c.Numero.Contains(textoBusqueda)
                                select c;

            this.miTabla.ItemsSource = resultadosRut.ToList();
        }

        private void TipoEvento_Click(object sender, RoutedEventArgs e)
        {

            var valorSeleccionado = ((MenuItem)sender).Header;

            var resultados = from c in contratos
                             where c.ModalidadServicio.TipoEvento.Descripcion.Equals((String)valorSeleccionado)
                             select c;

            this.miTabla.ItemsSource = resultados.ToList();

        }

        private void ModalidadServicio_Click(object sender, RoutedEventArgs e)
        {

            var valorSeleccionado = ((MenuItem)sender).Header;

            var resultados = from c in contratos
                             where c.ModalidadServicio.Nombre.Equals((String)valorSeleccionado)
                             select c;

            this.miTabla.ItemsSource = resultados.ToList();

        }

        private void miTabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // al apretar un dato de la tabla quiero que me lleve a otra ventana

            var contratoSeleccionado = miTabla.SelectedItem as Contrato;

            if (contratoSeleccionado != null)
            {
                var index = new Adm_contratos(contratoSeleccionado);
                this.Close();
                index.Show();
            }
        }

        private void Resetear(object sender, RoutedEventArgs e)
        {
            this.miTabla.ItemsSource = this.contratos;
        }

    }
}
