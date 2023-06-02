
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
    /// 

    public partial class AdminClientes : MetroWindow
    {
        public string? VentanaOrigen { get; set; }

        public AdminClientes()
        {
            InitializeComponent();

            this.CargarActividadEmpresa();

            this.CargarTipoEmpresa();

        }




        // crear un método para cargar los datos de la tabla ListaClientes y cargarlo en formulario 
        public AdminClientes(Cliente cliente)
        {
            InitializeComponent();

            this.CargarActividadEmpresa();

            this.CargarTipoEmpresa();

            txt_rut.Text = cliente.RutCliente;
            txt_razonSocial.Text = cliente.RazonSocial;
            txt_nombreContacto.Text = cliente.NombreContacto;
            txt_contacto.Text = cliente.MailContacto;
            txt_direccion.Text = cliente.Direccion;
            txt_telefono.Text = cliente.Telefono;
            cbx_actividadEmpresa.SelectedValue = cliente.IdActividadEmpresa;
            cbx_tipoEmpresa.SelectedValue = cliente.IdTipoEmpresa;
            //btn_Actualizar.Visibility = Visibility.Visible;
            btn_Eliminar.Visibility = Visibility.Visible;

        }



        private void btn_listado_Click(object sender, RoutedEventArgs e)
        {
            ListaClientes listaClientes = new ListaClientes();
            listaClientes.VentanaOrigen = "AdminClientes";
            listaClientes.ParentWindow = this;
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
            var customers = new Cliente().ReadAll();

            string textoBusqueda = txt_busqueda.Text;

            // Validar si el Rut es nulo
            if (string.IsNullOrEmpty(textoBusqueda))
            {
                await this.ShowMessageAsync("Error", "Debe ingresar un Rut.");
                return; // Salir del método para evitar la búsqueda en la base de datos
            }

            // Continuar con la búsqueda en la base de datos
            if (customers.Count > 0)
            {
                var resultados = from c in customers
                                 where c.RutCliente.Equals(textoBusqueda) // Comparar el Rut exactamente
                                 select c;

                if (resultados.Count() > 0)
                {
                    for (int i = 0; i < resultados.Count(); i++)
                    {
                        txt_rut.Text = resultados.ElementAt(i).RutCliente;
                        txt_razonSocial.Text = resultados.ElementAt(i).RazonSocial;
                        txt_nombreContacto.Text = resultados.ElementAt(i).NombreContacto;
                        txt_contacto.Text = resultados.ElementAt(i).MailContacto;
                        txt_direccion.Text = resultados.ElementAt(i).Direccion;
                        txt_telefono.Text = resultados.ElementAt(i).Telefono;
                        cbx_actividadEmpresa.SelectedValue = resultados.ElementAt(i).IdActividadEmpresa;
                        cbx_tipoEmpresa.SelectedValue = resultados.ElementAt(i).IdTipoEmpresa;
                    }
                    //btn_Actualizar.Visibility = Visibility.Visible;
                    btn_Eliminar.Visibility = Visibility.Visible;
                }
                else
                {
                    await this.ShowMessageAsync("Error", "No se encontraron resultados.");
                }
            }
            else
            {
                await this.ShowMessageAsync("Error", "No se encontraron clientes en la base de datos.");
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
            cbx_actividadEmpresa.SelectedIndex = 0;
            cbx_tipoEmpresa.SelectedIndex = 0;
        }

        private void CargarActividadEmpresa()
        {
            ActividadEmpresa actEmpresa = new ActividadEmpresa();

            var actividadesEmpresa = actEmpresa.ReadAll();

            // Crear objeto "Seleccione" y agregarlo al inicio de la lista de actividades de empresa
            var opcionSeleccioneActividad = new ActividadEmpresa { IdActividadEmpresa = 0, Descripcion = "Seleccione" };
            actividadesEmpresa.Insert(0, opcionSeleccioneActividad);

            cbx_actividadEmpresa.ItemsSource = actividadesEmpresa;
            cbx_actividadEmpresa.DisplayMemberPath = "Descripcion";
            cbx_actividadEmpresa.SelectedValuePath = "IdActividadEmpresa";

            cbx_actividadEmpresa.SelectedIndex = 0;
        }

        private void CargarTipoEmpresa()
        {
            TipoEmpresa tipoEmpresa = new TipoEmpresa();

            var tiposEmpresa = tipoEmpresa.ReadAll();

            // Crear objeto "Seleccione" y agregarlo al inicio de la lista de tipos de empresa
            var opcionSeleccioneTipo = new TipoEmpresa { IdTipoEmpresa = 0, Descripcion = "Seleccione" };
            tiposEmpresa.Insert(0, opcionSeleccioneTipo);

            cbx_tipoEmpresa.ItemsSource = tiposEmpresa;
            cbx_tipoEmpresa.DisplayMemberPath = "Descripcion";
            cbx_tipoEmpresa.SelectedValuePath = "IdTipoEmpresa";

            cbx_tipoEmpresa.SelectedIndex = 0;
        }


        private async void ___btn_guardarCliente_Click(object sender, RoutedEventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txt_rut.Text) || 
                string.IsNullOrEmpty(txt_razonSocial.Text) || 
                string.IsNullOrEmpty(txt_nombreContacto.Text) || 
                string.IsNullOrEmpty(txt_contacto.Text) || 
                string.IsNullOrEmpty(txt_direccion.Text) || 
                string.IsNullOrEmpty(txt_telefono.Text)) 
            {
                await this.ShowMessageAsync("Error", "Debe completar todos los campos.");
                return;
            }

            // Validar que se haya seleccionado una opción en los ComboBox
            if ((int)cbx_actividadEmpresa.SelectedValue == 0 || (int)cbx_tipoEmpresa.SelectedValue == 0)
            {
                await this.ShowMessageAsync("Error", "Debe seleccionar una opción en los campos de actividad y tipo de empresa.");
                return;
            }
            // Crear objeto cliente y asignarle los valores de los campos.
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


            };
            // Crear el cliente en la base de datos
            if (cli.Create())
            {
                await this.ShowMessageAsync("Éxito", "Cliente creado correctamente.");

                // Limpiar los campos
                LimpiarCampos();
            }else
            {
                await this.ShowMessageAsync("Error", "No se pudo crear el cliente.");
            }

        }



        private void LimpiarCampos()
        {
            txt_busqueda.Text = "";
            txt_rut.Text = "";
            txt_razonSocial.Text = "";
            txt_nombreContacto.Text = "";
            txt_contacto.Text = "";
            txt_direccion.Text = "";
            txt_telefono.Text = "";
            cbx_actividadEmpresa.SelectedIndex = 0;
            cbx_tipoEmpresa.SelectedIndex = 0;
        }

        private async void btn_Actualizar_Click(object sender, RoutedEventArgs e)
        {
            // Crear objeto cliente y asignarle los valores de los campos.
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


            };
            // Crear el cliente en la base de datos
            if (cli.Update())
            {
                await this.ShowMessageAsync("Éxito", "Cliente actualizado correctamente.");
                // Limpiar los campos
                LimpiarCampos();

                //btn_Actualizar.Visibility = Visibility.Hidden;
                btn_Eliminar.Visibility = Visibility.Hidden;

                LimpiarCampos();

            }
            else
            {
                await this.ShowMessageAsync("Error", "No se pudo actualizar el cliente.");
            }

        }


        private async void btn_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            Cliente cli = new Cliente()
            {
                RutCliente = txt_rut.Text
            };

            if(cli.Delete())
            {
                await this.ShowMessageAsync("Éxito", "Cliente eliminado correctamente.");
                //btn_Actualizar.Visibility = Visibility.Hidden;
                btn_Eliminar.Visibility = Visibility.Hidden;

                LimpiarCampos();

                
            }
            else
            {
                await this.ShowMessageAsync("Error", "No se pudo eliminar el cliente");
            }



        }





    }
}
