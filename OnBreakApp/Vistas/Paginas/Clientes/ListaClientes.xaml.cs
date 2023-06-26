
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
        public bool FromMainWindow { get; set; }

        // Variable de clase para almacenar los clientes originales
        private List<Cliente> clientesOriginales;

        public ListaClientes()
        {
            InitializeComponent();


            var actEmp = new ActividadEmpresa().ReadAll();
            var tipEmp = new TipoEmpresa().ReadAll();

            foreach (var actividadEmpresa in actEmp)
            {
                MenuItem menuItemAct = new MenuItem();
                menuItemAct.Header = actividadEmpresa.Descripcion;
                menuItemAct.Click += ActividadEmpresa_Click;
                filtroActividadEmpresa.Items.Add(menuItemAct);
            }

            foreach (var tipoEmpresa in tipEmp)
            {
                MenuItem menuItemTip = new MenuItem();
                menuItemTip.Header = tipoEmpresa.Descripcion;
                menuItemTip.Click += TipoEmpresa_Click;
                filtroTipoEmpresa.Items.Add(menuItemTip);
            }

            // Obtener los clientes originales y asignar actividad empresa y tipo empresa
            clientesOriginales = new Cliente().ReadAll().Select(c =>
            {
                c.ActividadEmpresa = actEmp.Find(a => a.IdActividadEmpresa == c.IdActividadEmpresa);
                c.TipoEmpresa = tipEmp.Find(t => t.IdTipoEmpresa == c.IdTipoEmpresa);
                return c;
            }).ToList();

            // Mostrar los clientes originales en la tabla
            this.tablaClientes.ItemsSource = clientesOriginales;

            this.Loaded += (s, e) =>
            {
                if (VentanaOrigen == null)
                {
                    SelectColumn.Visibility = Visibility.Collapsed;
                }
            };  

        }

        private void Go_Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var actEmp = new ActividadEmpresa().ReadAll();
            var tipEmp = new TipoEmpresa().ReadAll();

            string textoBusqueda = txt_busquedaRut.Text;

            // Consultar la lista de objetos para obtener los resultados de la búsqueda
            var resultadosRut = from c in clientesOriginales
                                where c.RutCliente.Contains(textoBusqueda)
                                select new Cliente
                                {
                                    RutCliente = c.RutCliente,
                                    RazonSocial = c.RazonSocial,
                                    NombreContacto = c.NombreContacto,
                                    MailContacto = c.MailContacto,
                                    Direccion = c.Direccion,
                                    Telefono = c.Telefono,
                                    ActividadEmpresa = actEmp.Find(a => a.IdActividadEmpresa == c.IdActividadEmpresa),
                                    TipoEmpresa = tipEmp.Find(t => t.IdTipoEmpresa == c.IdTipoEmpresa)
                                };

            // Agregar los resultados al control DataGrid
            this.tablaClientes.ItemsSource = resultadosRut.ToList();
        }


        private void ActividadEmpresa_Click(object sender, RoutedEventArgs e)
        {
            var valorSeleccionado = ((MenuItem)sender).Header.ToString();

            // Filtrar los clientes originales por actividad empresa
            var resultadosAct = from c in clientesOriginales
                                where c.ActividadEmpresa != null && c.ActividadEmpresa.Descripcion.Equals(valorSeleccionado)
                                select c;

            this.tablaClientes.ItemsSource = resultadosAct.ToList();
        }

        private void TipoEmpresa_Click(object sender, RoutedEventArgs e)
        {
            var valorSeleccionado = ((MenuItem)sender).Header.ToString();

            // Filtrar los clientes originales por tipo empresa
            var resultadosTip = from c in clientesOriginales
                                where c.TipoEmpresa != null && c.TipoEmpresa.Descripcion.Equals(valorSeleccionado)
                                select c;

            this.tablaClientes.ItemsSource = resultadosTip.ToList();
        }


        private void Resetear(object sender, RoutedEventArgs e)
        {
            this.tablaClientes.ItemsSource = clientesOriginales;
        }

        private void txt_busquedaRut_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {


        }

        private void select_Client(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            var item = button.Tag;
            int index = tablaClientes.Items.IndexOf(item);
            Cliente clienteSeleccionado = (Cliente)tablaClientes.Items[index];

            if (clienteSeleccionado != null)
            {
                if (VentanaOrigen == "AdminClientes")
                {
                    ParentWindow.txt_rut.Text = clienteSeleccionado.RutCliente;
                    ParentWindow.txt_rut.IsReadOnly = true;
                    ParentWindow.txt_razonSocial.Text = clienteSeleccionado.RazonSocial;
                    ParentWindow.txt_nombreContacto.Text = clienteSeleccionado.NombreContacto;
                    ParentWindow.txt_contacto.Text = clienteSeleccionado.MailContacto;
                    ParentWindow.txt_direccion.Text = clienteSeleccionado.Direccion;
                    ParentWindow.txt_telefono.Text = clienteSeleccionado.Telefono;
                    ParentWindow.cbx_actividadEmpresa.Text = clienteSeleccionado.ActividadEmpresa.Descripcion;
                    ParentWindow.cbx_tipoEmpresa.Text = clienteSeleccionado.TipoEmpresa.Descripcion;

                    // esconder boton de guardar 
                    ParentWindow.___btn_guardarCliente.Visibility = Visibility.Hidden;
                    ParentWindow.___btn_actualizarCliente.Visibility = Visibility.Visible;
                    this.Close();
                }
                else if (VentanaOrigen == "AdminContratos")
                {
                    ParentWindow2.txt_buscar_rut.Text = clienteSeleccionado.RutCliente;
                    ParentWindow2.txt_razon_social.Text = clienteSeleccionado.RazonSocial;
                    this.Close();
                }

            }

        }

    }

















}








