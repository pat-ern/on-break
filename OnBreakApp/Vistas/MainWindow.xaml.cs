using ControlzEx.Theming;
using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vistas.Paginas.Clientes;
using Vistas.Paginas.Contratos;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {

        //List<Cliente> clientes = new List<Cliente>();

        //List<Contrato> contratos = new List<Contrato>();

        //ActividadEmpresa actEmp1 = new ActividadEmpresa() { IdActividadEmpresa = 1, Descripcion = "Prestamos y financiamiento" };
        //ActividadEmpresa actEmp2 = new ActividadEmpresa() { IdActividadEmpresa = 2, Descripcion = "Produccion de alimentos" };
        //ActividadEmpresa actEmp3 = new ActividadEmpresa() { IdActividadEmpresa = 3, Descripcion = "Logistica y cadena de suministros" };
        //ActividadEmpresa actEmp4 = new ActividadEmpresa() { IdActividadEmpresa = 4, Descripcion = "Asesoramiento financiero" };
        //ActividadEmpresa actEmp5 = new ActividadEmpresa() { IdActividadEmpresa = 5, Descripcion = "Marketing y publicidad" };

        //TipoEmpresa tipEmp1 = new TipoEmpresa() { IdTipoEmpresa = 1, Descripcion = "Sociedad Anonima" };
        //TipoEmpresa tipEmp2 = new TipoEmpresa() { IdTipoEmpresa = 2, Descripcion = "Sociedad Limitada" };
        //TipoEmpresa tipEmp3 = new TipoEmpresa() { IdTipoEmpresa = 3, Descripcion = "Sociedad Anonima Cerrada" };
        //TipoEmpresa tipEmp4 = new TipoEmpresa() { IdTipoEmpresa = 4, Descripcion = "Sociedad en Participacion" };
        //TipoEmpresa tipEmp5 = new TipoEmpresa() { IdTipoEmpresa = 5, Descripcion = "Sociedad en Comandita" };

        //// Tipos de eventos
        //TipoEvento coffeeBreak = new TipoEvento() { IdTipoEvento = 01, Descripcion = "Coffee Break" };
        //TipoEvento cocktail = new TipoEvento() { IdTipoEvento = 02, Descripcion = "Cocktail" };
        //TipoEvento cenas = new TipoEvento() { IdTipoEvento = 03, Descripcion = "Cenas" };





        public MainWindow()
        {
            InitializeComponent();


            // Modalidades de servicio
            //ModalidadServicio lightBreak = new ModalidadServicio() { IdModalidad = "01LB", TipoEvento = coffeeBreak, Nombre = "Light Break", ValorBase = 3, PersonalBase = 2 };
            //ModalidadServicio journalBreak = new ModalidadServicio() { IdModalidad = "02JB", TipoEvento = coffeeBreak, Nombre = "Journal Break", ValorBase = 8, PersonalBase = 6 };
            //ModalidadServicio dayBreak = new ModalidadServicio() { IdModalidad = "03DB", TipoEvento = coffeeBreak, Nombre = "Day Break", ValorBase = 12, PersonalBase = 6 };

            //this.clientes.Add(new Cliente { RutCliente = "16591230", RazonSocial = "Advance", NombreContacto = "Pedro Ramirez", MailContacto = "pramires@mail.com", Direccion = "Calle 1 Villa Las Americas", Telefono = "12345678", ActividadEmpresa = this.actEmp1, TipoEmpresa = this.tipEmp1 });
            //this.clientes.Add(new Cliente { RutCliente = "12854638", RazonSocial = "Global Solutions", NombreContacto = "María González", MailContacto = "mgonzalez@mail.com", Direccion = "Av. Providencia 1234", Telefono = "22334455", ActividadEmpresa = this.actEmp2, TipoEmpresa = this.tipEmp2 });
            //this.clientes.Add(new Cliente { RutCliente = "13678945", RazonSocial = "Innovatec", NombreContacto = "Luisa Rojas", MailContacto = "lrojas@mail.com", Direccion = "San Diego 456", Telefono = "99887766", ActividadEmpresa = this.actEmp3, TipoEmpresa = this.tipEmp3 });
            //this.clientes.Add(new Cliente { RutCliente = "19876543", RazonSocial = "TechCorp", NombreContacto = "Manuel Díaz", MailContacto = "mdiaz@mail.com", Direccion = "Las Condes 789", Telefono = "77665544", ActividadEmpresa = this.actEmp4, TipoEmpresa = this.tipEmp4 });
            //this.clientes.Add(new Cliente { RutCliente = "14123456", RazonSocial = "EcoGreen", NombreContacto = "Carla Vargas", MailContacto = "cvargas@mail.com", Direccion = "Maipú 321", Telefono = "11223344", ActividadEmpresa = this.actEmp5, TipoEmpresa = this.tipEmp5 });
            //this.clientes.Add(new Cliente { RutCliente = "11567890", RazonSocial = "SoftTech", NombreContacto = "Javier Soto", MailContacto = "jsoto@mail.com", Direccion = "Providencia 567", Telefono = "33221100", ActividadEmpresa = this.actEmp1, TipoEmpresa = this.tipEmp1 });
            //this.clientes.Add(new Cliente { RutCliente = "16789012", RazonSocial = "SmartSolutions", NombreContacto = "Ana López", MailContacto = "alopez@mail.com", Direccion = "La Reina 345", Telefono = "55443322", ActividadEmpresa = this.actEmp2, TipoEmpresa = this.tipEmp2 });
            //this.clientes.Add(new Cliente { RutCliente = "13245678", RazonSocial = "FutureTech", NombreContacto = "Juan Torres", MailContacto = "jtorres@mail.com", Direccion = "Providencia 999", Telefono = "88990011", ActividadEmpresa = this.actEmp3, TipoEmpresa = this.tipEmp3 });
            //this.clientes.Add(new Cliente { RutCliente = "14567890", RazonSocial = "Innovative Minds", NombreContacto = "Andrea Castro", MailContacto = "acastro@mail.com", Direccion = "Las Condes 456", Telefono = "22110033", ActividadEmpresa = this.actEmp4, TipoEmpresa = this.tipEmp4 });
            //this.clientes.Add(new Cliente { RutCliente = "17654321", RazonSocial = "Creative Designs", NombreContacto = "Ricardo Fernández", MailContacto = "rfernandez@mail.com", Direccion = "Santiago Centro 789", Telefono = "66778899", ActividadEmpresa = this.actEmp5, TipoEmpresa = this.tipEmp5 });

            //this.contratos.Add(new Contrato { Numero = "C01", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = this.clientes[0], ModalidadServicio = dayBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 100, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            //this.contratos.Add(new Contrato { Numero = "C02", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = this.clientes[1], ModalidadServicio = journalBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 200, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            //this.contratos.Add(new Contrato { Numero = "C03", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = this.clientes[2], ModalidadServicio = lightBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 300, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            //this.contratos.Add(new Contrato { Numero = "C04", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = this.clientes[3], ModalidadServicio = dayBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 400, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            //this.contratos.Add(new Contrato { Numero = "C05", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = this.clientes[4], ModalidadServicio = journalBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 500, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            //this.contratos.Add(new Contrato { Numero = "C06", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = this.clientes[5], ModalidadServicio = lightBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 600, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            //this.contratos.Add(new Contrato { Numero = "C07", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = this.clientes[6], ModalidadServicio = dayBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 700, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            //this.contratos.Add(new Contrato { Numero = "C08", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = this.clientes[7], ModalidadServicio = journalBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 800, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            //this.contratos.Add(new Contrato { Numero = "C09", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = this.clientes[8], ModalidadServicio = lightBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 900, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
            //this.contratos.Add(new Contrato { Numero = "C10", Creacion = DateTime.Now, Termino = DateTime.Now, Cliente = this.clientes[9], ModalidadServicio = dayBreak, FechaHoraInicio = DateTime.Now, FechaHoraTermino = DateTime.Now, Asistentes = 1000, PersonalAdicional = 0, Realizado = false, ValorTotalContrato = 0, Observaciones = "Ninguna" });
        }
        private void btn_adm_cliente_Click(object sender, RoutedEventArgs e)
        {
            // ABRIR LA VISTA DE ADMINISTRACION DE CLIENTES
            AdminClientes adminClientes = new AdminClientes();
            AbrirVentanaHija(adminClientes);
        }

        private void AbrirVentanaHija(MetroWindow ventanaHija)
        {
            this.Close();
            ventanaHija.Show();

        }

        // IR A PAGINA DE CREAR CLIENTES
        private void btn_cliente_Click(object sender, RoutedEventArgs e)
        {
            // ABRIR LA VISTA DE LISTA DE CLIENTES
            ListaClientes lista = new ListaClientes();
            AbrirVentanaHija(lista);

        }

        // IR A PAGINA DE CREAR CONTRATOS
        private void btn_crear_contratos_Click(object sender, RoutedEventArgs e)
        {
   
            AdminContratos adminContratos = new AdminContratos();
            AbrirVentanaHija(adminContratos);
        }
        private void btn_contratos_Click(object sender, RoutedEventArgs e)
        {
            ListaContratos listado = new ListaContratos();
            AbrirVentanaHija(listado);
        }

        private void btn_contraste_Click(object sender, RoutedEventArgs e)
        {
            if ((string)btn_contraste.Tag == "false")
            {
                btn_contraste.Tag = "true";
                grid.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#34274D"));
                lbl_adm_cliente.Foreground = lbl_adm_contratos.Foreground = lbl_cliente.Foreground = lbl_contratos.Foreground = Brushes.White;
                btn_adm_cliente.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2186C2"));
                btn_adm_contratos.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7F55D4"));
                btn_contratos.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A145BB"));
                btn_cliente.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3959E8"));
                btn_contraste.FontWeight = btn_adm_cliente.FontWeight = btn_adm_contratos.FontWeight = btn_contratos.FontWeight = btn_cliente.FontWeight = FontWeights.DemiBold;
            }
            else
            {
                btn_contraste.Tag = "false";
                grid.Background = Brushes.Black;
                lbl_adm_cliente.Foreground = lbl_adm_contratos.Foreground = lbl_cliente.Foreground = lbl_contratos.Foreground = Brushes.Black;
                btn_adm_cliente.Background = btn_adm_contratos.Background = btn_contratos.Background = btn_cliente.Background = Brushes.White;
                btn_adm_cliente.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2186C2"));
                btn_adm_contratos.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#7F55D4"));
                btn_contratos.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A145BB"));
                btn_cliente.BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3959E8"));
                btn_contraste.BorderThickness = btn_adm_cliente.BorderThickness = btn_adm_contratos.BorderThickness = btn_contratos.BorderThickness = btn_cliente.BorderThickness = new Thickness(5);
                btn_contraste.FontWeight = btn_adm_cliente.FontWeight = btn_adm_contratos.FontWeight = btn_contratos.FontWeight = btn_cliente.FontWeight = FontWeights.Bold;
            }
        }

        private void btn_adm_contratos_Click(object sender, RoutedEventArgs e)
        {
            AdminContratos adminContratos = new AdminContratos();
            AbrirVentanaHija(adminContratos);

        }
    }
}
