using BibliotecaDeClases;
using ControlzEx.Theming;
using MahApps.Metro.Controls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Vistas.Paginas.Clientes;

namespace Vistas
{
    public partial class MainWindow : MetroWindow
    {

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
        public MainWindow()
        {
            InitializeComponent();

            List<Cliente> customers = new List<Cliente>();

            this.customers.Add(new Cliente { RutCliente = "16591230-K", RazonSocial = "Advance", NombreContacto = "Pedro Ramirez", MailContacto = "pramires@mail.com", Direccion = "Calle 1 Villa Las Americas", Telefono = "12345678", ActividadEmpresa = this.actEmp1, TipoEmpresa = this.tipEmp1 });
            this.customers.Add(new Cliente { RutCliente = "12854638-7", RazonSocial = "Global Solutions", NombreContacto = "María González", MailContacto = "mgonzalez@mail.com", Direccion = "Av. Providencia 1234", Telefono = "22334455", ActividadEmpresa = this.actEmp2, TipoEmpresa = this.tipEmp2 });
            this.customers.Add(new Cliente { RutCliente = "13678945-6", RazonSocial = "Innovatec", NombreContacto = "Luisa Rojas", MailContacto = "lrojas@mail.com", Direccion = "San Diego 456", Telefono = "99887766", ActividadEmpresa = this.actEmp3, TipoEmpresa = this.tipEmp3 });
            this.customers.Add(new Cliente { RutCliente = "19876543-2", RazonSocial = "TechCorp", NombreContacto = "Manuel Díaz", MailContacto = "mdiaz@mail.com", Direccion = "Las Condes 789", Telefono = "77665544", ActividadEmpresa = this.actEmp4, TipoEmpresa = this.tipEmp4 });
            this.customers.Add(new Cliente { RutCliente = "14123456-7", RazonSocial = "EcoGreen", NombreContacto = "Carla Vargas", MailContacto = "cvargas@mail.com", Direccion = "Maipú 321", Telefono = "11223344", ActividadEmpresa = this.actEmp5, TipoEmpresa = this.tipEmp5 });
            this.customers.Add(new Cliente { RutCliente = "11567890-1", RazonSocial = "SoftTech", NombreContacto = "Javier Soto", MailContacto = "jsoto@mail.com", Direccion = "Providencia 567", Telefono = "33221100", ActividadEmpresa = this.actEmp1, TipoEmpresa = this.tipEmp1 });
            this.customers.Add(new Cliente { RutCliente = "16789012-3", RazonSocial = "SmartSolutions", NombreContacto = "Ana López", MailContacto = "alopez@mail.com", Direccion = "La Reina 345", Telefono = "55443322", ActividadEmpresa = this.actEmp2, TipoEmpresa = this.tipEmp2 });
            this.customers.Add(new Cliente { RutCliente = "13245678-9", RazonSocial = "FutureTech", NombreContacto = "Juan Torres", MailContacto = "jtorres@mail.com", Direccion = "Providencia 999", Telefono = "88990011", ActividadEmpresa = this.actEmp3, TipoEmpresa = this.tipEmp3 });
            this.customers.Add(new Cliente { RutCliente = "14567890-2", RazonSocial = "Innovative Minds", NombreContacto = "Andrea Castro", MailContacto = "acastro@mail.com", Direccion = "Las Condes 456", Telefono = "22110033", ActividadEmpresa = this.actEmp4, TipoEmpresa = this.tipEmp4 });
            this.customers.Add(new Cliente { RutCliente = "17654321-0", RazonSocial = "Creative Designs", NombreContacto = "Ricardo Fernández", MailContacto = "rfernandez@mail.com", Direccion = "Santiago Centro 789", Telefono = "66778899", ActividadEmpresa = this.actEmp5, TipoEmpresa = this.tipEmp5 });

            //this.miTabla.ItemsSource = this.customers;

            string[] tipoEmpresaItems = new string[] { this.tipEmp1.Descripcion, this.tipEmp2.Descripcion, this.tipEmp3.Descripcion, this.tipEmp4.Descripcion, this.tipEmp5.Descripcion };

            //filtroTipoEmpresa.ItemsSource = tipoEmpresaItems;

            string[] actividadEmpresaItems = new string[] { this.actEmp1.Descripcion, this.actEmp2.Descripcion, this.actEmp3.Descripcion, this.actEmp4.Descripcion, this.actEmp5.Descripcion };

            //filtroActividadEmpresa.ItemsSource = actividadEmpresaItems;
        }

        private void btn_contraste_Click(object sender, RoutedEventArgs e)
        {
            //HACER UN CAMBIO EN EL CONTRASTE
            if ((string)btn_contraste.Tag == "false")
            {
                btn_contraste.Tag = "true";
                Background = Brushes.White;
                Foreground = Brushes.Black;
                btn_contraste.Background = Brushes.White;
                btn_adm_cliente.Background = Brushes.Beige;
                btn_adm_contratos.Background = Brushes.Coral;
                btn_contratos.Background = Brushes.CornflowerBlue;
                btn_cliente.Background = Brushes.Cyan;
                btn_contraste.Foreground = Brushes.Black;
                btn_contraste.FontSize = btn_adm_cliente.FontSize = btn_adm_contratos.FontSize = btn_contratos.FontSize = btn_cliente.FontSize = 18;
                btn_contraste.FontWeight = btn_adm_cliente.FontWeight = btn_adm_contratos.FontWeight = btn_contratos.FontWeight = btn_cliente.FontWeight = FontWeights.DemiBold;
            }
            else
            {
                btn_contraste.Tag = "false";
                Background = Brushes.Black;
                btn_adm_cliente.Background = btn_adm_contratos.Background = btn_contratos.Background = btn_cliente.Background = Brushes.White;
                btn_contraste.Background = Brushes.White;
                btn_contraste.FontSize = btn_adm_cliente.FontSize = btn_adm_contratos.FontSize = btn_contratos.FontSize = btn_cliente.FontSize = 22;
                btn_contraste.FontWeight = btn_adm_cliente.FontWeight = btn_adm_contratos.FontWeight = btn_contratos.FontWeight = btn_cliente.FontWeight = FontWeights.Bold;
            }
            //}
            //}
            //}
            //}
            //}
        }

        private void btn_adm_cliente_Click(object sender, RoutedEventArgs e)
        {
            // ABRIR LA VISTA DE ADMINISTRACION DE CLIENTES


            Paginas.Clientes.Index index = new Paginas.Clientes.Index();
            this.Close();
            index.Show();
        }

        private void btn_cliente_Click(object sender, RoutedEventArgs e)
        {

            Lista listaClientes = new Lista(this.customers);
            this.Close();
            listaClientes.Show();

        }

        private void btn_adm_contratos_Click(object sender, RoutedEventArgs e)
        {
  
            Paginas.Contratos.Contratar contratar = new Paginas.Contratos.Contratar();
            this.Close();
            contratar.Show();
        }

        private void btn_contratos_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
