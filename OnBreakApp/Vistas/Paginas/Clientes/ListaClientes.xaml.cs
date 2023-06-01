
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
using Vistas.Paginas.Contratos;
using OnBreak.BC;
using MahApps.Metro.Controls;

namespace Vistas.Paginas.Clientes 
{
    /// <summary>
    /// Lógica de interacción para Lista.xaml
    /// </summary>
    public partial class ListaClientes : MetroWindow
    {
        public MetroWindow PaginaActual { get; set; }
        public AdminClientes ParentWindow { get; internal set; }

        public AdminContratos ParentWindow2 { get; internal set; }
        public string VentanaOrigen { get; set; }

        public ListaClientes()
        {
            InitializeComponent();


            var clientes = new Cliente().ReadAll();
            var actEmp = new ActividadEmpresa().ReadAll();
            var tipEmp = new TipoEmpresa().ReadAll();


            // Agregar los resultados al control DataGrid
            for (int i = 0; i < clientes.Count; i++)
            {
                clientes[i].ActividadEmpresa = actEmp.Find(a => a.IdActividadEmpresa == clientes[i].IdActividadEmpresa);
                clientes[i].TipoEmpresa = tipEmp.Find(t => t.IdTipoEmpresa == clientes[i].IdTipoEmpresa);
            }

            this.miTabla.ItemsSource = clientes;


        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            var clientes = new Cliente().ReadAll();

            string textoBusqueda = txt_busquedaRut.Text;

            // Consultar la lista de objetos para obtener los resultados de la búsqueda
            var resultadosRut = from c in clientes
                                where c.RutCliente.Contains(textoBusqueda)
                                select c;

            // Agregar los resultados al control DataGrid
            this.miTabla.ItemsSource = resultadosRut.ToList();
        }

        private void ActividadEmpresa_Click(object sender, RoutedEventArgs e)
        {
            //Obtener el valor seleccionado del DropDownButton

            //var clientes = new Cliente().ReadAll();

            //var valorSeleccionado = ((MenuItem)sender).Header;

            //var resultadosAct = from c in clientes
            //                    where c.ActividadEmpresa.Descripcion.Equals((String)valorSeleccionado)
            //                    select c;

            //this.miTabla.ItemsSource = resultadosAct.ToList();

        }

        private void TipoEmpresa_Click(object sender, RoutedEventArgs e)
        {
            //var clientes = new Cliente().ReadAll();

            //var valorSeleccionado = ((MenuItem)sender).Header;

            //var resultadosTip = from c in clientes
            //                    where c.TipoEmpresa.Descripcion.Equals((String)valorSeleccionado)
            //                    select c;

            //this.miTabla.ItemsSource = resultadosTip.ToList();

        }

        private void Resetear(object sender, RoutedEventArgs e)
        {
            //this.miTabla.ItemsSource = this.clientes;
        }

        private void txt_busquedaRut_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {


        }
        private void miTabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var clienteSeleccionado = miTabla.SelectedItem as Cliente;

            if (clienteSeleccionado != null)
            {
                if(VentanaOrigen == "AdminClientes")
                {
                    ParentWindow.txt_rut.Text = clienteSeleccionado.RutCliente;
                    ParentWindow.txt_razonSocial.Text = clienteSeleccionado.RazonSocial;
                    ParentWindow.txt_nombreContacto.Text = clienteSeleccionado.NombreContacto;
                    ParentWindow.txt_contacto.Text = clienteSeleccionado.MailContacto;
                    ParentWindow.txt_direccion.Text = clienteSeleccionado.Direccion;
                    ParentWindow.txt_telefono.Text = clienteSeleccionado.Telefono;
                    ParentWindow.cbx_actividadEmpresa.Text = clienteSeleccionado.ActividadEmpresa.Descripcion;
                    ParentWindow.cbx_tipoEmpresa.Text = clienteSeleccionado.TipoEmpresa.Descripcion;

                }else if(VentanaOrigen == "AdminContratos")
                {
                    ParentWindow2.txt_buscar_rut.Text = clienteSeleccionado.RutCliente;
                    ParentWindow2.txt_razon_social.Text = clienteSeleccionado.RazonSocial;

                }   
                this.Close();




            }
        }



    }

















}
