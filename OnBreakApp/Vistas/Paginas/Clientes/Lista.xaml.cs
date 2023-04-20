
using BibliotecaDeClases;
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
using System.Windows.Shapes;
using Vistas.Paginas.Contratos;

namespace Vistas.Paginas.Clientes
{
    /// <summary>
    /// Lógica de interacción para Lista.xaml
    /// </summary>
    public partial class Lista 
    {
        private List<Cliente>? customers;

        public Lista(List<Cliente> clientes)
        {
            InitializeComponent();

           // Agrega los clientes a la tabla
           this.miTabla.ItemsSource = clientes;

            // crear una variable global para almacenar los clientes y poder hacer las consultas en cualquier boton o funcion.
            this.customers = clientes;

            // Filtra los tipos de empresas y las actividades de las empresas.

            try
            {
                for (int i = 0; i < clientes.Count; i++)
                {
                    if (clientes[i].TipoEmpresa.Descripcion != null)
                    {
                        filtroTipoEmpresa.Items.Add(clientes[i].TipoEmpresa.Descripcion);
                    }
                    if (clientes[i].ActividadEmpresa.Descripcion != null)
                    {
                        filtroActividadEmpresa.Items.Add(clientes[i].ActividadEmpresa.Descripcion);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Lista()
        {
            InitializeComponent();

        }

        public Lista(Cliente cliente)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string textoBusqueda = txt_busquedaRut.Text;
            var resultadosRut = from c in customers
                                where c.RutCliente.Contains(textoBusqueda)
                                select c;
            // Agregar los resultados al control DataGrid
            miTabla.ItemsSource = resultadosRut.ToList();
        }
        private void ActividadEmpresa_Click(object sender, RoutedEventArgs e)
        {
            //Obtener el valor seleccionado del DropDownButton
            var valorSeleccionado = ((MenuItem)sender).Header;

            var resultadosAct = from c in customers
                                where c.ActividadEmpresa.Descripcion.Equals((String)valorSeleccionado)
                                select c;
            miTabla.ItemsSource = resultadosAct.ToList();
        }
        private void TipoEmpresa_Click(object sender, RoutedEventArgs e)
        {
            //Obtener el valor seleccionado del DropDownButton
            var valorSeleccionado = ((MenuItem)sender).Header;

            var resultadosTip = from c in customers
                                where c.TipoEmpresa.Descripcion.Equals((String)valorSeleccionado)
                                select c;
            miTabla.ItemsSource = resultadosTip.ToList();
        }
        private void miTabla_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //al apretar un dato de la tabla quiero que me lleve a otra ventana
            var clienteSeleccionado = miTabla.SelectedItem as Cliente;
            if (clienteSeleccionado != null)
            {
                var index = new Contratar(clienteSeleccionado);
                this.Close();
                index.Show();
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //this.miTabla.ItemsSource = this.customers;
        }
    }
}
