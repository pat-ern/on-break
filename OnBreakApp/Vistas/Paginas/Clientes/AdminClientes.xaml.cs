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
    public partial class AdminClientes 
    {

        List<Cliente> clientes = new List<Cliente>();

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

        public AdminClientes(Cliente cliente)
        {
            InitializeComponent();

            // asignar valores a los textbox
            txt_rut.Text = cliente.RutCliente;
            txt_razonSocial.Text = cliente.RazonSocial;
            txt_nombreContacto.Text = cliente.NombreContacto;
            txt_contacto.Text = cliente.MailContacto;
            txt_direccion.Text = cliente.Direccion;
            txt_telefono.Text = cliente.Telefono;
            txt_actividadEmpresa.Text = cliente.ActividadEmpresa.Descripcion;
            txt_tipoEmpresa.Text = cliente.TipoEmpresa.Descripcion;

        }

        public AdminClientes(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        private void btn_listado_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Clientes.ListaClientes listaClientes = new ListaClientes(clientes);
            this.Close();
            listaClientes.Show();
        }

        private void btn_agregar_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Clientes.CreacionCliente creacionCliente = new CreacionCliente();
            this.Close();
            creacionCliente.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
        //private async void btn_Buscar_Click(object sender, RoutedEventArgs e)
        //{
        //}

        private void btn_volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            this.Close();
            main.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private async void btn_buscar_Click_1(object sender, RoutedEventArgs e)
        {
            List<Cliente> customers = new List<Cliente>();

            customers.Add(new Cliente { RutCliente = "16591230", RazonSocial = "Advance", NombreContacto = "Pedro Ramirez", MailContacto = "pramires@mail.com", Direccion = "Calle 1 Villa Las Americas", Telefono = "12345678", ActividadEmpresa = this.actEmp1, TipoEmpresa = this.tipEmp1 });
            customers.Add(new Cliente { RutCliente = "12854638", RazonSocial = "Global Solutions", NombreContacto = "María González", MailContacto = "mgonzalez@mail.com", Direccion = "Av. Providencia 1234", Telefono = "22334455", ActividadEmpresa = this.actEmp2, TipoEmpresa = this.tipEmp2 });
            customers.Add(new Cliente { RutCliente = "13678945", RazonSocial = "Innovatec", NombreContacto = "Luisa Rojas", MailContacto = "lrojas@mail.com", Direccion = "San Diego 456", Telefono = "99887766", ActividadEmpresa = this.actEmp3, TipoEmpresa = this.tipEmp3 });
            customers.Add(new Cliente { RutCliente = "19876543", RazonSocial = "TechCorp", NombreContacto = "Manuel Díaz", MailContacto = "mdiaz@mail.com", Direccion = "Las Condes 789", Telefono = "77665544", ActividadEmpresa = this.actEmp4, TipoEmpresa = this.tipEmp4 });
            customers.Add(new Cliente { RutCliente = "14123456", RazonSocial = "EcoGreen", NombreContacto = "Carla Vargas", MailContacto = "cvargas@mail.com", Direccion = "Maipú 321", Telefono = "11223344", ActividadEmpresa = this.actEmp5, TipoEmpresa = this.tipEmp5 });
            customers.Add(new Cliente { RutCliente = "11567890", RazonSocial = "SoftTech", NombreContacto = "Javier Soto", MailContacto = "jsoto@mail.com", Direccion = "Providencia 567", Telefono = "33221100", ActividadEmpresa = this.actEmp1, TipoEmpresa = this.tipEmp1 });
            customers.Add(new Cliente { RutCliente = "16789012", RazonSocial = "SmartSolutions", NombreContacto = "Ana López", MailContacto = "alopez@mail.com", Direccion = "La Reina 345", Telefono = "55443322", ActividadEmpresa = this.actEmp2, TipoEmpresa = this.tipEmp2 });
            customers.Add(new Cliente { RutCliente = "13245678", RazonSocial = "FutureTech", NombreContacto = "Juan Torres", MailContacto = "jtorres@mail.com", Direccion = "Providencia 999", Telefono = "88990011", ActividadEmpresa = this.actEmp3, TipoEmpresa = this.tipEmp3 });
            customers.Add(new Cliente { RutCliente = "14567890", RazonSocial = "Innovative Minds", NombreContacto = "Andrea Castro", MailContacto = "acastro@mail.com", Direccion = "Las Condes 456", Telefono = "22110033", ActividadEmpresa = this.actEmp4, TipoEmpresa = this.tipEmp4 });
            customers.Add(new Cliente { RutCliente = "17654321", RazonSocial = "Creative Designs", NombreContacto = "Ricardo Fernández", MailContacto = "rfernandez@mail.com", Direccion = "Santiago Centro 789", Telefono = "66778899", ActividadEmpresa = this.actEmp5, TipoEmpresa = this.tipEmp5 });
            
            string textoBusqueda = txt_busqueda.Text;
            // validar que el campo ingresado solo sea numeros
            if (int.TryParse(textoBusqueda, out int numero))
            {
                var resultados = from c in customers
                                 where c.RutCliente.Contains(textoBusqueda)
                                 select c;


                var cliente = new Cliente();

                for (int i = 0; i < resultados.Count(); i++)
                {
                    if(resultados.ElementAt(i).RutCliente == textoBusqueda)
                    {
                        //this.ShowMessageAsync("Advertencia", "Debe ingresar un rut válido.");

                        cliente = resultados.ElementAt(i);

                        txt_rut.Text = cliente.RutCliente;
                        txt_razonSocial.Text = cliente.RazonSocial;
                        txt_nombreContacto.Text = cliente.NombreContacto;
                        txt_contacto.Text = cliente.MailContacto;
                        txt_direccion.Text = cliente.Direccion;
                        txt_telefono.Text = cliente.Telefono;
                        txt_actividadEmpresa.Text = cliente.ActividadEmpresa.Descripcion;
                        txt_tipoEmpresa.Text = cliente.TipoEmpresa.Descripcion;

                    }
                    else
                    {
                        await this.ShowMessageAsync("Advertencia", "Debe ingresar un rut válido.");

                    }


                    break;
                }
            }
            else
            {
                await this.ShowMessageAsync("Advertencia", "Debe ingresar un rut válido.");
            }

        }


        private void TipoEmpresa_Click(object sender, RoutedEventArgs e)
        {
            // Obtener el valor seleccionado del DropDownButton
            //var valorSeleccionado = ((MenuItem)sender).Header;

            //var resultadosTip = from c in customers
            //                    where c.TipoEmpresa.Descripcion.Equals((String)valorSeleccionado)
            //                    select c;

            //miTabla.ItemsSource = resultadosTip.ToList();

        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            // limpiar textbox
            txt_busqueda.Text = "";
            txt_rut.Text = "";
            txt_razonSocial.Text = "";
            txt_nombreContacto.Text = "";
            txt_contacto.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            txt_actividadEmpresa.Text = "";
            txt_tipoEmpresa.Text = "";
             
        }


        //private void btn_Buscar_Click1(object sender, RoutedEventArgs e)
        //{
        //    //
        //}

    }
}
