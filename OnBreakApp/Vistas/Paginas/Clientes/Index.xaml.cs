using BibliotecaDeClases;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
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

namespace Vistas.Paginas.Clientes
{
    /// <summary>
    /// Lógica de interacción para Index.xaml
    /// </summary>
    public partial class Index 
    {
        public Index(Cliente cliente)
        {
            InitializeComponent();
            //var customers = new List<Cliente>();
            //customers.Add(cliente);
            //miTabla.ItemsSource = customers;
            //miTabla.Visibility = Visibility.Visible;
        }
        private void btn_listado_Click(object sender, RoutedEventArgs e)
        {
           Paginas.Clientes.Lista lista = new Lista();
            this.Close();
            lista.Show();
        }

        private void btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Clientes.Agregar agregar = new Agregar();
            this.Close();
            agregar.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
        //private async void btn_Buscar_Click(object sender, RoutedEventArgs e)
        //{     
        //    List <Cliente> customers = new List<Cliente>();
        //    customers.Add(new Cliente { RutCliente = "16591230", RazonSocial = "Advance", NombreContacto = "Pedro Ramirez", MailContacto = "pramires@mail.com", Direccion = "Calle 1 Villa Las Americas", Telefono = "12345678", TipoEmpresa = new TipoEmpresa() });
        //    customers.Add(new Cliente { RutCliente = "12854638", RazonSocial = "Global Solutions", NombreContacto = "María González", MailContacto = "mgonzalez@mail.com", Direccion = "Av. Providencia 1234", Telefono = "22334455", TipoEmpresa = new TipoEmpresa() });
        //    customers.Add(new Cliente { RutCliente = "13678945", RazonSocial = "Innovatec", NombreContacto = "Luisa Rojas", MailContacto = "lrojas@mail.com", Direccion = "San Diego 456", Telefono = "99887766", TipoEmpresa = new TipoEmpresa() });
        //    customers.Add(new Cliente { RutCliente = "19876543", RazonSocial = "TechCorp", NombreContacto = "Manuel Díaz", MailContacto = "mdiaz@mail.com", Direccion = "Las Condes 789", Telefono = "77665544", TipoEmpresa = new TipoEmpresa() });
        //    customers.Add(new Cliente { RutCliente = "14123456", RazonSocial = "EcoGreen", NombreContacto = "Carla Vargas", MailContacto = "cvargas@mail.com", Direccion = "Maipú 321", Telefono = "11223344", TipoEmpresa = new TipoEmpresa() });
        //    customers.Add(new Cliente { RutCliente = "11567890", RazonSocial = "SoftTech", NombreContacto = "Javier Soto", MailContacto = "jsoto@mail.com", Direccion = "Providencia 567", Telefono = "33221100", TipoEmpresa = new TipoEmpresa() });
        //    customers.Add(new Cliente { RutCliente = "16789012", RazonSocial = "SmartSolutions", NombreContacto = "Ana López", MailContacto = "alopez@mail.com", Direccion = "La Reina 345", Telefono = "55443322", TipoEmpresa = new TipoEmpresa() });
        //    customers.Add(new Cliente { RutCliente = "13245678", RazonSocial = "FutureTech", NombreContacto = "Juan Torres", MailContacto = "jtorres@mail.com", Direccion = "Providencia 999", Telefono = "88990011", TipoEmpresa = new TipoEmpresa() });
        //    customers.Add(new Cliente { RutCliente = "14567890", RazonSocial = "Innovative Minds", NombreContacto = "Andrea Castro", MailContacto = "acastro@mail.com", Direccion = "Las Condes 456", Telefono = "22110033",TipoEmpresa = new TipoEmpresa() });
        //    customers.Add(new Cliente { RutCliente = "17654321", RazonSocial = "Creative Designs", NombreContacto = "Ricardo Fernández", MailContacto = "rfernandez@mail.com", Direccion = "Santiago Centro 789", Telefono = "66778899",  TipoEmpresa = new TipoEmpresa() });

        //    string textoBusqueda = txt_busqueda.Text;
        //    // validar que el campo ingresado solo sea numeros
        //    if (int.TryParse(textoBusqueda, out int numero))
        //    {
        //        var resultados = from c in customers
        //                         where c.RutCliente.Contains(textoBusqueda)
        //                         select c;
        //        miTabla.ItemsSource = resultados.ToList();
        //    }
        //    else
        //    {
        //        await this.ShowMessageAsync("Advertencia", "Debe ingresar un rut válido.");
        //    }
        //}

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }


        //private void btn_Buscar_Click1(object sender, RoutedEventArgs e)
        //{
        //    //
        //}

    }
}
