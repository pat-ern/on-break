
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

using OnBreak.BC;

namespace Vistas.Paginas.Clientes
{
    /// <summary>
    /// Lógica de interacción para Index.xaml
    /// </summary>
    public partial class AdminClientes 
    {
        public AdminClientes()
        {
            InitializeComponent();

            this.CargarActividadEmpresa();

            this.CargarTipoEmpresa();

        }



        private void btn_listado_Click(object sender, RoutedEventArgs e)
        {
            Paginas.Clientes.ListaClientes listaClientes = new ListaClientes();
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

        private void btn_buscar_Click_1(object sender, RoutedEventArgs e)
        {
            //List<Cliente> customers = new List<Cliente>();

            //customers.Add(new Cliente { RutCliente = "16591230", RazonSocial = "Advance", NombreContacto = "Pedro Ramirez", MailContacto = "pramires@mail.com", Direccion = "Calle 1 Villa Las Americas", Telefono = "12345678", ActividadEmpresa = this.actEmp1, TipoEmpresa = this.tipEmp1 });
            //customers.Add(new Cliente { RutCliente = "12854638", RazonSocial = "Global Solutions", NombreContacto = "María González", MailContacto = "mgonzalez@mail.com", Direccion = "Av. Providencia 1234", Telefono = "22334455", ActividadEmpresa = this.actEmp2, TipoEmpresa = this.tipEmp2 });
            //customers.Add(new Cliente { RutCliente = "13678945", RazonSocial = "Innovatec", NombreContacto = "Luisa Rojas", MailContacto = "lrojas@mail.com", Direccion = "San Diego 456", Telefono = "99887766", ActividadEmpresa = this.actEmp3, TipoEmpresa = this.tipEmp3 });
            //customers.Add(new Cliente { RutCliente = "19876543", RazonSocial = "TechCorp", NombreContacto = "Manuel Díaz", MailContacto = "mdiaz@mail.com", Direccion = "Las Condes 789", Telefono = "77665544", ActividadEmpresa = this.actEmp4, TipoEmpresa = this.tipEmp4 });
            //customers.Add(new Cliente { RutCliente = "14123456", RazonSocial = "EcoGreen", NombreContacto = "Carla Vargas", MailContacto = "cvargas@mail.com", Direccion = "Maipú 321", Telefono = "11223344", ActividadEmpresa = this.actEmp5, TipoEmpresa = this.tipEmp5 });
            //customers.Add(new Cliente { RutCliente = "11567890", RazonSocial = "SoftTech", NombreContacto = "Javier Soto", MailContacto = "jsoto@mail.com", Direccion = "Providencia 567", Telefono = "33221100", ActividadEmpresa = this.actEmp1, TipoEmpresa = this.tipEmp1 });
            //customers.Add(new Cliente { RutCliente = "16789012", RazonSocial = "SmartSolutions", NombreContacto = "Ana López", MailContacto = "alopez@mail.com", Direccion = "La Reina 345", Telefono = "55443322", ActividadEmpresa = this.actEmp2, TipoEmpresa = this.tipEmp2 });
            //customers.Add(new Cliente { RutCliente = "13245678", RazonSocial = "FutureTech", NombreContacto = "Juan Torres", MailContacto = "jtorres@mail.com", Direccion = "Providencia 999", Telefono = "88990011", ActividadEmpresa = this.actEmp3, TipoEmpresa = this.tipEmp3 });
            //customers.Add(new Cliente { RutCliente = "14567890", RazonSocial = "Innovative Minds", NombreContacto = "Andrea Castro", MailContacto = "acastro@mail.com", Direccion = "Las Condes 456", Telefono = "22110033", ActividadEmpresa = this.actEmp4, TipoEmpresa = this.tipEmp4 });
            //customers.Add(new Cliente { RutCliente = "17654321", RazonSocial = "Creative Designs", NombreContacto = "Ricardo Fernández", MailContacto = "rfernandez@mail.com", Direccion = "Santiago Centro 789", Telefono = "66778899", ActividadEmpresa = this.actEmp5, TipoEmpresa = this.tipEmp5 });
            
            //string textoBusqueda = txt_busqueda.Text;
            //// validar que el campo ingresado solo sea numeros
            //if (int.TryParse(textoBusqueda, out int numero))
            //{
            //    var resultados = from c in customers
            //                     where c.RutCliente.Contains(textoBusqueda)
            //                     select c;


            //    var cliente = new Cliente();

            //    for (int i = 0; i < resultados.Count(); i++)
            //    {
            //        if(resultados.ElementAt(i).RutCliente == textoBusqueda)
            //        {
            //            //this.ShowMessageAsync("Advertencia", "Debe ingresar un rut válido.");

            //            cliente = resultados.ElementAt(i);

            //            txt_rut.Text = cliente.RutCliente;
            //            txt_razonSocial.Text = cliente.RazonSocial;
            //            txt_nombreContacto.Text = cliente.NombreContacto;
            //            txt_contacto.Text = cliente.MailContacto;
            //            txt_direccion.Text = cliente.Direccion;
            //            txt_telefono.Text = cliente.Telefono;
            //            txt_actividadEmpresa.Text = cliente.ActividadEmpresa.Descripcion;
            //            txt_tipoEmpresa.Text = cliente.TipoEmpresa.Descripcion;

            //        }
            //        else
            //        {
            //            await this.ShowMessageAsync("Advertencia", "Debe ingresar un rut válido.");

            //        }


            //        break;
            //    }
            //}
            //else
            //{
            //    await this.ShowMessageAsync("Advertencia", "Debe ingresar un rut válido.");
            //}

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

             
        }

        private void CargarActividadEmpresa()
        {
            ActividadEmpresa actEmpresa = new ActividadEmpresa();

            cbx_actividadEmpresa.ItemsSource = actEmpresa.ReadAll();

            cbx_actividadEmpresa.DisplayMemberPath = "Descripcion";
            cbx_actividadEmpresa.SelectedValuePath = "IdActividadEmpresa";

            cbx_actividadEmpresa.SelectedIndex = 0;
        }
        private void CargarTipoEmpresa()
        {
            TipoEmpresa tipoEmpresa = new TipoEmpresa();

            cbx_tipoEmpresa.ItemsSource = tipoEmpresa.ReadAll();

            cbx_tipoEmpresa.DisplayMemberPath = "Descripcion";
            cbx_tipoEmpresa.SelectedValuePath = "IdTipoEmpresa";

            cbx_tipoEmpresa.SelectedIndex = 0;

        }

        private async void ___btn_guardarCliente_Click(object sender, RoutedEventArgs e)
        {

            Cliente cli = new Cliente()
            {
                RutCliente = txt_rut.Text,
                RazonSocial = txt_razonSocial.Text,
                NombreContacto = txt_nombreContacto.Text,
                MailContacto = txt_contacto.Text,
                Direccion = txt_direccion.Text,
                Telefono = txt_telefono.Text,
                IdActividadEmpresa = (int)cbx_actividadEmpresa.SelectedValue,
                IdTipoEmpresa = (int)cbx_tipoEmpresa.SelectedValue
                //ActividadEmpresa = (ActividadEmpresa)cbx_actividadEmpresa.SelectedValue,
                //TipoEmpresa = (TipoEmpresa)cbx_tipoEmpresa.SelectedValue


            };

            if (cli.Create())
            {
                await this.ShowMessageAsync("Éxito", "Cliente creado correctamente.");
            }else
            {
                await this.ShowMessageAsync("Error", "No se pudo crear el cliente.");
            }

        }


 


        //private void btn_Buscar_Click1(object sender, RoutedEventArgs e)
        //{
        //    //
        //}

    }
}
